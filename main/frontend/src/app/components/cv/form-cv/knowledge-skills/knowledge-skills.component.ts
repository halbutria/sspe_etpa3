import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { ParametricosService, PARAMETRICOS } from "src/app/services/parametricos.service"
import { CvService } from "src/app/services/cv.service"
import { CiudadanoService } from "src/app/services/ciudadano.service";

import { CiudadanoGet, ConocimientoModel, DestrezaModel } from "src/app/model/ciudadano";
import { ParametricoListado, Parametrico } from "src/app/model/parametricos";

import { ModalConfirmationFormComponent } from "src/app/shared/components/modal-confirmation-form/modal-confirmation-form.component";
import { ModalSuccessFormComponent } from "src/app/shared/components/modal-success-form/modal-success-form.component";
import { ModalErrorFormComponent } from "src/app/shared/components/modal-error-form/modal-error-form.component";

@Component({
  selector: 'app-knowledge-skills',
  templateUrl: './knowledge-skills.component.html',
  styleUrls: ['./knowledge-skills.component.css']
})
export class KnowledgeSkillsComponent implements OnInit {

  ciudadano!: CiudadanoGet | any;
  conocimientosForm!: FormGroup;
  habilidadesForm!: FormGroup;
  conocimientosAdForm!: FormGroup;
  habilidadesAdForm!: FormGroup;
  showLoading: boolean = true;
  disableBtnConocimientos: boolean = true;
  PARAMETRICOS = PARAMETRICOS;

  listConocimientosBase: Parametrico[] = [];
  listHabilidadesBase: Parametrico[] = [];
  listConocimientos: ConocimientoModel[] = [];
  listHabilidades: DestrezaModel[] = [];
  listConocimientosAdicionales: ConocimientoModel[] = [];
  listHabilidadesAdicionales: DestrezaModel[] = [];

  constructor(
    public formBuilder: FormBuilder,
    public parametricosService: ParametricosService,
    public cvService: CvService,
    public ciudadanoService: CiudadanoService,
    private modalService: NgbModal,
  ) {
    this.conocimientosForm = this.formBuilder.group({
      ciudadanoId: [null],
      conocimientoId: [null, Validators.required],
    });
    this.habilidadesForm = this.formBuilder.group({
      ciudadanoId: [null],
      habilidadId: [null, Validators.required],
    });
    this.conocimientosAdForm = this.formBuilder.group({
      ciudadanoId: [null],
      conocimientoId: [null],
      nombre: [null, Validators.required],
    });
    this.habilidadesAdForm = this.formBuilder.group({
      ciudadanoId: [null],
      habilidadId: [null],
      nombre: [null, Validators.required],
    });
  }

  ngOnInit(): void {
    // Consulta la información del storage en el servicio
    this.ciudadano = this.cvService.getCiudadano;
    this.getParametricos();
  }

  // Getter para fácil acceso a los controles de formulario
  get fC() {
    return this.conocimientosForm.controls;
  }

  getParametricos() {
    this.cvService.$cuocConocimientosBase.subscribe(response => { this.listConocimientosBase = response; });
    this.cvService.$cuocDestrezasBase.subscribe(response => { this.listHabilidadesBase = response; });
    this.getListados();
  }

  getListados() {
    this.showLoading = true;
    this.cvService.getConocimientos(this.ciudadano.id).subscribe(
      response => {
        this.listConocimientos = response.filter(element => element.conocimientoId !== null);
        this.listConocimientosAdicionales = response.filter(element => element.conocimientoId === null);
        this.showLoading = false;
      },
      error => {
        console.log(error);
        this.showLoading = false;
      }
    );
    this.showLoading = true;
    this.cvService.getDestrezas(this.ciudadano.id).subscribe(
      response => {
        this.listHabilidades = response.filter(element => element.habilidadId !== null);
        this.listHabilidadesAdicionales = response.filter(element => element.habilidadId === null);
        this.showLoading = false;
      },
      error => {
        console.log(error);
        this.showLoading = false;
      }
    );
  }

  addConocimientos() {
    if (this.conocimientosForm.valid) {
      this.showLoading = true;
      const formSend: ConocimientoModel = this.conocimientosForm.value;
      formSend.ciudadanoId = this.ciudadano.id;

      this.cvService.addConocimientos(formSend).subscribe(
        response => {
          this.listConocimientos.push(response);
          this.showLoading = false;
          this.conocimientosForm.reset();
        },
        error => {
          console.log(error);
          this.showLoading = false;
          this.conocimientosForm.reset();
          const modalErrorForm = this.modalService.open(ModalErrorFormComponent, {
            size: 'sm', backdrop: 'static', animation: true
          });
          modalErrorForm.componentInstance.body = error.error.error;
        }
      );
    }
  }
  /**
   * Función que se encarga de enviar el conocimiento para eliminar al servicio
   */
  deleteConocimiento(conocimiento: ConocimientoModel) {
    if (conocimiento) {
      const conocimientoNombre = this.getNameConocimiento(conocimiento.conocimientoId);

      // Lanza modal de confirmación para la eliminación
      const modalConfirm = this.modalService.open(ModalConfirmationFormComponent, {
        size: 'md', backdrop: 'static', animation: true
      });
      modalConfirm.componentInstance.body = `Seguro que desea eliminar el registro de conocimiento o competencia ${conocimientoNombre}?`;
      modalConfirm.result.then(response => {
        if (response) {
          this.showLoading = true;
          this.cvService.deleteConocimientos(conocimiento.id).subscribe(
            response => {
              const index = this.listConocimientos.findIndex(cono => cono.id == conocimiento.id);
              this.listConocimientos.splice(index, 1);
              this.showLoading = false;
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
  getNameConocimiento(conocimientoId: string) {
    if (this.listConocimientosBase.findIndex(element => element.id == conocimientoId) !== -1) {
      return this.listConocimientosBase[this.listConocimientosBase.findIndex(element => element.id == conocimientoId)].nombre;
    }
    return '';
  }
  getInformacionConocimiento(conocimientoId: string) {
    if (this.listConocimientosBase.findIndex(element => element.id == conocimientoId) !== -1) {
      return this.listConocimientosBase[this.listConocimientosBase.findIndex(element => element.id == conocimientoId)].detalle;
    }
    return '';
  }

  addDestrezas() {
    if (this.habilidadesForm.valid) {
      this.showLoading = true;
      const formSend: DestrezaModel = this.habilidadesForm.value;
      formSend.ciudadanoId = this.ciudadano.id;

      this.cvService.addDestrezas(formSend).subscribe(
        response => {
          this.listHabilidades.push(response);
          this.showLoading = false;
          this.habilidadesForm.reset();
        },
        error => {
          console.log(error);
          this.showLoading = false;
          this.habilidadesForm.reset();
          const modalErrorForm = this.modalService.open(ModalErrorFormComponent, {
            size: 'sm', backdrop: 'static', animation: true
          });
          modalErrorForm.componentInstance.body = error.error.error;
        }
      );
    }
  }
  /**
   * Función que se encarga de enviar el conocimiento para eliminar al servicio
   */
  deleteDestrezas(habilidad: DestrezaModel) {
    if (habilidad) {
      const habilidadNombre = this.getNameHabilidades(habilidad.habilidadId);

      // Lanza modal de confirmación para la eliminación
      const modalConfirm = this.modalService.open(ModalConfirmationFormComponent, {
        size: 'md', backdrop: 'static', animation: true
      });
      modalConfirm.componentInstance.body = `Seguro que desea eliminar el registro de destreza o habilidad ${habilidadNombre}?`;
      modalConfirm.result.then(response => {
        if (response) {
          this.showLoading = true;
          this.cvService.deleteDestrezas(habilidad.id).subscribe(
            response => {
              const index = this.listHabilidades.findIndex(habi => habi.id == habilidad.id);
              this.listHabilidades.splice(index, 1);
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
  getNameHabilidades(habilidadId: string) {
    if (this.listHabilidadesBase.findIndex(element => element.id == habilidadId) !== -1) {
      return this.listHabilidadesBase[this.listHabilidadesBase.findIndex(element => element.id == habilidadId)].nombre;
    }
    return '';
  }
  getInformacionHabilidades(habilidadId: string) {
    if (this.listHabilidadesBase.findIndex(element => element.id == habilidadId) !== -1) {
      return this.listHabilidadesBase[this.listHabilidadesBase.findIndex(element => element.id == habilidadId)].detalle;
    }
    return '';
  }

  /**
   * Funciones para la seccion de ADICIONALES
   */
  addConocimientosAd() {
    if (this.conocimientosAdForm.valid) {
      this.showLoading = true;
      const formSend: ConocimientoModel = this.conocimientosAdForm.value;
      formSend.ciudadanoId = this.ciudadano.id;

      this.cvService.addConocimientos(formSend).subscribe(
        response => {
          this.listConocimientosAdicionales.push(response);
          this.showLoading = false;
          this.conocimientosAdForm.reset();
        },
        error => {
          console.log(error);
          this.showLoading = false;
          this.conocimientosAdForm.reset();
          const modalErrorForm = this.modalService.open(ModalErrorFormComponent, {
            size: 'sm', backdrop: 'static', animation: true
          });
          modalErrorForm.componentInstance.body = error.error.error;
        }
      );
    }
  }
  deleteConocimientoAd(conocimiento: ConocimientoModel) {
    if (conocimiento) {
      // Lanza modal de confirmación para la eliminación
      const modalConfirm = this.modalService.open(ModalConfirmationFormComponent, {
        size: 'md', backdrop: 'static', animation: true
      });
      modalConfirm.componentInstance.body = `Seguro que desea eliminar el registro de conocimiento o competencia adicional ${conocimiento.nombre}?`;
      modalConfirm.result.then(response => {
        if (response) {
          this.showLoading = true;
          this.cvService.deleteConocimientos(conocimiento.id).subscribe(
            response => {
              const index = this.listConocimientosAdicionales.findIndex(cono => cono.id == conocimiento.id);
              this.listConocimientosAdicionales.splice(index, 1);
              this.showLoading = false;
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
  addDestrezasAd() {
    if (this.habilidadesAdForm.valid) {
      this.showLoading = true;
      const formSend: DestrezaModel = this.habilidadesAdForm.value;
      formSend.ciudadanoId = this.ciudadano.id;

      this.cvService.addDestrezas(formSend).subscribe(
        response => {
          this.listHabilidadesAdicionales.push(response);
          this.showLoading = false;
          this.habilidadesAdForm.reset();
        },
        error => {
          console.log(error);
          this.showLoading = false;
          this.habilidadesAdForm.reset();
          const modalErrorForm = this.modalService.open(ModalErrorFormComponent, {
            size: 'sm', backdrop: 'static', animation: true
          });
          modalErrorForm.componentInstance.body = error.error.error;
        }
      );
    }
  }
  deleteDestrezasAd(habilidad: DestrezaModel) {
    if (habilidad) {
      const habilidadNombre = this.getNameHabilidades(habilidad.habilidadId);

      // Lanza modal de confirmación para la eliminación
      const modalConfirm = this.modalService.open(ModalConfirmationFormComponent, {
        size: 'md', backdrop: 'static', animation: true
      });
      modalConfirm.componentInstance.body = `Seguro que desea eliminar el registro de destreza o habilidad adicional ${habilidadNombre}?`;
      modalConfirm.result.then(response => {
        if (response) {
          this.showLoading = true;
          this.cvService.deleteDestrezas(habilidad.id).subscribe(
            response => {
              const index = this.listHabilidadesAdicionales.findIndex(habi => habi.id == habilidad.id);
              this.listHabilidadesAdicionales.splice(index, 1);
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
