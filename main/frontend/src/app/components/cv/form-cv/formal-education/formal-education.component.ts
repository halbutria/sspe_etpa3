import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { NgbDatepickerI18n, NgbDateStruct, NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { PARAMETRICOS, ParametricosService, PARAMETRICOS_FILTROS } from "../../../../services/parametricos.service";
import { CvService } from "../../../../services/cv.service";
import { CustomDatepickerI18nService, I18n } from "src/app/services/custom-datepicker-i18n.service";

import { CiudadanoService } from "src/app/services/ciudadano.service";

import { ParametricoListado, Parametrico } from "../../../../model/parametricos";
import { Ciudadano, CiudadanoGet, EducacionFormal } from "../../../../model/ciudadano";

import { ModalValidationFormComponent } from "src/app/shared/components/modal-validation-form/modal-validation-form.component";
import { ModalConfirmationFormComponent } from "src/app/shared/components/modal-confirmation-form/modal-confirmation-form.component";
import { ModalSuccessFormComponent } from "src/app/shared/components/modal-success-form/modal-success-form.component";
import { FormModalComponent } from "./form-modal/form-modal.component";

@Component({
  selector: 'app-formal-education',
  templateUrl: './formal-education.component.html',
  styleUrls: ['./formal-education.component.css']
})
export class FormalEducationComponent implements OnInit {

  ciudadano!: CiudadanoGet | null;
  PARAMETRICOS = PARAMETRICOS;
  tieneForm!: FormGroup;

  submitted: boolean = false;
  showLoading: boolean = false;
  disableBtnAdd: boolean = false;
  disableToggle: boolean = false;
  tieneEducacionFormal: boolean | any = true;
  checkedTieneEducacionFormalSi: boolean = false;
  checkedTieneEducacionFormalNo: boolean = false;
  listFormalEducation: EducacionFormal[] = [];

  listNivelEducativo: Parametrico[] = [];
  listNucleoConocimiento: Parametrico[] = [];
  listAreaConocimiento: Parametrico[] = [];
  listEstadoEducacion: Parametrico[] = [];
  listTituloHomologado: Parametrico[] = [];
  listInstitucion: Parametrico[] = [];

  constructor(
    public formBuilder: FormBuilder,
    public parametricosService: ParametricosService,
    public cvService: CvService,
    public ciudadanoService: CiudadanoService,
    private modalService: NgbModal,
  ) {
    this.tieneForm = this.formBuilder.group({
      tiene: [null]
    });
  }

  ngOnInit(): void {
    // Consulta la información del storage en el servicio
    this.ciudadano = this.cvService.getCiudadano;
    if (this.ciudadano !== null) {
      // Valida si el ciudadano tiene marcada la opción de SI TIENE EDUCACION FORMAL
      this.tieneEducacionFormal = this.ciudadano.tieneEducacionFormal;
      this.getParametricos();
      this.setDisableBtnAdd();
      this.setDisableToggle();

      // Si tiene marcada la opcion de SI TIENE EDUCACION FORMAL entonces consulta el listado
      setTimeout(() => {
        this.getListFormalEducation();
      }, 500);
    }
  }

  /**
   * Función que abre e inicia el modal con el formulario para poder agregar o editar una educación formal
   */
  openModalForm(tipo: string, educacion: EducacionFormal | null = null) {
    const modalForm = this.modalService.open(FormModalComponent, {
      size: 'lg', backdrop: 'static', animation: true
    });
    modalForm.componentInstance.type = tipo;
    modalForm.componentInstance.ciudadanoId = this.ciudadano?.id;
    modalForm.componentInstance.list = this.listFormalEducation;
    // Si el tipo es edit entonces envía la data
    if (tipo === 'edit') {
      modalForm.componentInstance.data = educacion;
    }
    modalForm.result.then(response => {
      if (response != null) {
        this.getListFormalEducation();
        const modalSuccessForm = this.modalService.open(ModalSuccessFormComponent, {
          size: 'sm', backdrop: 'static', animation: true
        });
        modalSuccessForm.componentInstance.body = 'Se guardó con éxito el registro de educación formal!';
        // Consulta los porcentajes para actualizarlos
        this.cvService.getPorcentajesAvance(this.ciudadano?.id).subscribe(
          response => { this.cvService.updatePorcentajes(response); }
        );
      } else if (response === null && this.listFormalEducation.length === 0) {
        // Si devuleve null y no hay nada en el listado pone el toggle a como está en el ciudadano
        this.tieneEducacionFormal = this.ciudadano?.tieneEducacionFormal;
        this.setDisableToggle();
      }
    });
  }

  /**
   * Función que recibe la selección del campo check y envía a guardar al backend
   */
  cambiaTieneEducacionFormal(e: any) {
    this.tieneEducacionFormal = e.target.value == 'true' ? true : false;
    this.setDisableBtnAdd();
    if (this.tieneEducacionFormal) {
      this.openModalForm('new');
    } else {
      this.showLoading = true;
      // Envía a guardar el NO sobre el TIENE
      this.cvService.putTieneEducacionFormal(this.ciudadano?.id, false).subscribe(
        response => {
          this.cvService.toggleBooleanDataCiudadano('tieneEducacionFormal', false);
          // Consulta los porcentajes para actualizarlos
          this.cvService.getPorcentajesAvance(this.ciudadano?.id).subscribe(
            response => {
              this.cvService.updatePorcentajes(response);
              const modalSuccessForm = this.modalService.open(ModalSuccessFormComponent, {
                size: 'sm', backdrop: 'static', animation: true
              });
              modalSuccessForm.componentInstance.body = 'Educación formal actualizada con éxito!';
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

  setDisableBtnAdd() {
    if (this.tieneEducacionFormal == false || this.tieneEducacionFormal == null) {
      this.disableBtnAdd = true;
    } else {
      this.disableBtnAdd = false;
    }
  }

  setDisableToggle() {
    if (this.listFormalEducation.length > 0) {
      this.tieneForm.controls['tiene'].disable();
    } else {
      this.tieneForm.controls['tiene'].enable();
    }
    // Setea los checked de los botones
    switch (this.tieneEducacionFormal) {      
      case true:
        this.checkedTieneEducacionFormalSi = true;
        this.checkedTieneEducacionFormalNo = false;
        this.tieneForm.controls['tiene'].setValue('true');
        break;
      case false:
        this.checkedTieneEducacionFormalSi = false;
        this.checkedTieneEducacionFormalNo = true;
        this.tieneForm.controls['tiene'].setValue('false');
        break;
      default:
        this.checkedTieneEducacionFormalSi = false;
        this.checkedTieneEducacionFormalNo = false;
        // this.tieneForm.controls['tiene'].setValue('false');
        break;
    }
  }

  /**
   * Función que se encarga de consultar si hay items de educación formal para el ciudadano
   */
  getListFormalEducation() {
    this.showLoading = true;
    // Sólo consulta el listado y está marcada la opción de "Si tiene educación formal"
    if (this.tieneEducacionFormal) {
      this.cvService.getListEducacionFormal(this.ciudadano?.id).subscribe(
        response => {
          setTimeout(() => {
            this.listFormalEducation = response;
            this.setDisableToggle();
            this.showLoading = false;
          }, 1000);
        },
        error => {
          console.log(error);
          this.showLoading = false;
          // Valida si el mensaje de error es por que no tiene informacion -- No existe Informacion.
          if (error.error.error == 'No existe Informacion.') {
            this.listFormalEducation = [];
            // Setea el tiene en false
            this.cvService.putTieneEducacionFormal(this.ciudadano?.id, false).subscribe(
              response => {
                this.cvService.toggleBooleanDataCiudadano('tieneEducacionFormal', response.tieneEducacionFormal);
                this.tieneEducacionFormal = response.tieneEducacionFormal;
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
   * Función que se encarga de enviar la educación formal para eliminar al servicio
   */
  deleteFormalEducation(educacion: EducacionFormal) {
    if (educacion) {
      const nivelEducativo = this.getNameNivelEducacion(educacion.nivelEducativoId);
      const tituloHomologado = this.getNameTituloHomologado(educacion.tituloHomologadoId);

      // Lanza modal de confirmación para la eliminación
      const modalConfirm = this.modalService.open(ModalConfirmationFormComponent, {
        size: 'md', backdrop: 'static', animation: true
      });
      modalConfirm.componentInstance.body = `Seguro que desea eliminar el registro de educación formal ${nivelEducativo} - ${tituloHomologado}`;
      modalConfirm.result.then(response => {
        if (response) {
          this.showLoading = true;
          this.cvService.deleteFormalEducation(educacion.id).subscribe(
            response => {
              this.getListFormalEducation();
            },
            error => {
              this.showLoading = false;
              console.log(error);
            }
          );
        }
      });
      this.setDisableToggle();
    }
  }

  /**
   * Función que carga los listados de los paramétricos para poder mostrar los valores en los CARD
   */
  getParametricos() {
    this.cvService.$nivelEducativo.subscribe(response => this.listNivelEducativo = response);
    this.cvService.$nucleoConocimiento.subscribe(response => this.listNucleoConocimiento = response);
    this.cvService.$areaConocimiento.subscribe(response => this.listAreaConocimiento = response);
    this.cvService.$estadoEducacion.subscribe(response => this.listEstadoEducacion = response);
    this.cvService.$tituloHomologado.subscribe(response => this.listTituloHomologado = response);
    this.cvService.$institucion.subscribe(response => this.listInstitucion = response);
  }

  getNameNivelEducacion(nivel: number): string {
    if (this.listNivelEducativo.findIndex(element => +element.id == nivel) !== -1) {
      return this.listNivelEducativo[this.listNivelEducativo.findIndex(element => +element.id == nivel)].nombre;
    }
    return '';
  }
  getNameEstadoEducacion(estado: number): string {
    if (this.listEstadoEducacion.findIndex(element => +element.id == estado) !== -1) {
      return this.listEstadoEducacion[this.listEstadoEducacion.findIndex(element => +element.id == estado)].nombre;
    }
    return '';
  }
  getNameTituloHomologado(titulo: number): string {
    if (this.listTituloHomologado.findIndex(element => +element.id == titulo) !== -1) {
      return this.listTituloHomologado[this.listTituloHomologado.findIndex(element => +element.id == titulo)].nombre;
    }
    return '';
  }
  getNameInstitucion(data: EducacionFormal): string {
    let institucion = '';
    // Valida si existe institucion como texto
    if (data.institucion !== '' && data.institucion !== null && data.institucion !== undefined) {
      institucion = data.institucion;
    } else if (data.institucionId !== null && data.institucionId !== undefined) {
      // En el caso que no esté lleno entonces intenta con institucionId del select
      if (this.listInstitucion.findIndex(element => +element.id == data.institucionId) !== -1) {
        institucion = this.listInstitucion[this.listInstitucion.findIndex(element => +element.id == data.institucionId)].nombre;
      }
    }
    return institucion;
  }

}
