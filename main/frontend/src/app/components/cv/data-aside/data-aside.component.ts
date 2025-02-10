import { Component, Input, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { CvService } from "../../../services/cv.service";
import { CiudadanoGet, RedSocial } from "../../../model/ciudadano";
import { Parametrico } from 'src/app/model/parametricos';

import { ModalConfirmationFormComponent } from "src/app/shared/components/modal-confirmation-form/modal-confirmation-form.component";
import { ModalSuccessFormComponent } from "src/app/shared/components/modal-success-form/modal-success-form.component";
import { SocialMediaCvComponent } from "./social-media-cv/social-media-cv.component";

@Component({
  selector: 'app-data-aside',
  templateUrl: './data-aside.component.html',
  styleUrls: ['./data-aside.component.css'],
})
export class DataAsideComponent implements OnInit {

  ciudadano: CiudadanoGet | any = null;
  currentRate = 0;
  listRedesSociales: RedSocial[] = [];
  listRedSocialParametrico: Parametrico[] = [];

  constructor(
    public cvService: CvService,
    private modalService: NgbModal,
  ) { }

  ngOnInit(): void {
    // Consulta la información del storage en el servicio
    this.ciudadano = this.cvService.getCiudadano;
    this.setRatingStars();

    this.getSocialMedia();

    this.cvService.updateCiudadano.subscribe(
      ciudadanoActual => {
        this.ciudadano = ciudadanoActual;
        this.setRatingStars();
      }
    );
  }

  get showName(): string {
    if (this.ciudadano !== null) {
      const pNombre = this.ciudadano?.primerNombre;
      const sNombre = (this.ciudadano?.segundoNombre == '' || this.ciudadano?.segundoNombre == null) ? '' : ' ' + this.ciudadano?.segundoNombre;
      const pApellido = this.ciudadano?.primerApellido == '' ? '' : ' ' + this.ciudadano?.primerApellido;
      const sApellido = (this.ciudadano?.segundoApellido == '' || this.ciudadano?.segundoApellido == null) ? '' : ' ' + this.ciudadano?.segundoApellido;

      return pNombre + sNombre + pApellido + sApellido;
    } else {
      return "";
    }
  }

  /**
   * Función que recibe el click de algunos botones para el cambio de pestaña en la hoja de vida
   */
  changeTabCv(e: any, tab: number) {
    this.cvService.changeTabActive(tab);
  }

  /**
   * función que se encarga de setear el ranking de estrellas con relación a la info de la hoja de vida del ciudadano
   */
  setRatingStars() {
    /**
     * porcentajeHv: 65
     * porcentajeRegistro: > 0 => 100%
     * porcentajeInfoPersonal: > 0 => 100%
     * porcentajeEduFormal: > 0 => 100%
     * porcentajeInfoLaboral: > 0 => 100%
     * porcentajeEduNoFormal: > 0 => 100%
     */
    const porcentajeHv = (this.ciudadano.porcentajeHv * 5) / 100;
    this.currentRate = porcentajeHv;
    // console.log('Porcentaje rating estrellas', this.currentRate);
  }

  getSocialMedia() {
    this.cvService.$redSocial.subscribe(response => {
      this.listRedSocialParametrico = response;
      this.cvService.getListRedSocial(this.ciudadano.id).subscribe(
        redes => {
          this.listRedesSociales = redes;
        },erros=>{
          this.listRedesSociales =[]
        }
      );
    });
  }

  /**
   * Función que abre e inicia el modal con el formulario para poder agregar una red social
   */
  openModalForm(tipo: string, info: RedSocial | null = null) {
    const modalForm = this.modalService.open(SocialMediaCvComponent, {
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
        this.getSocialMedia();
        // const modalSuccessForm = this.modalService.open(ModalSuccessFormComponent, {
        //   size: 'sm', backdrop: 'static', animation: true
        // });
        // modalSuccessForm.componentInstance.body = 'Se guardó con éxito el registro de educación no formal!';
      }
    });
  }

  /**
   * Función que se encarga de enviar la red social para eliminar al servicio
   */
  deleteSocialMedia(info: RedSocial) {
    if (info) {
      let nombreRed = '';
      if (this.listRedSocialParametrico.length > 0) {
        nombreRed = this.getNombreRedSocial(info) as string;
      }

      // Lanza modal de confirmación para la eliminación
      const modalConfirm = this.modalService.open(ModalConfirmationFormComponent, {
        size: 'md', backdrop: 'static', animation: true
      });
      modalConfirm.componentInstance.body = `Seguro que desea eliminar el registro de red social ${nombreRed}?`;
      modalConfirm.result.then(response => {
        if (response) {
          this.cvService.deleteRedSocial(info.id).subscribe(
            response => {
              this.getSocialMedia();
            },
            error => {
              console.log(error);
            }
          );
        }
      });
    }
  }

  getNombreRedSocial(red: RedSocial): string | undefined {
    let nombre = '';
    if (red) {
      // Para devolver el nombre correcto debe validar si hay uno seleccionado o si agregaron otro
      if (red.redSocialId == 5) {
        // En caso de agregar OTRO, entonces muestra el del campo de texto abierto
        nombre = red.nombreRedSocial;
      } else if (this.listRedSocialParametrico.findIndex(r => +r.id == red.redSocialId) !== -1) {
        nombre = this.listRedSocialParametrico[this.listRedSocialParametrico.findIndex(r => +r.id == red.redSocialId)].nombre;
      }
    }
    return nombre + ' (' + red.nombreUsuarioRedSocial + ')';
  }
}
