import { Component, OnInit } from '@angular/core';
import { NgbPagination, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { FormBuilder, FormGroup } from '@angular/forms';

import { Parametrico } from "src/app/model/parametricos";
import { ParametricosAdmin } from 'src/app/administrativo/domain/dto/parametricos-admin';

import { ParametricosService } from "src/app/services/parametricos.service";
import { AdministrativoService } from "src/app/services/administrativo.service";

import { ModalFormInstitucionesComponent } from "./modal-form-instituciones/modal-form-instituciones.component";
import { ModalConfirmationFormComponent } from "src/app/shared/components/modal-confirmation-form/modal-confirmation-form.component";
import { ModalSuccessFormComponent } from 'src/app/shared/components/modal-success-form/modal-success-form.component';

@Component({
  selector: 'app-instituciones',
  templateUrl: './instituciones.component.html',
  styleUrls: ['./instituciones.component.css']
})
export class InstitucionesComponent implements OnInit {

  showLoading: boolean = false;
  page = 1;
  pageSize = 10;
  collectionSize: number = 0;
  listInstituciones: Parametrico[] = [];
  allData: Parametrico[] = [];
  parametrico: ParametricosAdmin | null = null;
  parametricoStr: string = '';
  filterForm!: FormGroup;
  searchTerm: string = '';
  msg: string = '';
  nivelSelected: Parametrico | undefined;
  listNiveles: Parametrico[] = [];
  associateDisabled: boolean = true;

  constructor(
    private adminService: AdministrativoService,
    public formBuilder: FormBuilder,
    private modalService: NgbModal,
    public parametricosService: ParametricosService,
  ) {
    this.filterForm = this.formBuilder.group({
      searchTerm: ['']
    });
  }

  ngOnInit(): void {
    this.msg = 'Seleccione un nivel educativo para listar las instituciones!';
    this.parametrico = this.adminService.getCurrentParametrico();
    this.parametricoStr = this.parametrico?.parametrico !== undefined ? this.parametrico?.parametrico : '';
    this.getNiveles();
    // this.getInstituciones();
  }

  /**
   * Función que consulta el listado de los niveles educativos
   */
  getNiveles() {
    this.showLoading = true;
    this.parametricosService.getParametricosDefault('NivelEducativo').subscribe((response) => {
      this.listNiveles = response.filter(inst => inst.id >= '6');
      this.showLoading = false;
    });
  }

  /**
   * Función que consulta el listado de las instituciones
   */
  // getInstituciones() {
  //   this.showLoading = true;
  //   this.parametricosService.getParametricosDefault(this.parametricoStr).subscribe((response) => {
  //     this.allData = response;
  //     this.showLoading = false;
  //   });
  // }

  /**
   * Función que recibe el cambio de nivel en el filtro
   */
  changeNivel(event: Event) {
    this.showLoading = true;
    const target = event.target as HTMLInputElement;
    this.nivelSelected = this.listNiveles.find(nivel => nivel.id == target.value);
    this.getInstitucionesPorNivelSeleccionado();

    // si hay nivel seleccionado entonces el botón de asociar se habilita
    if (this.nivelSelected !== undefined) {
      this.associateDisabled = false;
    }
  }

  getInstitucionesPorNivelSeleccionado() {
    const nivelId = this.nivelSelected !== undefined ? parseInt(this.nivelSelected.id) : 0;
    // Consulta las instituciones por el nivel educativo
    this.adminService.getInstitucionesByNivel(nivelId).subscribe(
      response => {
        // Setea el listado de instituciones por las que lleguen del back
        this.allData = response;
        this.listInstituciones = response;
        this.collectionSize = this.listInstituciones.length;
        this.showLoading = false;
        this.msg = '';

        // Si no hay instituciones por ese nivel entonces cambia el mensaje
        if (this.listInstituciones.length == 0) {
          this.msg = 'No se encontraron instituciones asociadas al nivel educativo!';
        }
      },
      error => {
        this.showLoading = false;
        this.msg = 'Ocurrió un error consultando las instituciones asociadas al nivel educativo!';
        console.log(error);
      }
    );
  }

  /**
   * Función que abre e inicia el modal con el formulario para poder agregar o editar una institución
   */
  openModalForm(type: string, parametrico: Parametrico | null = null) {
    const modalForm = this.modalService.open(ModalFormInstitucionesComponent, {
      size: 'lg', backdrop: 'static', animation: true
    });

    // Depende del tipo entonces envía información diferente
    switch (type) {
      case 'add':
        modalForm.componentInstance.title = `Crear`;
        modalForm.componentInstance.type = 'new';
        break;
      case 'associate':
        modalForm.componentInstance.title = `Asociar una institución y un nivel educativo`;
        modalForm.componentInstance.type = 'associate';
        modalForm.componentInstance.data = parametrico;
        break;
    }

    modalForm.componentInstance.parametrico = this.parametrico;
    modalForm.componentInstance.listNiveles = this.listNiveles;
    modalForm.componentInstance.nivelSelected = this.nivelSelected;

    modalForm.result.then(response => {
      if (response != null) {

        const modalSuccessForm = this.modalService.open(ModalSuccessFormComponent, {
          size: 'sm', backdrop: 'static', animation: true
        });
        modalSuccessForm.componentInstance.body =  `Se guardó con éxito la institución asociado al nivel educativo!`;
        setTimeout(() => {
          this.getInstitucionesPorNivelSeleccionado();
        }, 200);
      }
    });
  }

  /**
   * Función que recibe una institucion parametrico y lo elimina con previa confirmación
   */
  deleteAsociacion(inst: Parametrico) {
    // Lanza modal de confirmación para la eliminación de la asociación
    const modalConfirm = this.modalService.open(ModalConfirmationFormComponent, {
      size: 'md', backdrop: 'static', animation: true
    });
    const nivelId = this.nivelSelected !== undefined ? parseInt(this.nivelSelected.id) : 0;

    modalConfirm.componentInstance.body = `Seguro que desea eliminar la
      institución #${inst.id} ${inst.nombre} del nivel educativo ${this.nivelSelected?.nombre}?`;
    modalConfirm.result.then(response => {
      if (response) {
        this.showLoading = true;
        this.adminService.deleteAsociacionInstitucionesNiveles(nivelId, inst.id).subscribe(
          response => {
            this.getInstitucionesPorNivelSeleccionado();
          },
          error => {
            this.showLoading = false;
            console.log(error);
          }
        );
      }
    });
  }

  search(): void {
    const value = this.filterForm.controls['searchTerm'].value.toLowerCase();
    this.msg = '';

    if (value !== '') {
      this.listInstituciones = this.allData.filter((val) => {
        const nombre = val.nombre ? val.nombre.toLowerCase() : '';
        const texto = val.texto ? val.texto.toLowerCase() : '';

        return nombre.includes(value) || texto.includes(value);
      });

      this.collectionSize = this.listInstituciones.length;

      // Si no hay instituciones por ese nivel entonces cambia el mensaje
      if (this.listInstituciones.length == 0) {
        this.msg = 'No se encontraron instituciones asociadas con el filtro búsqueda aplicada!';
      }
    } else {
      this.listInstituciones = this.allData;
    }
  }

}
