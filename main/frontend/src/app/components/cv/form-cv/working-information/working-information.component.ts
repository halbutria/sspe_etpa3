import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { PARAMETRICOS, ParametricosService, PARAMETRICOS_FILTROS } from "../../../../services/parametricos.service";
import { CvService } from "../../../../services/cv.service";
import { CiudadanoService } from "src/app/services/ciudadano.service";

import { CiudadanoGet, InformacionLaboral } from 'src/app/model/ciudadano';
import { ParametricoListado, Parametrico } from "../../../../model/parametricos";

import { ModalConfirmationFormComponent } from "src/app/shared/components/modal-confirmation-form/modal-confirmation-form.component";
import { ModalSuccessFormComponent } from "src/app/shared/components/modal-success-form/modal-success-form.component";
import { ModalFormWorkingInformationComponent } from "./modal-form-working-information/modal-form-working-information.component";

@Component({
  selector: 'app-working-information',
  templateUrl: './working-information.component.html',
  styleUrls: ['./working-information.component.css']
})
export class WorkingInformationComponent implements OnInit {

  ciudadano!: CiudadanoGet | null;
  PARAMETRICOS = PARAMETRICOS;
  tieneForm!: FormGroup;

  showLoading: boolean = false;
  disableBtnAdd: boolean = false;
  tieneInformacionLaboral: boolean | any = true;
  checkedTieneInformacionLaboralSi: boolean = false;
  checkedTieneInformacionLaboralNo: boolean = false;
  listWorkingInformation: InformacionLaboral[] = [];

  listTipoExperiencia: Parametrico[] = [];
  listSector: Parametrico[] = [];

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
      // Valida si el ciudadano tiene marcada la opción de SI TIENE INFORMACION LABORAL
      this.tieneInformacionLaboral = this.ciudadano.tieneInformacionLaboral;
      this.getParametricos();
      this.setDisableBtnAdd();
      this.setDisableToggle();

      // Si tiene marcada la opcion de SI TIENE INFORMACION LABORAL entonces consulta el listado
      setTimeout(() => {
        this.getListWorkingInformation();
      }, 500);
    }
  }

  /**
   * Función que carga los listados de los paramétricos para poder mostrar los valores en los CARD
   */
  getParametricos() {
    this.cvService.$tipoExperiencia.subscribe(response => this.listTipoExperiencia = response);
    this.cvService.$sector.subscribe(response => this.listSector = response);
  }

  setDisableBtnAdd() {
    if (this.tieneInformacionLaboral == false || this.tieneInformacionLaboral == null) {
      this.disableBtnAdd = true;
    } else {
      this.disableBtnAdd = false;
    }
  }

  setDisableToggle() {
    if (this.listWorkingInformation.length > 0) {
      this.tieneForm.controls['tiene'].disable();
    } else {
      this.tieneForm.controls['tiene'].enable();
    }
    // Setea los checked de los botones
    switch (this.tieneInformacionLaboral) {
      case true:
        this.checkedTieneInformacionLaboralSi = true;
        this.checkedTieneInformacionLaboralNo = false;
        this.tieneForm.controls['tiene'].setValue('true');
        break;
      case false:
        this.checkedTieneInformacionLaboralSi = false;
        this.checkedTieneInformacionLaboralNo = true;
        this.tieneForm.controls['tiene'].setValue('false');
        break;
      default:
        this.checkedTieneInformacionLaboralSi = false;
        this.checkedTieneInformacionLaboralNo = false;
        // this.tieneForm.controls['tiene'].setValue('false');
        break;
    }
  }

  /**
   * Función que recibe la selección del campo check y envía a guardar al backend
   * para marcar si tiene o no informacion laboral
   */
  cambiaTieneInformacionLaboral(e: any) {
    this.tieneInformacionLaboral = e.target.value == 'true' ? true : false;
    this.setDisableBtnAdd();
    if (this.tieneInformacionLaboral) {
      this.openModalForm('new');
    } else {
      this.showLoading = true;
      // Envía a guardar el NO sobre el TIENE
      this.cvService.putTieneExperienciaLaboral(this.ciudadano?.id, false).subscribe(
        response => {
          this.cvService.toggleBooleanDataCiudadano('tieneInformacionLaboral', false);
          // Consulta los porcentajes para actualizarlos
          this.cvService.getPorcentajesAvance(this.ciudadano?.id).subscribe(
            response => {
              this.cvService.updatePorcentajes(response);
              const modalSuccessForm = this.modalService.open(ModalSuccessFormComponent, {
                size: 'sm', backdrop: 'static', animation: true
              });
              modalSuccessForm.componentInstance.body = 'Información laboral actualizada con éxito!';
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
   * Función que se encarga de consultar si hay items de informacion laboral para el ciudadano
   */
  getListWorkingInformation() {
    this.showLoading = true;
    // Sólo consulta el listado y está marcada la opción de "Si tiene informacion laboral"
    if (this.tieneInformacionLaboral) {
      this.cvService.getListInformacionLaboral(this.ciudadano?.id).subscribe(
        response => {
          this.listWorkingInformation = response;
          this.setDisableToggle();
          this.showLoading = false;
        },
        error => {
          console.log(error);
          this.showLoading = false;
          // Valida si el mensaje de error es por que no tiene informacion -- No existe Informacion.
          if (error.error.error == 'No existe Informacion.') {
            this.listWorkingInformation = [];
            // Setea el tiene en false
            this.cvService.putTieneExperienciaLaboral(this.ciudadano?.id, false).subscribe(
              response => {
                this.cvService.toggleBooleanDataCiudadano('tieneInformacionLaboral', response.tieneInformacionLaboral);
                this.tieneInformacionLaboral = response.tieneInformacionLaboral;
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
   * Función que se encarga de enviar la información laboral para eliminar al servicio
   */
  deleteWorkingInformation(info: InformacionLaboral) {
    if (info) {
      const tipoExp = this.getNameTipoExperiencia(info.tipoExperienciaId);
      const nombreEmp = info.nombreEmpresa;

      // Lanza modal de confirmación para la eliminación
      const modalConfirm = this.modalService.open(ModalConfirmationFormComponent, {
        size: 'md', backdrop: 'static', animation: true
      });
      modalConfirm.componentInstance.body = `Seguro que desea eliminar el registro de información laboral ${tipoExp} - ${nombreEmp}`;
      modalConfirm.result.then(response => {
        if (response) {
          this.showLoading = true;
          this.cvService.deleteWorkingInformation(info.id).subscribe(
            response => {
              this.getListWorkingInformation();
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
   * Función que abre e inicia el modal con el formulario para poder agregar o editar una información laboral
   */
  openModalForm(tipo: string, info: InformacionLaboral | null = null) {
    const modalForm = this.modalService.open(ModalFormWorkingInformationComponent, {
      size: 'lg', backdrop: 'static', animation: true
    });
    modalForm.componentInstance.type = tipo;
    modalForm.componentInstance.ciudadanoId = this.ciudadano?.id;
    modalForm.componentInstance.list = this.listWorkingInformation;
    // Si el tipo es edit entonces envía la data
    if (tipo === 'edit') {
      modalForm.componentInstance.data = info;
    }
    modalForm.result.then(response => {
      if (response != null) {
        this.getListWorkingInformation();
        const modalSuccessForm = this.modalService.open(ModalSuccessFormComponent, {
          size: 'sm', backdrop: 'static', animation: true
        });
        modalSuccessForm.componentInstance.body = 'Se guardó con éxito el registro de información laboral!';
        // Consulta los porcentajes para actualizarlos
        this.cvService.getPorcentajesAvance(this.ciudadano?.id).subscribe(
          response => { this.cvService.updatePorcentajes(response); }
        );
      } else if (response === null && this.listWorkingInformation.length === 0) {
        // Si devuleve null y no hay nada en el listado pone el toggle a como está en el ciudadano
        this.tieneInformacionLaboral = this.ciudadano?.tieneInformacionLaboral;
        this.setDisableToggle();
      }
    });
  }

  getNameTipoExperiencia(exp: number): string {
    if (this.listTipoExperiencia.findIndex(element => +element.id == exp) !== -1) {
      return this.listTipoExperiencia[this.listTipoExperiencia.findIndex(element => +element.id == exp)].nombre;
    }
    return '';
  }
  getNameSector(sector: number): string {
    if (this.listSector.findIndex(element => +element.id == sector) !== -1) {
      return this.listSector[this.listSector.findIndex(element => +element.id == sector)].nombre;
    }
    return '';
  }

}
