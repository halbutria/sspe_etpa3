import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { NgbActiveModal, NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';

import { ParametricosService, PARAMETRICOS, PARAMETRICOS_FILTROS } from "src/app/services/parametricos.service"
import { CvService } from "src/app/services/cv.service"

import { Idioma } from "src/app/model/ciudadano";
import { ParametricoListado, Parametrico } from "src/app/model/parametricos";

@Component({
  selector: 'app-modal-form-languages',
  templateUrl: './modal-form-languages.component.html',
  styleUrls: ['./modal-form-languages.component.css']
})
export class ModalFormLanguagesComponent implements OnInit {

  @Input() public type: string = 'new';
  @Input() public ciudadanoId: string = '';
  @Input() public data?: Idioma;

  idiomaForm!: FormGroup;
  submitted: boolean = false;
  iniciando: boolean = true;
  showLoading: boolean = false;
  typeStr: string = '';
  msgError: string = '';

  fechaCertificacion: NgbDateStruct | undefined;

  constructor(
    public formBuilder: FormBuilder,
    public cvService: CvService,
    public prs: ParametricosService,
    public modalActiveService: NgbActiveModal,
  ) {
    this.idiomaForm = this.formBuilder.group({
      id: [null],
      ciudadanoId: [null],
      idiomaId: [null, Validators.required],
      nivelEscrito: [null, Validators.required],
      nivelHablado: [null, Validators.required],
      nivelEscucha: [null, Validators.required],
      nivelLectura: [null, Validators.required],
    });
  }

  ngOnInit(): void {
    this.iniciando = true;
    this.typeStr = this.type == 'new' ? 'Agregar' : 'Editar';
    this.f['ciudadanoId'].setValue(this.ciudadanoId);
    if (this.data !== undefined) {
      this.idiomaForm.patchValue(this.data);
    }

    setTimeout(() => {
      this.iniciando = false;
    }, 1000);
  }

  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.idiomaForm.controls;
  }

  /**
   * Función que se encarga de organizar la data para el guardado
   */
  addIdioma() {
    this.submitted = true;
    if (this.idiomaForm.valid) {
      this.showLoading = true;
      const formSend: Idioma = this.idiomaForm.value;

      formSend.idiomaId = +this.f['idiomaId'].value;
      formSend.nivelEscrito = this.f['nivelEscrito'].value.toString();
      formSend.nivelEscucha = this.f['nivelEscucha'].value.toString();
      formSend.nivelHablado = this.f['nivelHablado'].value.toString();
      formSend.nivelLectura = this.f['nivelLectura'].value.toString();

      if (this.type == 'new') {
        this.cvService.addIdioma(formSend).subscribe(
          response => {
            // Responde al padre con el item creado
            this.showLoading = false;
            this.modalActiveService.close(formSend);
          },
          error => {
            this.showLoading = false;
            console.log(error);
            this.msgError = error.error.error;
          }
        );
      } else if (this.type == 'edit') {
        this.cvService.editIdioma(formSend).subscribe(
          response => {
            this.showLoading = false;
            this.modalActiveService.close(response);
          },
          error => {
            this.showLoading = false;
            console.log(error);
            this.msgError = error.error.error;
          }
        );
      }
    }
  }

  closeModal() {
    this.modalActiveService.close(null);
  }

}
