import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Router } from '@angular/router';
// import { ReCaptchaV3Service } from 'ng-recaptcha';
import { InvisibleReCaptchaComponent, ReCaptcha2Component, ReCaptchaV3Service } from 'ngx-captcha';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { environment } from '../../../environments/environment';

import { ParametricosService } from "../../services/parametricos.service";
import { LoginService } from "../../services/login.service";
import { CvService } from "../../services/cv.service";
import { Parametrico, ParametricosStorage } from "../../model/parametricos";

import { ModalErrorFormComponent } from "src/app/shared/components/modal-error-form/modal-error-form.component";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm!: FormGroup;
  submitted: boolean = false;
  showPassword: boolean = false;
  showLoading: boolean = false;
  listTipoDocumento: Parametrico[] = [];

  siteKey: string = environment.recaptcha.siteKey;
  @ViewChild('captchaElem', { static: false }) captchaElem!: InvisibleReCaptchaComponent;

  constructor(
    public formBuilder: FormBuilder,
    private reCaptchaV3Service: ReCaptchaV3Service,
    private router: Router,
    public parametricosService: ParametricosService,
    public loginService: LoginService,
    public cvService: CvService,
    private modalService: NgbModal,
  ) {
    this.loginForm = this.formBuilder.group({
      tipoDocumento: ['', Validators.required],
      numeroDocumento: ['', [Validators.required, Validators.pattern("^[0-9]*$"), Validators.minLength(6), Validators.maxLength(10)]],
      password: ['', [Validators.required]]
    });
  }

  ngOnInit(): void {
    // Convoca función para consultar los parametricos para el formulario
    this.getTipoDocumentos(this.parametricosService.getParametricosSessionStorage);

    // this.f['tipoDocumento'].disable();
    // this.f['numeroDocumento'].disable();
    // this.f['password'].disable();
  }

  /**
   * Función que invoca el servicio para consultar al API los tipos de documentos
   */
  getTipoDocumentos(parametricosSession: ParametricosStorage) {
    // Si existen los parametricos de tipo documento
    const listTipoDocumentoStorage = this.parametricosService.getDataKeyParametricosStorage('TipoDocumento');
    if (listTipoDocumentoStorage !== undefined) {
      // Llena el listado de tipos documento con lo registrado en el storage
      this.listTipoDocumento = listTipoDocumentoStorage.filter(tipoDoc => tipoDoc.principal === true);
    } else {
      this.showLoading = true;
      this.parametricosService.getParametricosDefault('TipoDocumento').subscribe((response) => {
        this.listTipoDocumento = response.map(function (element) {
          return { id: element.id, nombre: element.nombre, sigla: element.sigla, principal: element.principal }
        });
        this.listTipoDocumento = this.listTipoDocumento.filter(tipoDoc => tipoDoc.principal === true);

        // Consume servicio para añadir parametrico en el storage
        this.parametricosService.addParametricoSessionStorage('TipoDocumento', this.listTipoDocumento);

        setTimeout(() => {
          this.showLoading = false;
        }, 1000);
      });
    }
  }

  loginAction() {
    if (this.loginForm.valid && this.f['password'].value === 'accesohv') {
      this.submitted = true;
      this.reCaptchaV3Service.execute(this.siteKey, 'login', (token) => {
        console.log('This is your token: ', token);
        // Si retorna token del reCaptcha entonces consume API para búscar el ciudadano
        this.loginService.getCiudadanoByTipoNumero(this.f['tipoDocumento'].value, this.f['numeroDocumento'].value).subscribe(
          (response) => {
            // Si devuelve la data de forma exitosa entonces la almacena en una variable en el servicio de hoja de vida
            this.cvService.setCiudadano(response);
            setTimeout(() => {
              this.router.navigate(['/cv']);
            }, 900);
          },
          (error) => {
            this.submitted = false;
            // Lanza modal de confirmación para la eliminación
            const modalConfirm = this.modalService.open(ModalErrorFormComponent, {
              size: 'md', backdrop: 'static', animation: true
            });
            modalConfirm.componentInstance.body = `${error.error.error}`;
          }
        );
      }, {
        useGlobalDomain: false
      },
        (error) => console.log(error));
    } else {
      this.alertEnConstruccion();
    }
  }

  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.loginForm.controls;
  }

  /**
   * Función que setea validaciones sobre el número documento dependiendo del tipo de documento
   */
  validaNumeroDocumento(e: any) {
    const tipo = e.target.value;
    this.f['numeroDocumento'].clearValidators();

    switch (tipo) {
      case '1': // CC
      case '2': // TI
        this.f['numeroDocumento'].addValidators([Validators.required, Validators.pattern("^[0-9]*$"), Validators.maxLength(10), Validators.minLength(6)]);
        break;
      case '3': // DNI
        this.f['numeroDocumento'].addValidators([Validators.required, Validators.pattern("^[0-9]*$"), Validators.maxLength(20), Validators.minLength(6)]);
        break;
      default:
        this.f['numeroDocumento'].addValidators([Validators.required, Validators.pattern("^[0-9]*$"), Validators.minLength(6)]);
        break;
    }
    this.f['numeroDocumento'].updateValueAndValidity();
  }

  get requiredNumDoc() {
    return this.f["numeroDocumento"].hasError("required");
  }
  get maxLengthValidNumDoc() {
    return this.f["numeroDocumento"].hasError("maxlength");
  }
  get minLengthValidNumDoc() {
    return this.f["numeroDocumento"].hasError("minlength");
  }

  validateOnlyNumberInput(evt: any) {
    const code = (evt.which) ? evt.which : evt.keyCode;
    const number = evt.target.value;
    let out = '';
    const filtro = '1234567890'; //Caracteres validos

    if (code != 8) { // backspace.
      //Recorrer el texto y verificar si el caracter se encuentra en la lista de validos
      for (var i = 0; i < number.length; i++) {
        if (filtro.indexOf(number.charAt(i)) != -1) {
          if (i == 0) {
            if (number.charAt(i) != 0) {
              //Se añaden a la salida los caracteres validos
              out += number.charAt(i);
            }
          } else {
            //Se añaden a la salida los caracteres validos
            out += number.charAt(i);
          }
        }
      }
      this.f['numeroDocumento'].setValue(out);
    }
  }

  /**
   * Función que se encarga de hacer el toggle de show de un campo tipo password
   * @param controlP string que identifica el control o campo de contraseña
   */
  toggleShowPassword(controlP: string) {
    if (controlP == 'password') {
      this.showPassword = !this.showPassword;
    }
  }

  alertEnConstruccion() {
    alert("En construcción!!");
  }

}
