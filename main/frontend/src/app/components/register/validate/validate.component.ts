import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from "@angular/forms";
import { NgbModal, ModalDismissReasons, NgbActiveModal, NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';

import { ParametricosService } from "../../../services/parametricos.service";
import { CiudadanoService } from "../../../services/ciudadano.service";
import { RegisterService } from "../../../services/register.service";
import { Parametrico, ParametricosStorage } from "../../../model/parametricos";
import { TratamientoDatosModalComponent } from '../basic-data/tratamiento-datos-modal/tratamiento-datos-modal.component';
import { BehaviorSubject } from 'rxjs';

@Component({
  selector: 'app-modal-content',
  template: `
  <div class="modal-header">
      <h5 class="modal-title text-center">Registro de Buscador</h5>
      <!-- <button type="button" class="close" aria-label="Close" (click)="activeModal.dismiss('Cross click')">
        <span aria-hidden="true">&times;</span>
      </button> -->
  </div>
  <div class="modal-body">
    Su tipo y número de identificación ya se encuentra registrado en el Servicio Público de Empleo. <br>
    Por favor inicie sesión, si no recuerda su usuario o contraseña, reestablezca su contraseña.
  </div>
  <div class="modal-footer">
      <div class="left-side">
          <!-- <button type="button" class="btn btn-default btn-link" (click)="activeModal.close('Close click')">Never mind</button> -->
      </div>
      <div class="divider"></div>
      <div class="right-side">
          <button type="button" class="btn btn-danger" (click)="activeModal.close('close')">CERRAR</button>
      </div>
  </div>
  `
})
export class NgbdModalContent {
  @Input() name: any;

  constructor(public activeModal: NgbActiveModal) { }
}

@Component({
  selector: 'app-validate',
  templateUrl: './validate.component.html',
  styleUrls: ['./validate.component.css']
})
export class ValidateComponent implements OnInit {

  validateForm!: FormGroup;
  submitted: boolean = false;
  showLoading: boolean = false;
  listTipoDocumento: Parametrico[] = [];
  model: NgbDateStruct | undefined;
  minDate = { year: 1900, month: 1, day: 1 };
  maxDateHoy: { year: number; month: number; day: number };
  verValidacionCuenta = new BehaviorSubject<boolean>(false);
  validacionDepin=false;
  permitirReenviarPin=true;
  timeoutId:any;
  constructor(
    public formBuilder: FormBuilder,
    public parametricosService: ParametricosService,
    public ciudadanoService: CiudadanoService,
    public registerService: RegisterService,
    private router: Router,
    private modalService: NgbModal
  ) {
    //Inicia el formulario
    this.validateForm = this.formBuilder.group({
      TipoDocumentoId: ['', Validators.required],
      NumeroDocumento: ['', [Validators.required, Validators.pattern("^[0-9]*$"), Validators.minLength(6), Validators.maxLength(10)]],
      ConfirmacionNumeroDocumento: ['', [Validators.required]],
      //CorreoElectronico: ['', [Validators.required, Validators.pattern(/^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$/)]], // ^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$
      CorreoElectronico: ['', [Validators.required, Validators.pattern(/^[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9]){1}?$/)]], // ^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$
      fechaExpedicionDocumento: [null, Validators.required],
      codigoVerificacion: [null,],// Validators.required, Validators.maxLength(7)
      key: [null,],
      terminosCondiciones: [null, Validators.required],
      tratamientoDatosPersonales: [null, Validators.required],
    }, {validators:this.NumeroDocumentoConfirming}
    );
    // Define la fecha máxima del campo fecha
    const dateNow = new Date;
    this.maxDateHoy = { year: new Date().getFullYear(), month: dateNow.getMonth() + 1, day: dateNow.getDate() };
  }

  ngOnInit(): void {
    // Convoca función para consultar los parametricos para el formulario
    this.getTipoDocumentos(this.parametricosService.getParametricosSessionStorage);
    // Valida si ya hay un proceso de validación creado
    const dataValidate = this.registerService.getValidateData();
    if (dataValidate) {
      this.validateForm.patchValue(dataValidate);
      this.model = dataValidate.fechaExpedicionDocumento;
    }

    this.registerService.disableTabsByTab([2, 3]);
    this.verValidacionCuenta.subscribe((val) => {
      console.log(val,this.permitirReenviarPin);
    
      if(val){    
        clearTimeout(this.timeoutId)   
        this.timeoutId = setTimeout(() => {
        console.log("Delayed for 10 second.");
        this.permitirReenviarPin = true;
      }, 10000);
      }
      
    });
    
  }

  /**
   * Función que invoca el servicio para consultar al API los tipos de documentos
   */
  getTipoDocumentos(parametricosSession: ParametricosStorage) {
    // Si existen los parametricos de tipo documento
    const listTipoDocumentoStorage = this.parametricosService.getDataKeyParametricosStorage('TipoDocumento');
    if (listTipoDocumentoStorage !== undefined) {
      // Llena el listado de tipos documento con lo registrado en el storage
      this.listTipoDocumento = listTipoDocumentoStorage;
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

  /**
   * Función que setea validaciones sobre el número documento dependiendo del tipo de documento
   */
  validaNumeroDocumento(e: any) {
    const tipo = e.target.value;
    this.f['NumeroDocumento'].clearValidators();

    switch (tipo) {
      case '1': // CC
      case '2': // TI
      case '14': // CE
        this.f['NumeroDocumento'].addValidators([Validators.required, Validators.pattern("^[0-9]*$"), Validators.minLength(6), Validators.maxLength(10)]);
        break;
      case '3': // DNI
        this.f['NumeroDocumento'].addValidators([Validators.required, Validators.pattern("^[0-9]*$"), Validators.minLength(6), Validators.maxLength(20)]);
        break;
      default:
        this.f['NumeroDocumento'].addValidators([Validators.required, Validators.pattern("^[0-9]*$"), Validators.minLength(6)]);
        break;
    }
    this.f['NumeroDocumento'].updateValueAndValidity();
  }

  get requiredNumDoc() {
    return this.f["NumeroDocumento"].hasError("required");
  }
  get maxLengthValidNumDoc() {
    return this.f["NumeroDocumento"].hasError("maxlength");
  }
  get minLengthValidNumDoc() {
    return this.f["NumeroDocumento"].hasError("minlength");
  }

  /**
   * Función del submit del formulario para realizar el llamado al servicio y validar si el tipo documento con el número documento existen en el sistema
   */
  validateAction() {
    this.submitted = true;
    this.verValidacionCuenta.next(false); //= false;
    // Valida si el formuario ya contiene los campos requeridos
    if (this.validateForm.valid) {
      this.showLoading = true;
      const tipo = this.validateForm.value.TipoDocumentoId;
      const numero = this.validateForm.value.NumeroDocumento;
      const email = this.validateForm.value.CorreoElectronico;

      this.ciudadanoService.validateCiudadanoRegistro(tipo, numero,email).subscribe((response) => {
        // Valida en la respuesta si existe el ciudadano o no
        if (response.existe) {          
          const modalRef = this.modalService.open(NgbdModalContent).result.then(
            (result) => {
              if (result == 'close') {
                setTimeout(() => {
                  this.router.navigate(['/login']);
                }, 500);
              }
            }
          );
          this.showLoading = false;
        } else {
          this.validateForm.controls['key'].setValue(response.key);          
          this.showLoading = false;          
          this.validateForm.controls['codigoVerificacion'].setValue("");
          this.validateForm.controls['codigoVerificacion'].addValidators([Validators.required,Validators.minLength(1)]);
          this.validateForm.controls['codigoVerificacion'].updateValueAndValidity();          
        }
        this.verValidacionCuenta.next(true) //= true;
      }, (err) => {
        console.log(err);
      });
    }
  }

  reenviarPin(evt: any){
    evt.preventDefault();  
    this.permitirReenviarPin = false;
    this.validateForm.controls['codigoVerificacion'].setValidators(null);
    this.validateForm.controls['codigoVerificacion'].updateValueAndValidity(); 
    this.validateAction();    
    
  }


  validatePin() {
    this.submitted = true;
    // Valida si el formuario ya contiene los campos requeridos
    if (this.validateForm.valid) {
      this.showLoading = true;
      const tipo = this.validateForm.value.TipoDocumentoId;
      const numero = this.validateForm.value.NumeroDocumento;
      const email = this.validateForm.value.CorreoElectronico;
      const key = this.validateForm.value.key;
      const pin = this.validateForm.value.codigoVerificacion;
      this.validacionDepin = false;
      this.ciudadanoService.validatePin(tipo, numero,email,key,pin).subscribe((response) => {
        // Valida en la respuesta si existe el ciudadano o no
        if (response.valido) {
          setTimeout(() => {
             // Debe ir al siguiente paso
            this.showLoading = false;
            this.registerService.putRegisterData(this.validateForm.value, 'validate');
            this.registerService.changeShowBasicData();
          }, 1000);
          
        } else {  
          this.validacionDepin = true;
          this.showLoading = false;
        }
      }, (err) => {
        console.log(err);
      });
    }
  }

  verFormualrioRegistro(evt: any){
    evt.preventDefault();
    this.verValidacionCuenta.next(false);
    this.validateForm.controls['codigoVerificacion'].setValue(null);
    this.validateForm.controls['codigoVerificacion'].setValidators(null);
    this.validateForm.controls['codigoVerificacion'].updateValueAndValidity();     
    this.validacionDepin=false; 
  }

  toggleCheckbox(e: any, control: string) {
    if (!e.target.checked) {
      this.f[control].setValue('');
    } else {
      if (control == 'tratamientoDatosPersonales') {
        const modalTratamientos = this.modalService.open(TratamientoDatosModalComponent, {
          size: 'md', backdrop: 'static', animation: true
        });
        modalTratamientos.result.then(response => {
          if (!response) {
            this.f[control].setValue('');
          }
        });
      }
    }
  }

  
  NumeroDocumentoConfirming(formGroup: FormGroup) {
    const ConfirmacionNumeroDocumento = formGroup.get('ConfirmacionNumeroDocumento')?.value;
    const NumeroDocumento = formGroup.get('NumeroDocumento')?.value;
    return ConfirmacionNumeroDocumento === NumeroDocumento ? null : { mismatch: true };
  }


  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.validateForm.controls;
  }

  validateOnlyNumberInput(evt: any) {
    const code = (evt.which) ? evt.which : evt.keyCode;
    const number = evt.target.value;
    let out = '';
    const filtro = '1234567890'; //Caracteres validos
    const formControlName = evt.srcElement.getAttribute('formControlName')

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

      this.f[formControlName].setValue(out);
    }
  }

}
