import { Component, OnInit } from '@angular/core';
import { DatePipe } from '@angular/common';
import { NgbPagination, NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { ParametricoListado, Parametrico } from "src/app/model/parametricos";

import { PARAMETRICOS, ParametricosService, PARAMETRICOS_FILTROS } from "src/app/services/parametricos.service";
import { AdministrativoService } from "src/app/services/administrativo.service";

import { ModalFormCriteriosMatchComponent } from "./modal-form-criterios-match/modal-form-criterios-match.component";
import { ModalConfirmationFormComponent } from "src/app/shared/components/modal-confirmation-form/modal-confirmation-form.component";
import { ModalSuccessFormComponent } from 'src/app/shared/components/modal-success-form/modal-success-form.component';
import { ParametricosAdmin } from 'src/app/administrativo/domain/dto/parametricos-admin';

@Component({
  selector: 'app-criterios-match',
  templateUrl: './criterios-match.component.html',
  styleUrls: ['./criterios-match.component.css']
})
export class CriteriosMatchComponent implements OnInit {

  showLoading: boolean = false;
  isCommit: boolean = false;
  page = 1;
  pageSize = 10;
  collectionSize: number = 0;
  listCriterios: Parametrico[] = [];
  allData: Parametrico[] = [];
  currentTipoVacante: number = 1;
  msg: string = '';

  constructor(
    private adminService: AdministrativoService,
    private datePipe: DatePipe,
    private modalService: NgbModal,
    public parametricosService: ParametricosService,
  ) { }

  ngOnInit(): void {
    this.getCriteriosMatch();
  }

  /**
   * Función que consulta el listado de criterios match
   */
  getCriteriosMatch() {
    this.showLoading = true;
    this.parametricosService.getParametricosDefault('CriterioMatch').subscribe((response) => {
      this.allData = response;
      this.listCriterios = this.allData.filter(criterio => criterio.tipoVacanteId == this.currentTipoVacante);
      this.showLoading = false;
      this.collectionSize = this.listCriterios.length;
    });
  }

  /**
   * Función que abre e inicia el modal con el formulario para poder agregar o editar un criterio
   */
  openModalForm(type: string, parametrico: Parametrico | null = null) {
    const modalForm = this.modalService.open(ModalFormCriteriosMatchComponent, {
      size: 'lg', backdrop: 'static', animation: true
    });

    // Depende del tipo entonces envía información diferente
    switch (type) {
      case 'add':
        modalForm.componentInstance.title = `Crear`;
        modalForm.componentInstance.type = 'new';
        break;
      case 'edit':
        modalForm.componentInstance.title = `Editar registro # ${parametrico?.id}`;
        modalForm.componentInstance.type = 'edit';
        modalForm.componentInstance.data = parametrico;
        break;
    }

    modalForm.componentInstance.listCriterios = this.listCriterios;
    modalForm.componentInstance.currentTipoVacante = this.currentTipoVacante;

    modalForm.result.then(response => {
      if (response != null) {
        if (type == 'add') {
          this.listCriterios.push(response);
        } else {
          // Busca el objeto por su id
          const index = this.listCriterios.findIndex((item) => item.id === response.id);
          if (index !== -1) {
            // Si se encuentra el objeto, realiza la edición
            this.listCriterios[index] = response;
          }
        }

        this.isCommit = true;
        this.msg = '';
      }
    });
  }

  /**
   * Función que recibe un criterio parametrico y lo elimina con previa confirmación
   */
  deleteCriterio(criterio: Parametrico) {
    // Lanza modal de confirmación para la eliminación
    const modalConfirm = this.modalService.open(ModalConfirmationFormComponent, {
      size: 'md', backdrop: 'static', animation: true
    });
    modalConfirm.componentInstance.body = `Seguro que desea eliminar el criterio del match emparejamiento vacante #${criterio.id}?`;
    modalConfirm.result.then(response => {
      // Si se realiza la confirmación entonces elimina el criterio del listado y lo pasa para el de eliminados
      if (response) {
        const index = this.listCriterios.indexOf(criterio);
        if (index !== -1) {
          this.listCriterios.splice(index, 1);
          this.isCommit = true;
          this.msg = '';
        }
      }
    });
  }

  setListCriterios(tipoVacante: number) {
    this.currentTipoVacante = tipoVacante;
    this.listCriterios = this.allData.filter(criterio => criterio.tipoVacanteId == tipoVacante);
    this.collectionSize = this.listCriterios.length;
  }

  /**
   * Función con la lógica para hacer commit o guardado de los cambios en la tabla, esto contempla add, edit y delete
   */
  logicCommit(): void {
    this.showLoading = true;
    this.isCommit = false;
    this.msg = '';

    // Primero valida si los elementos de la lista cumplen el peso requerido que es 100
    if (this.validaPesoTotal()) {
      let saveCompleted = true;

      // Obtener elementos nuevos
      const nuevosElementos = this.listCriterios.filter((cambio) => !this.allData.find((item) => item.id === cambio.id));

      // Obtener elementos editados
      const elementosEditados = this.listCriterios.filter((cambio) => {
        const elementoOriginal = this.allData.find((item) => item.id === cambio.id);
        return elementoOriginal && !this.sonIguales(elementoOriginal, cambio);
      });

      // Obtener elementos eliminados
      const elementosEliminados = this.allData.filter((item) => !this.listCriterios.find((cambio) => cambio.id === item.id));

      // Crear
      for (const criterioNuevo of nuevosElementos) {
        try {
          this.showLoading = true;
          this.adminService.saveNewParametrico(criterioNuevo, 'CriterioMatch').subscribe(
            response => {},
            error => {
              this.showLoading = false;
              saveCompleted = false;
              this.msg += `Error al crear el criterio '${criterioNuevo.descripcion}'. \n`;
              console.log(error);
            }
          );
        } catch (error) {
          // Manejar el error de la solicitud POST
          console.error('Error al crear un elemento:', error);
          this.msg += `Error al crear el criterio '${criterioNuevo.descripcion}'. \n`;
          saveCompleted = false;
          this.showLoading = false;
        }
      }

      // Editar
      for (const criterioEditado of elementosEditados) {
        try {
          this.showLoading = true;
          this.adminService.saveEditParametrico(criterioEditado, 'CriterioMatch').subscribe(
            response => {},
            error => {
              this.showLoading = false;
              saveCompleted = false;
              this.msg += `Error al editar el criterio #'${criterioEditado.id}'. \n`;
              console.log(error);
            }
          );
        } catch (error) {
          // Manejar el error de la solicitud POST
          console.error('Error al editar un elemento:', error);
          this.msg += `Error al editar el criterio #'${criterioEditado.id}'. \n`;
          saveCompleted = false;
          this.showLoading = false;
        }
      }

      // Eliminar
      for (const criterioEliminado of elementosEliminados) {
        try {
          this.showLoading = true;
          this.adminService.deleteParametrico(criterioEliminado.id, 'CriterioMatch').subscribe(
            response => {},
            error => {
              this.showLoading = false;
              saveCompleted = false;
              this.msg += `Error al eliminar el criterio #${criterioEliminado.id}. \n`;
              console.log(error);
            }
          );
        } catch (error) {
          // Manejar el error de la solicitud DELETE
          console.error('Error al eliminar un elemento:', error);
          this.msg += `Error al eliminar el criterio #${criterioEliminado.id}. \n`;
          saveCompleted = false;
          this.showLoading = false;
        }
      }

      if (saveCompleted) {
        const modalSuccessForm = this.modalService.open(ModalSuccessFormComponent, {
          size: 'sm', backdrop: 'static', animation: true
        });
        modalSuccessForm.componentInstance.body =  `Se guardaron con éxito los cambios de los criterios del match emparejamiento vacante.`;
        this.getCriteriosMatch();
      } else {
        this.showLoading = false;
      }
    } else {
      this.msg = 'La sumatoria del peso de los criterios debe ser igual a 100!';
      this.showLoading = false;
    }

  }

  /**
   * Función que valida si son iguales los elementos de criterio
   */
  sonIguales(criterioA: Parametrico, criterioB: Parametrico): boolean {
    let esIgual = false;

    // Compara los elementos para ver si son iguales
    if (criterioA.id === criterioB.id && criterioA == criterioB) {
      esIgual = true;
    }

    return esIgual;
  }

  /**
   * Función que valida el total del peso de cada criterio. La sumatoria de los que hayan activos debe ser máximo 100
   * Los elementos inactivos no suman
   * Si o si debe sumar 100, ni más ni menos
   */
  validaPesoTotal() {
    return this.getPesoTotal() == 100 ? true : false;
  }

  getPesoTotal() {
    let sumaPeso = 0;
    // Extrae el peso del listado
    sumaPeso = this.listCriterios.reduce((totalPeso, item) => {
      if (item.estado === true && typeof item.peso === 'number') {
        return totalPeso + item.peso;
      }
      return totalPeso;
    }, 0);
    return sumaPeso;
  }

}
