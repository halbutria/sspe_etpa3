import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { NgbDatepickerI18n, NgbDateStruct, NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { PARAMETRICOS, ParametricosService, PARAMETRICOS_FILTROS } from "../../../../services/parametricos.service";
import { CvService } from "../../../../services/cv.service";
import { CustomDatepickerI18nService, I18n } from "src/app/services/custom-datepicker-i18n.service";

import { CiudadanoService } from "src/app/services/ciudadano.service";

import { ParametricoListado, Parametrico } from "../../../../model/parametricos";
import { Ciudadano, CiudadanoGet, EducacionFormal, ExperienciaPrevia } from "../../../../model/ciudadano";

import { ModalValidationFormComponent } from "src/app/shared/components/modal-validation-form/modal-validation-form.component";
import { ModalConfirmationFormComponent } from "src/app/shared/components/modal-confirmation-form/modal-confirmation-form.component";
import { ModalSuccessFormComponent } from "src/app/shared/components/modal-success-form/modal-success-form.component";
import { FormModalPreviousExperienceComponent } from "./form-modal-previous-experience/form-modal-previous-experience.component";
import { InformacionEquivalenciasComponent } from "./informacion-equivalencias/informacion-equivalencias.component";

@Component({
  selector: 'app-previous-experience',
  templateUrl: './previous-experience.component.html',
  styleUrls: ['./previous-experience.component.css']
})
export class PreviousExperienceComponent implements OnInit {

  ciudadano!: CiudadanoGet | null;
  PARAMETRICOS = PARAMETRICOS;
  tieneForm!: FormGroup;

  submitted: boolean = false;
  showLoading: boolean = false;
  disableBtnAdd: boolean = false;
  tieneExperienciaPrevia: boolean | any = true;
  checkedTieneExperienciaPreviaSi: boolean = false;
  checkedTieneExperienciaPreviaNo: boolean = false;
  listPreviousExperience: ExperienciaPrevia[] = [];
  listTitulosEdFormal: EducacionFormal[] = [];
  msgError: string = '';

  listNivelEducativo: Parametrico[] = [];

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
      // Valida si el ciudadano tiene marcada la opción de SI TIENE EXPERIENCIA PREVIA
      this.tieneExperienciaPrevia = this.ciudadano.tieneExperienciaLaboral;
      this.getParametricos();
      this.getTitulosEducacionFormal();

      // Si tiene marcada la opcion de SI TIENE EXPERIENCIA PREVIA entonces consulta el listado
      setTimeout(() => {
        console.log('Tiene Exp Previa en el NgOnInit', this.tieneExperienciaPrevia);
        this.getListPreviousExperience();
      }, 500);
    }
  }

  getTitulosEducacionFormal() {
    this.msgError = '';
    this.cvService.getListEducacionFormal(this.ciudadano?.id, true).subscribe(
      listado => {
        this.listTitulosEdFormal = listado;
        this.setDisableBtnAdd();
        this.setDisableToggle();
      },
      error => {
        console.log(error);
        this.msgError = 'No puedes registrar experencias previas, debido a que no tienes registrada educación formal en estado graduado!';
        this.setDisableBtnAdd();
        this.setDisableToggle();
      }
    );
  }

  /**
   * Función que abre e inicia el modal con el formulario para poder agregar o editar una experiencia previa
   */
  openModalForm(tipo: string, educacion: ExperienciaPrevia | null = null) {
    const modalForm = this.modalService.open(FormModalPreviousExperienceComponent, {
      size: 'lg', backdrop: 'static', animation: true
    });
    modalForm.componentInstance.type = tipo;
    modalForm.componentInstance.ciudadanoId = this.ciudadano?.id;
    modalForm.componentInstance.list = this.listPreviousExperience;
    // Si el tipo es edit entonces envía la data
    if (tipo === 'edit') {
      modalForm.componentInstance.data = educacion;
    }
    modalForm.result.then(response => {
      if (response != null) {
        this.getListPreviousExperience();
        const modalSuccessForm = this.modalService.open(ModalSuccessFormComponent, {
          size: 'sm', backdrop: 'static', animation: true
        });
        modalSuccessForm.componentInstance.body = 'Se guardó con éxito el registro de experiencia previa!';
      } else if (response === null && this.listPreviousExperience.length === 0) {
        // Si devuleve null y no hay nada en el listado pone el toggle a como está en el ciudadano
        this.tieneExperienciaPrevia = this.ciudadano?.tieneInformacionLaboral;
        this.setDisableToggle();
      }
    });
  }

  /**
   * Función que recibe la selección del campo check modifica el boton de agregar
   */
  cambiaTieneExperienciaPrevia(e: any) {
    this.tieneExperienciaPrevia = e.target.value == 'true' ? true : false;
    this.setDisableBtnAdd();
    if (this.tieneExperienciaPrevia) {
      this.openModalForm('new');
    } else {
      this.showLoading = true;
      // Envía a guardar el NO sobre el TIENE
      this.cvService.putTieneExperienciaPrevia(this.ciudadano?.id, false).subscribe(
        response => {
          this.cvService.toggleBooleanDataCiudadano('tieneExperienciaLaboral', false);
          // Consulta los porcentajes para actualizarlos
          this.cvService.getPorcentajesAvance(this.ciudadano?.id).subscribe(
            response => {
              this.cvService.updatePorcentajes(response);
              const modalSuccessForm = this.modalService.open(ModalSuccessFormComponent, {
                size: 'sm', backdrop: 'static', animation: true
              });
              modalSuccessForm.componentInstance.body = 'Experiencia previa actualizada con éxito!';
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
    // Valida si el mensaje de error contiene algo
    if (this.msgError !== '') {
      this.disableBtnAdd = true;
    } else {
      // Si no hay mensaje de error entonces continua validando el TIENE
      if (this.tieneExperienciaPrevia == false || this.tieneExperienciaPrevia == null) {
        this.disableBtnAdd = true;
      } else {
        this.disableBtnAdd = false;
      }
    }
  }

  setDisableToggle() {
    // Valida si el mensaje de error contiene algo
    if (this.msgError !== '') {
      this.tieneForm.controls['tiene'].disable();
    } else {
      // Si no hay mensaje de error entonces continua haciendo las validaciones con el listado de experiencias previas
      if (this.listPreviousExperience.length > 0) {
        this.tieneForm.controls['tiene'].disable();
      } else {
        this.tieneForm.controls['tiene'].enable();
      }
      // Setea los checked de los botones
      switch (this.tieneExperienciaPrevia) {
        case true:
          this.checkedTieneExperienciaPreviaSi = true;
          this.checkedTieneExperienciaPreviaNo = false;
          this.tieneForm.controls['tiene'].setValue('true');
          break;
        case false:
          this.checkedTieneExperienciaPreviaSi = false;
          this.checkedTieneExperienciaPreviaNo = true;
          this.tieneForm.controls['tiene'].setValue('false');
          break;
        default:
          this.checkedTieneExperienciaPreviaSi = false;
          this.checkedTieneExperienciaPreviaNo = false;
          // this.tieneForm.controls['tiene'].setValue('false');
          break;
      }
    }
  }

  /**
   * Función que se encarga de consultar si hay items de educación formal para el ciudadano
   */
  getListPreviousExperience() {
    console.log('Tiene Exp Previa', this.tieneExperienciaPrevia);
    this.showLoading = true;
    // Sólo consulta el listado y está marcada la opción de "Si tiene educación formal"
    if (this.tieneExperienciaPrevia) {
      this.cvService.getListPreviousExperience(this.ciudadano?.id).subscribe(
        response => {
          setTimeout(() => {
            this.listPreviousExperience = response;
            this.setDisableToggle();
            this.showLoading = false;
          }, 1000);
        },
        error => {
          console.log(error);
          this.showLoading = false;
          // Valida si el mensaje de error es por que no tiene informacion -- No existe Informacion.
          if (error.error.error == 'No existe Informacion.') {
            this.listPreviousExperience = [];
            // Setea el tiene en false
            this.cvService.putTieneExperienciaPrevia(this.ciudadano?.id, false).subscribe(
              response => {
                this.cvService.toggleBooleanDataCiudadano('tieneExperienciaPrevia', response.tieneExperienciaLaboral);
                this.tieneExperienciaPrevia = response.tieneExperienciaLaboral;
                this.setDisableBtnAdd();
                this.setDisableToggle();
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
   * Función que se encarga de enviar la experiencia previa para eliminar al servicio
   */
  deletePreviousExperience(experiencia: ExperienciaPrevia) {
    if (experiencia) {
      // Lanza modal de confirmación para la eliminación
      const modalConfirm = this.modalService.open(ModalConfirmationFormComponent, {
        size: 'md', backdrop: 'static', animation: true
      });
      modalConfirm.componentInstance.body = `Seguro que desea eliminar el registro de experiencia previa?`;
      modalConfirm.result.then(response => {
        if (response) {
          this.showLoading = true;
          this.cvService.deletePreviousExperience(experiencia.id).subscribe(
            response => {
              this.getListPreviousExperience();
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
  }

  openInfoEquivalencias() {
    this.modalService.open(InformacionEquivalenciasComponent, {
      size: 'md', backdrop: 'static', animation: true
    });
  }

  getNombreEduFormal(id: number) {
    if (this.listTitulosEdFormal.findIndex(element => element.id == id.toString()) !== -1) {
      return this.listTitulosEdFormal[this.listTitulosEdFormal.findIndex(element => element.id == id.toString())].tituloObtenido;
    }
    return '';
  }

}
