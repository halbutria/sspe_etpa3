import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { PARAMETRICOS, ParametricosService, PARAMETRICOS_FILTROS } from "../../../../services/parametricos.service";
import { CvService } from "../../../../services/cv.service";
import { CiudadanoService } from "src/app/services/ciudadano.service";

import { CiudadanoGet, EducacionNoFormal } from 'src/app/model/ciudadano';
import { ParametricoListado, Parametrico } from "../../../../model/parametricos";

import { ModalConfirmationFormComponent } from "src/app/shared/components/modal-confirmation-form/modal-confirmation-form.component";
import { ModalSuccessFormComponent } from "src/app/shared/components/modal-success-form/modal-success-form.component";
import { ModalFormNoFormalEducationComponent } from "./modal-form-no-formal-education/modal-form-no-formal-education.component";

@Component({
  selector: 'app-no-formal-education',
  templateUrl: './no-formal-education.component.html',
  styleUrls: ['./no-formal-education.component.css']
})
export class NoFormalEducationComponent implements OnInit {

  ciudadano!: CiudadanoGet | null;
  PARAMETRICOS = PARAMETRICOS;
  tieneForm!: FormGroup;

  showLoading: boolean = false;
  disableBtnAdd: boolean = false;
  tieneEducacionNoFormal: boolean | any = true;
  checkedTieneEducacionNoFormalSi: boolean = false;
  checkedTieneEducacionNoFormalNo: boolean = false;
  listNoFormalEducation: EducacionNoFormal[] = [];

  listTipoCapacitacion: Parametrico[] = [];
  listEstado: Parametrico[] = [];

  constructor(
    public parametricosService: ParametricosService,
    public cvService: CvService,
    public ciudadanoService: CiudadanoService,
    private modalService: NgbModal,
    public formBuilder: FormBuilder,
  ) {
    this.tieneForm = this.formBuilder.group({
      tiene: [null]
    });
  }

  ngOnInit(): void {
    // Consulta la información del storage en el servicio
    this.ciudadano = this.cvService.getCiudadano;
    if (this.ciudadano !== null) {
      // Valida si el ciudadano tiene marcada la opción de SI TIENE EDUCACIÓN NO FORMAL
      this.tieneEducacionNoFormal = this.ciudadano.tieneEducacionNoFormal;
      this.getParametricos();
      this.setDisableBtnAdd();
      this.setDisableToggle();

      // Si tiene marcada la opcion de SI TIENE EDUCACIÓN NO FORMAL entonces consulta el listado
      setTimeout(() => {
        this.getListNoFormalEducation();
      }, 500);
    }
  }

  /**
   * Función que carga los listados de los paramétricos para poder mostrar los valores en los CARD
   */
  getParametricos() {
    this.cvService.$tipoCapacitacion.subscribe(response => this.listTipoCapacitacion = response);
    this.cvService.$estadoEducacionNoFormal.subscribe(response => this.listEstado = response);
  }

  setDisableBtnAdd() {
    if (this.tieneEducacionNoFormal == false || this.tieneEducacionNoFormal == null) {
      this.disableBtnAdd = true;
    } else {
      this.disableBtnAdd = false;
    }
  }

  setDisableToggle() {
    if (this.listNoFormalEducation.length > 0) {
      this.tieneForm.controls['tiene'].disable();
    } else {
      this.tieneForm.controls['tiene'].enable();
    }
    // Setea los checked de los botones
    switch (this.tieneEducacionNoFormal) {
      case true:
        this.checkedTieneEducacionNoFormalSi = true;
        this.checkedTieneEducacionNoFormalNo = false;
        this.tieneForm.controls['tiene'].setValue('true');
        break;
      case false:
        this.checkedTieneEducacionNoFormalSi = false;
        this.checkedTieneEducacionNoFormalNo = true;
        this.tieneForm.controls['tiene'].setValue('false');
        break;
      default:
        this.checkedTieneEducacionNoFormalSi = false;
        this.checkedTieneEducacionNoFormalNo = false;
        // this.tieneForm.controls['tiene'].setValue('false');
        break;
    }
  }

  /**
   * Función que recibe la selección del campo check y habilita o no el botón
   */
  cambiaTieneEducacionNoFormal(e: any) {
    this.tieneEducacionNoFormal = e.target.value == 'true' ? true : false;
    this.setDisableBtnAdd();
    if (this.tieneEducacionNoFormal) {
      this.openModalForm('new');
    } else {
      this.showLoading = true;
      // Envía a guardar el NO sobre el TIENE
      this.cvService.putTieneEducacionNoFormal(this.ciudadano?.id, false).subscribe(
        response => {
          this.cvService.toggleBooleanDataCiudadano('tieneEducacionNoFormal', false);
          // Consulta los porcentajes para actualizarlos
          this.cvService.getPorcentajesAvance(this.ciudadano?.id).subscribe(
            response => {
              this.cvService.updatePorcentajes(response);
              const modalSuccessForm = this.modalService.open(ModalSuccessFormComponent, {
                size: 'sm', backdrop: 'static', animation: true
              });
              modalSuccessForm.componentInstance.body = 'Educación no formal actualizada con éxito!';
              this.showLoading = false;
            }
          );
        },
        error => {
          console.log(error);
          this.showLoading = false;
        }
      );
    }
  }

  /**
   * Función que se encarga de consultar si hay items de educacion no formal para el ciudadano
   */
  getListNoFormalEducation() {
    this.showLoading = true;
    // Sólo consulta el listado y está marcada la opción de "Si tiene educacion no formal"
    if (this.tieneEducacionNoFormal) {
      this.cvService.getListEducacionNoFormal(this.ciudadano?.id).subscribe(
        response => {
          setTimeout(() => {
            this.listNoFormalEducation = response;
            this.setDisableToggle();
            this.showLoading = false;
          }, 1000);
        },
        error => {
          console.log(error);
          this.showLoading = false;
          // Valida si el mensaje de error es por que no tiene informacion -- No existe Informacion.
          if (error.error.error == 'No existe Informacion.') {
            this.listNoFormalEducation = [];
            // Setea el tiene en false
            this.cvService.putTieneEducacionNoFormal(this.ciudadano?.id, false).subscribe(
              response => {
                this.cvService.toggleBooleanDataCiudadano('tieneEducacionNoFormal', response.tieneEducacionNoFormal);
                this.tieneEducacionNoFormal = response.tieneEducacionNoFormal;
                this.setDisableBtnAdd();
                this.setDisableToggle();
                this.cvService.getPorcentajesAvance(this.ciudadano?.id).subscribe(
                  response => { this.cvService.updatePorcentajes(response); }
                );
              },
              error => {
                console.log(error);
              }
            );
          }
        }
      );
    } else {
      this.showLoading = false;
    }
  }

  /**
   * Función que se encarga de enviar la educación no formal para eliminar al servicio
   */
  deleteNoFormalEducation(info: EducacionNoFormal) {
    if (info) {
      let tipoCap = '';
      let estado = '';
      if (this.listTipoCapacitacion.length > 0) {
        tipoCap = this.getNameTipoCapacitacion(info.tipoCertificadoCapacitacionId);
      }
      if (this.listEstado.length > 0) {
        estado = this.getNameEstado(info.estadoId);
      }

      // Lanza modal de confirmación para la eliminación
      const modalConfirm = this.modalService.open(ModalConfirmationFormComponent, {
        size: 'md', backdrop: 'static', animation: true
      });
      modalConfirm.componentInstance.body = `Seguro que desea eliminar el registro de educación no formal ${tipoCap} - ${estado}`;
      modalConfirm.result.then(response => {
        if (response) {
          this.showLoading = true;
          this.cvService.deleteNoFormalEducation(info.id).subscribe(
            response => {
              // const index = this.listNoFormalEducation.findIndex(edu => edu.id == info.id);
              // this.listNoFormalEducation.splice(index, 1);
              this.getListNoFormalEducation();
            },
            error => {
              this.showLoading = false;
              console.log(error);
            }
          );
        }
      });
    }
  }

  /**
   * Función que abre e inicia el modal con el formulario para poder agregar o editar una educación no formal
   */
  openModalForm(tipo: string, info: EducacionNoFormal | null = null) {
    const modalForm = this.modalService.open(ModalFormNoFormalEducationComponent, {
      size: 'lg', backdrop: 'static', animation: true
    });
    modalForm.componentInstance.type = tipo;
    modalForm.componentInstance.ciudadanoId = this.ciudadano?.id;
    modalForm.componentInstance.list = this.listNoFormalEducation;
    // Si el tipo es edit entonces envía la data
    if (tipo === 'edit') {
      modalForm.componentInstance.data = info;
    }
    modalForm.result.then(response => {
      if (response != null) {
        this.getListNoFormalEducation();
        const modalSuccessForm = this.modalService.open(ModalSuccessFormComponent, {
          size: 'sm', backdrop: 'static', animation: true
        });
        modalSuccessForm.componentInstance.body = 'Se guardó con éxito el registro de educación no formal!';
        // Consulta los porcentajes para actualizarlos
        this.cvService.getPorcentajesAvance(this.ciudadano?.id).subscribe(
          response => { this.cvService.updatePorcentajes(response); }
        );
      } else if (response === null && this.listNoFormalEducation.length === 0) {
        // Si devuleve null y no hay nada en el listado pone el toggle a como está en el ciudadano
        this.tieneEducacionNoFormal = this.ciudadano?.tieneInformacionLaboral;
        this.setDisableToggle();
      }
    });
  }

  getNameTipoCapacitacion(tipo: number): string {
    if (this.listTipoCapacitacion.findIndex(element => +element.id == tipo) !== -1) {
      return this.listTipoCapacitacion[this.listTipoCapacitacion.findIndex(element => +element.id == tipo)].nombre;
    }
    return '';
  }
  getNameEstado(estado: number): string {
    if (this.listEstado.findIndex(element => +element.id == estado) !== 1) {
      return this.listEstado[this.listEstado.findIndex(element => +element.id == estado)].nombre;
    }
    return '';
  }

}
