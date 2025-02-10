import { Component, OnInit } from '@angular/core';
import { NgbPagination, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { FormBuilder, FormGroup } from '@angular/forms';

import { Parametrico } from "src/app/model/parametricos";
import { ParametricosAdmin } from 'src/app/administrativo/domain/dto/parametricos-admin';

import { ParametricosService } from "src/app/services/parametricos.service";
import { AdministrativoService } from "src/app/services/administrativo.service";

import { ModalFormDescripcionVacanteComponent } from "./modal-form-descripcion-vacante/modal-form-descripcion-vacante.component";
import { ModalConfirmationFormComponent } from "src/app/shared/components/modal-confirmation-form/modal-confirmation-form.component";
import { ModalSuccessFormComponent } from 'src/app/shared/components/modal-success-form/modal-success-form.component';

@Component({
  selector: 'app-descripcion-vacante',
  templateUrl: './descripcion-vacante.component.html',
  styleUrls: ['./descripcion-vacante.component.css']
})
export class DescripcionVacanteComponent implements OnInit {

  showLoading: boolean = false;
  page = 1;
  pageSize = 10;
  collectionSize: number = 0;
  listDescVacantes: Parametrico[] = [];
  allData: Parametrico[] = [];
  parametrico: ParametricosAdmin | null = null;
  parametricoStr: string = '';
  filterForm!: FormGroup;
  searchTerm: string = '';

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
    this.parametrico = this.adminService.getCurrentParametrico();
    this.parametricoStr = this.parametrico?.parametrico !== undefined ? this.parametrico?.parametrico : '';
    this.getDescripcionesVacante();
  }

  /**
   * Función que consulta el listado de las plantillas de descripciones vacante
   */
  getDescripcionesVacante() {
    this.showLoading = true;
    this.parametricosService.getParametricosDefault(this.parametricoStr).subscribe((response) => {
      this.allData = response;
      this.listDescVacantes = response;
      this.showLoading = false;
      this.collectionSize = this.listDescVacantes.length;
    });
  }

  /**
   * Función que abre e inicia el modal con el formulario para poder agregar o editar una plantilla de descripción de la vacante
   */
  openModalForm(type: string, parametrico: Parametrico | null = null) {
    const modalForm = this.modalService.open(ModalFormDescripcionVacanteComponent, {
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

    modalForm.componentInstance.parametrico = this.parametrico;

    modalForm.result.then(response => {
      if (response != null) {

        const modalSuccessForm = this.modalService.open(ModalSuccessFormComponent, {
          size: 'sm', backdrop: 'static', animation: true
        });
        modalSuccessForm.componentInstance.body =  `Se guardó con éxito la plantilla de descripcíón de la vacante.`;
        setTimeout(() => {
          this.getDescripcionesVacante();
        }, 200);
      }
    });
  }

  /**
   * Función que recibe una descripción de la vacante parametrico y lo elimina con previa confirmación
   */
  deleteDescVacante(descVacante: Parametrico) {
    // Lanza modal de confirmación para la eliminación
    const modalConfirm = this.modalService.open(ModalConfirmationFormComponent, {
      size: 'md', backdrop: 'static', animation: true
    });
    modalConfirm.componentInstance.body = `Seguro que desea eliminar la plantilla de descripcíón de la vacante #${descVacante.id}?`;
    modalConfirm.result.then(response => {
      if (response) {
        this.showLoading = true;
        this.adminService.deleteParametrico(descVacante.id, this.parametricoStr).subscribe(
          response => {
            this.getDescripcionesVacante();
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

    this.listDescVacantes = this.allData.filter((val) => {
      const descripcion = val.descripcion ? val.descripcion.toLowerCase() : ''; // Verificar si descripcion es null
      const texto = val.texto ? val.texto.toLowerCase() : ''; // Verificar si texto es null

      return descripcion.includes(value) || texto.includes(value);
    });

    this.collectionSize = this.listDescVacantes.length;
  }

}
