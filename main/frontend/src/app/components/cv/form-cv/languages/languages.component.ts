import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { PARAMETRICOS, ParametricosService, PARAMETRICOS_FILTROS } from "../../../../services/parametricos.service";
import { CvService } from "../../../../services/cv.service";
import { CiudadanoService } from "src/app/services/ciudadano.service";

import { CiudadanoGet, Idioma } from 'src/app/model/ciudadano';
import { ParametricoListado, Parametrico } from "../../../../model/parametricos";

import { ModalConfirmationFormComponent } from "src/app/shared/components/modal-confirmation-form/modal-confirmation-form.component";
import { ModalSuccessFormComponent } from "src/app/shared/components/modal-success-form/modal-success-form.component";
import { ModalFormLanguagesComponent } from "./modal-form-languages/modal-form-languages.component";

@Component({
  selector: 'app-languages',
  templateUrl: './languages.component.html',
  styleUrls: ['./languages.component.css']
})
export class LanguagesComponent implements OnInit {

  ciudadano!: CiudadanoGet | null;
  PARAMETRICOS = PARAMETRICOS;
  showLoading: boolean = false;
  listLanguages: Idioma[] = [];

  constructor(
    public parametricosService: ParametricosService,
    public cvService: CvService,
    public ciudadanoService: CiudadanoService,
    private modalService: NgbModal,
  ) { }

  ngOnInit(): void {
    // Consulta la información del storage en el servicio
    this.ciudadano = this.cvService.getCiudadano;
    if (this.ciudadano !== null) {
      this.getListIdiomas(true);
    }
  }

  /**
   * Función que se encarga de consultar si hay items de idioma para el ciudadano
   */
  getListIdiomas(init: boolean = false) {
    this.showLoading = true;
    this.cvService.getListIdioma(this.ciudadano?.id).subscribe(
      response => {
        setTimeout(() => {
          this.listLanguages = response;
          this.showLoading = false;
        }, 1000);
      },
      error => {
        console.log(error);
        this.showLoading = false;
      }
    );
  }

  /**
   * Función que abre e inicia el modal con el formulario para poder agregar o editar un idioma
   */
  openModalForm(tipo: string, info: Idioma | null = null) {
    const modalForm = this.modalService.open(ModalFormLanguagesComponent, {
      size: 'md', backdrop: 'static', animation: true
    });
    modalForm.componentInstance.type = tipo;
    modalForm.componentInstance.ciudadanoId = this.ciudadano?.id;
    // Si el tipo es edit entonces envía la data
    if (tipo === 'edit') {
      modalForm.componentInstance.data = info;
    }
    modalForm.result.then(response => {
      if (response != null) {
        this.getListIdiomas();
        const modalSuccessForm = this.modalService.open(ModalSuccessFormComponent, {
          size: 'sm', backdrop: 'static', animation: true
        });
        modalSuccessForm.componentInstance.body = 'Se guardó con éxito el idioma!';
      }
    });
  }

  /**
   * Función que se encarga de enviar el idioma para eliminar al servicio
   */
  deleteIdioma(info: Idioma) {
    if (info) {
      this.listLanguages = [];
      // Lanza modal de confirmación para la eliminación
      const modalConfirm = this.modalService.open(ModalConfirmationFormComponent, {
        size: 'md', backdrop: 'static', animation: true
      });
      modalConfirm.componentInstance.body = `Seguro que desea eliminar el registro de idioma?`;
      modalConfirm.result.then(response => {
        if (response) {
          this.showLoading = true;
          this.cvService.deleteIdioma(info.id).subscribe(
            response => {
              this.getListIdiomas();
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

}
