import { Component, ElementRef, Input, OnInit, ViewChild, Renderer2 } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { NgbActiveModal, NgbDateStruct, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';

import { InvisibleReCaptchaComponent, ReCaptcha2Component, ReCaptchaV3Service } from 'ngx-captcha';
import { environment } from '../../../../environments/environment';

import { ParametricosService } from "../../../services/parametricos.service";
import { CiudadanoService } from "../../../services/ciudadano.service";
import { RegisterService } from "../../../services/register.service";
import { ParametricoListado } from "../../../model/parametricos";
import { Ciudadano, CreateRequest } from "../../../model/ciudadano";
import { ModalResponseComponent } from "./modal-response/modal-response.component";
import { ModalValidationComponent } from "../modal-validation/modal-validation.component";

@Component({
  selector: 'app-modal-content',
  template: `
  <div class="modal-header">
      <h5 class="modal-title text-center">Registro de Buscador</h5>
  </div>
  <div class="modal-body">
    ¿ Seguro que desea registrar los datos en sistema?
  </div>
  <div class="modal-footer">
      <div class="left-side">
          <button type="button" class="btn btn-success" (click)="activeModal.close(true)">ACEPTAR</button>
      </div>
      <div class="divider"></div>
      <div class="right-side">
          <button type="button" class="btn btn-danger" (click)="activeModal.close(false)">CANCELAR</button>
      </div>
  </div>
  `
})
export class NgbdModalContent {
  @Input() name: any;

  constructor(public activeModal: NgbActiveModal) { }
}

@Component({
  selector: 'app-notifications',
  templateUrl: './notifications.component.html',
  styleUrls: ['./notifications.component.css']
})
export class NotificationsComponent implements OnInit {

  registerForm!: FormGroup;
  submitted: boolean = false;
  showLoading: boolean = false;
  showMsg: boolean = false;
  listMediosNotificacion: any[] = [];
  notificationsSelected: Array<number> = [];
  selectedAll: boolean = false;
  listNombreCampos: any = {};
  @ViewChild('checkAll') checkAll: ElementRef<HTMLInputElement> | undefined;

  siteKey: string = environment.recaptcha.siteKey;
  @ViewChild('captchaElem', { static: false }) captchaElem!: InvisibleReCaptchaComponent;

  constructor(
    public formBuilder: FormBuilder,
    public parametricosService: ParametricosService,
    public ciudadanoService: CiudadanoService,
    public registerService: RegisterService,
    private modalService: NgbModal,
    private router: Router,
    private reCaptchaV3Service: ReCaptchaV3Service,
  ) {
    this.registerForm = this.formBuilder.group({
      tipoDocumentoId: [null, Validators.required],
      numeroDocumento: [null, Validators.required],
      correoElectronico: [null, Validators.required],
      password: [null, [Validators.required]],
      confirmPassword: [null, [Validators.required]],
      primerNombre: [null, Validators.required],
      segundoNombre: [null],
      primerApellido: [null, Validators.required],
      segundoApellido: [null],
      fechaNacimiento: [null, Validators.required],
      sexoId: [null, Validators.required],
      telefono: [''],
      otroTelefono: [''],
      fechaExpedicionDocumento: [null],
      estado: [''],
      ciudad: [''],
      // Dirección
      direccionResidencia: [null, Validators.required],
      viaPrincipalId: [null],
      viaPrincipalNombre: [null],
      viaPrincipal: [null],
      viaPrincipalLetraId: [null],
      viaPrincipalLetraNombre: [null],
      viaPrincipalBisId: [null],
      viaPrincipalBisNombre: [null],
      viaPrincipalSegundaLetraId: [null],
      viaPrincipalSegundaLetraNombre: [null],
      viaPrincipalCuadranteId: [null],
      viaPrincipalCuadranteNombre: [null],
      signoNumero: [null],
      viaGeneradora: [null],
      viaGeneradoraLetraId: [null],
      viaGeneralLetraNombre: [null],
      viaGeneradoraPlaca: [null],
      viaGeneradoraCuadranteId: [null],
      viaGeneradoraCuadranteNombre: [null],
      codigoPostal: [null, [Validators.minLength(6), Validators.maxLength(6)]],

      direcciones: [null],

      paisResidenciaId: [null, Validators.required],
      departamentoResidenciaId: [null],
      municipioResidenciaId: [null],
      prestadorPreferenciaId: [null, Validators.required],
      puntoAtencionId: [null, Validators.required],
      perteneceARural: [null, Validators.required],
      preguntaSeguridadId: [null],      
      preguntaLibre: [null],
      localidadComunaId: [null],
      barrioResidencia: [null],
      preguntaSeguridadRespuesta: [null, Validators.required],
      terminosCondiciones: [null, Validators.required],
      tratamientoDatosPersonales: [null, Validators.required],
      tipoNotificacion: [null, Validators.required]
    });
  }

  ngOnInit(): void {
    window.scrollTo(0, 0); // Envia el scroll arriba pues llega de datos básicos que tiene arta información habia abajo
    // Convoca función para consultar los parametricos para el formulario
    this.getMediosNotificacion();

    // Valida si ya hay un proceso de registro creado
    const dataRegister = this.registerService.getRegisterData();
    if (dataRegister) {
      this.registerForm.patchValue(dataRegister);
    }
    this.listNombreCampos = this.registerService.getListNombresCamposForm();
  }

  /**
   * Función que invoca el servicio para consultar al API los medios de notificacion
   */
  getMediosNotificacion() {
    this.showLoading = true;
    this.parametricosService.getParametricosDefault('TipoNotificacion').subscribe((response) => {
      this.listMediosNotificacion = response.map(function (element) {
        return { id: element.id, nombre: element.nombre, checked: false }
      });
      setTimeout(() => { this.showLoading = false; }, 500);
    });
  }

  /**
   * Función del submit del formulario para realizar el llamado al servicio y enviar a guardar el ciudadano
   */
  saveAction() {
    this.submitted = true;
    // Valida si el formuario ya contiene los campos requeridos
    if (this.registerForm.valid) {
      // Valida el captcha
      this.reCaptchaV3Service.execute(this.siteKey, 'registro', (token) => {
        console.log('Token reCaptcha registro: ', token);
        this.registerForm.disable();
        let formDataSend: CreateRequest = this.registerForm.value;
        const fNacimiento = this.f['fechaNacimiento'].value;
        const fExpDoc = this.f['fechaExpedicionDocumento'].value;
        const telefono = this.f['telefono'].value;

        // Convierte a string el telefono
        formDataSend.telefono = telefono.toString();
        // Convierte a string la fecha de nacimiento
        formDataSend.fechaNacimiento = this.convertSringDate(fNacimiento);
        formDataSend.fechaExpedicionDocumento = this.convertSringDate(fExpDoc);
        // Envia true o false en los terminos y tratamiento
        // formDataSend.terminosCondiciones = this.f['terminosCondiciones'].value === '1' ? true : false;
        // formDataSend.tratamientoDatosPersonales = this.f['tratamientoDatosPersonales'].value === '1' ? true : false;
        // Asegura que el tipo doc, tipo notificacion, genero y pregunta id sean numeros
        formDataSend.tipoDocumentoId = +this.f['tipoDocumentoId'].value;
        formDataSend.sexoId = +this.f['sexoId'].value;
        formDataSend.preguntaSeguridadId = +this.f['preguntaSeguridadId'].value;

        // Muestra un modal de confirmación
        const modalRef = this.modalService.open(NgbdModalContent).result.then(
          (result) => {
            if (result) {
              this.showLoading = true;
              this.ciudadanoService.saveDataCiudadano(formDataSend).subscribe(
                (response) => {
                  console.log(response);
                  this.showLoading = false;
                  this.showMsg = true;

                  // Muestra modal para el guardado exitoso
                  const modalRef = this.modalService.open(ModalResponseComponent).result.then(
                    (resulModal) => {
                      if (resulModal == 'close') {
                        // Hace reset de la data en el servicio para luego redirigirle al login
                        this.registerService.resetData();
                        this.router.navigate(['/login']);
                      }
                    }
                  );
                },
                (error) => {
                  console.log(error);
                  this.showLoading = false;
                });
            } else {
              this.submitted = false;
              this.registerForm.enable();
            }
          },
          (reason) => {
            console.log(reason);
          },
        );
      }, {
        useGlobalDomain: false
      },
        (error) => console.log(error));
    } else {
      const modalRef = this.modalService.open(ModalValidationComponent);
      // Obtiene listado de campso con errores
      const listErrors = this.getListErrorsForm();
      let listErrorsSend: string[] = [];
      listErrors.forEach(itemError => {
        listErrorsSend.push(this.listNombreCampos[itemError]);
      });

      modalRef.componentInstance.listErrors = listErrorsSend;
    }
  }

  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.registerForm.controls;
  }

  public convertSringDate(date: any) {
    const month = date.month < 10 ? '0' + date.month : date.month;
    const day = date.day < 10 ? '0' + date.day : date.day;
    return date.year + '-' + month + '-' + day;
  }

  /**
   * Función que controla el change de los check de tipos de notificación
   * Si selecciona check todos entoces marca todos los del listado
   */
  onCheckboxChange(e: any) {
    if (e.target.checked) {
      // Valida si marcó "todos"
      if (e.target.value == 'todos') {
        this.selectedAll = true;
        // Vacía el arreglo
        this.notificationsSelected = [];
        // Recorre el listado para ir agregando al arreglo
        for (const medio in this.listMediosNotificacion) {
          if (Object.prototype.hasOwnProperty.call(this.listMediosNotificacion, medio)) {
            const element = this.listMediosNotificacion[medio];
            this.notificationsSelected.push(+element.id);
            this.listMediosNotificacion[medio]['checked'] = true;
          }
        }
      } else {
        const notificacionExistente = this.notificationsSelected.find(medio => medio === +e.target.value);
        // Si no marcó todos entonce es porque agrega normal al arreglo cada check, sólo si no existe antes en el arreglo
        if (!notificacionExistente) {
          this.notificationsSelected.push(+e.target.value);
          this.listMediosNotificacion[this.listMediosNotificacion.findIndex(medio => medio.id == e.target.value)]['checked'] = true;
        }
        // Valida si todos los check están seleccionados para entonces hacer checked en todos
        if (this.validaAllChecked) {
          this.selectedAll = true;
        }
      }
    } else {
      this.selectedAll = false; // Desmarca el check de todos
      // Valida si Quitó el checked de 'todos'
      if (e.target.value == 'todos') {
        this.notificationsSelected = []; // Vacia completamente las notificaciones seleccionadas
        // Hace un map del arreglo para agregarle a todos el checked false
        this.listMediosNotificacion = this.listMediosNotificacion.map((medio) => {
          medio.checked = false;
          return medio;
        });
      } else {
        this.notificationsSelected.splice(this.notificationsSelected.findIndex(element => element == e.target.value), 1);
        this.listMediosNotificacion[this.listMediosNotificacion.findIndex(element => element.id == e.target.value)]['checked'] = false;
      }
    }
    // Agrega al formulario el listado seleccionado
    this.f['tipoNotificacion'].setValue(this.notificationsSelected);
  }

  get validaAllChecked() {
    const noSelected = this.listMediosNotificacion.find(e => e.checked == false);
    return noSelected == null;
  }

  getListErrorsForm(): string[] {
    const list: string[] = [];
    Object.keys(this.f).forEach(key => {
      const controlErrors = this.registerForm.get(key)?.errors;
      if (controlErrors != null) {
        Object.keys(controlErrors).forEach(keyError => {
          if (keyError === "required") {
            list.push(key);
          }
        });
      }
    });
    return list;
  }

}
