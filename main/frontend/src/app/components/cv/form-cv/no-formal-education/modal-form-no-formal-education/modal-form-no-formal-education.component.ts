import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { NgbActiveModal, NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';

import { ParametricosService, PARAMETRICOS, PARAMETRICOS_FILTROS } from "src/app/services/parametricos.service"
import { CvService } from "src/app/services/cv.service"

import { EducacionNoFormal } from "src/app/model/ciudadano";
import { ParametricoListado, Parametrico } from "src/app/model/parametricos";

@Component({
  selector: 'app-modal-form-no-formal-education',
  templateUrl: './modal-form-no-formal-education.component.html',
  styleUrls: ['./modal-form-no-formal-education.component.css']
})
export class ModalFormNoFormalEducationComponent implements OnInit {

  @Input() public type: string = 'new';
  @Input() public ciudadanoId: string = '';
  @Input() public data?: EducacionNoFormal;
  @Input() public list?: EducacionNoFormal[];

  noFormalEducationForm!: FormGroup;
  submitted: boolean = false;
  iniciando: boolean = true;
  showLoading: boolean = false;
  showDataCertificacion: boolean = false;
  typeStr: string = '';

  dateNow = new Date;
  minDate = { year: 1900, month: 1, day: 1 };
  maxDate = { year: this.dateNow.getFullYear(), month: this.dateNow.getMonth() + 1, day: this.dateNow.getDate() };
  fechaCertificacion: NgbDateStruct | undefined;

  constructor(
    public formBuilder: FormBuilder,
    public cvService: CvService,
    public prs: ParametricosService,
    public modalActiveService: NgbActiveModal,
  ) {
    this.noFormalEducationForm = this.formBuilder.group({
      id: [null],
      ciudadanoId: [null],
      tipoCertificadoCapacitacionId: [null, Validators.required],
      nombrePrograma: [null, Validators.required],
      institucion: [null, Validators.required],
      paisId: [null, Validators.required],
      estadoId: [null, Validators.required],
      duracion: [null],
      fechaCertificacion: [null],
    });
  }

  ngOnInit(): void {
    this.iniciando = true;
    this.cambiaEstado();
    this.typeStr = this.type == 'new' ? 'Agregar' : 'Editar';

    this.f['ciudadanoId'].setValue(this.ciudadanoId);
    if (this.data !== undefined) {
      this.noFormalEducationForm.patchValue(this.data);
      this.fechaCertificacion = this.cvService.convertStringToDate(this.data.fechaCertificacion);
    }

    setTimeout(() => {
      this.iniciando = false;
    }, 1000);
  }

  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.noFormalEducationForm.controls;
  }

  /**
   * Función que se encarga de organizar la data para el guardado
   */
  addNoFormalEducation() {
    this.submitted = true;
    if (this.noFormalEducationForm.valid) {
      this.showLoading = true;
      const formSend: EducacionNoFormal = this.noFormalEducationForm.value;

      formSend.tipoCertificadoCapacitacionId = +this.f['tipoCertificadoCapacitacionId'].value;
      formSend.paisId = +this.f['paisId'].value;
      formSend.estadoId = +this.f['estadoId'].value;
      formSend.duracion = this.f['duracion'].value == null || this.f['duracion'].value == '' ? null : +this.f['duracion'].value;
      formSend.fechaCertificacion = this.cvService.convertSringDate(this.f['fechaCertificacion'].value);

      if (this.type == 'new') {
        this.cvService.addNoFormalEducation(formSend).subscribe(
          response => {
            // Valida si el listado actual no tiene nada para entonces enviar petición de cambio a true
            if (this.list?.length == 0) {
              this.cvService.putTieneEducacionNoFormal(this.ciudadanoId, true).subscribe(
                response => {
                  this.cvService.toggleBooleanDataCiudadano('tieneEducacionNoFormal', response.tieneEducacionNoFormal);
                },
                error => {
                  console.log(error);
                }
              );
            }
            // Responde al padre con el item creado
            this.showLoading = false;
            this.modalActiveService.close(formSend);
          },
          error => {
            this.showLoading = false;
            console.log(error);
          }
        );
      } else if (this.type == 'edit') {
        this.cvService.editNoFormalEducation(formSend).subscribe(
          response => {
            this.showLoading = false;
            this.modalActiveService.close(response);
          },
          error => {
            this.showLoading = false;
            console.log(error);
          }
        );
      }
    }
  }

  closeModal() {
    this.modalActiveService.close(null);
  }

  validateOnlyNumberInput(evt: any, control: string) {
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
      this.f[control].setValue(out);
    }
  }

  cambiaEstado() {
    this.f['estadoId'].valueChanges.subscribe(
      value => {
        this.f['fechaCertificacion'].clearValidators();
        this.f['duracion'].clearValidators();
        if (value == 1) {
          this.showDataCertificacion = true;
          this.f['fechaCertificacion'].addValidators([Validators.required]);
          this.f['duracion'].addValidators([Validators.required, Validators.maxLength(4)]);         
        } else {
          this.showDataCertificacion = false;
          this.f['fechaCertificacion'].setValue('');
          this.f['duracion'].setValue('');
        }
        this.f['fechaCertificacion'].updateValueAndValidity();
        this.f['duracion'].updateValueAndValidity();
      }
    );
  }

}
