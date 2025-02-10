import { Component, OnInit, Input } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { NgbActiveModal, NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';

import { ParametricosService, PARAMETRICOS, PARAMETRICOS_FILTROS } from "src/app/services/parametricos.service"
import { CvService } from "src/app/services/cv.service"

import { EducacionFormal, ExperienciaPrevia } from "src/app/model/ciudadano";
import { ParametricoListado, Parametrico } from "src/app/model/parametricos";

@Component({
  selector: 'app-form-modal-previous-experience',
  templateUrl: './form-modal-previous-experience.component.html',
  styleUrls: ['./form-modal-previous-experience.component.css']
})
export class FormModalPreviousExperienceComponent implements OnInit {
  @Input() public type: string = 'new';
  @Input() public ciudadanoId: string = '';
  @Input() public data?: ExperienciaPrevia;
  @Input() public list?: ExperienciaPrevia[];

  previousExperienceForm!: FormGroup;
  iniciando: boolean = true;
  submitted: boolean = false;
  showLoading: boolean = false;
  typeStr: string = '';
  listTitulosEdFormal: EducacionFormal[] = [];
  listConocimientos: Parametrico[] = [];
  listHabilidades: Parametrico[] = [];
  conocimientosControl = new FormControl('');
  habilidadesControl = new FormControl('');

  fechaIngreso: NgbDateStruct | undefined;
  fechaRetiro: NgbDateStruct | undefined;
  minDate = { year: 1900, month: 1, day: 1 };
  minDateRetiro = { year: 1900, month: 1, day: 1 };
  maxDate: { year: number; month: number; day: number };

  constructor(
    public formBuilder: FormBuilder,
    public cvService: CvService,
    public prs: ParametricosService,
    public modalActiveService: NgbActiveModal,
  ) {
    this.previousExperienceForm = this.formBuilder.group({
      id: [null],
      ciudadanoId: [null],
      tipoExperienciaId: [null, Validators.required],
      ciudadanoEducacionFormalId: [null, Validators.required],
      ocupacionId: [null, Validators.required],
      lugarExperiencia: [null],
      fechaIngreso: [null, Validators.required],
      fechaRetiro: [null, Validators.required],
      conocimientoCompetenciaExperienciaPrevia: this.formBuilder.array([], Validators.required),
      habilidadDestrezaExperienciaPrevia: this.formBuilder.array([], Validators.required),
      nombre: [null],
      telefono: [null],
    });
    // Define la fecha máxima de los campos fecha ingreso y retiro
    const dateNow = new Date;
    this.maxDate = { year: new Date().getFullYear(), month: dateNow.getMonth() + 1, day: dateNow.getDate() };
  }

  ngOnInit(): void {
    this.typeStr = this.type == 'new' ? 'Agregar' : 'Editar';
    this.f['ciudadanoId'].setValue(this.ciudadanoId);
    this.getTitulosEducacionFormal();
    this.cambiaFechaIngreso();
    this.cambiaOcupacionIdForm();

    if (this.data !== undefined) {
      this.previousExperienceForm.patchValue(this.data);
      this.fechaIngreso = this.cvService.convertStringToDate(this.data.fechaIngreso);
      this.fechaRetiro = this.cvService.convertStringToDate(this.data.fechaRetiro);
      // Transforma la info de algunos campos que son arreglo de números y q van en campos syncfusion
      // Conocimientos
      let conocimientosArrControl = this.f['conocimientoCompetenciaExperienciaPrevia'] as FormArray;
      this.data.conocimientoCompetenciaExperienciaPrevia.map((c: string) => new FormControl(c)).forEach(control => conocimientosArrControl.push(control));
      this.conocimientosControl.setValue(this.f['conocimientoCompetenciaExperienciaPrevia'].value);
      // Habilidades
      let habilidadesArrControl = this.f['habilidadDestrezaExperienciaPrevia'] as FormArray;
      this.data.habilidadDestrezaExperienciaPrevia.map((h: string) => new FormControl(h)).forEach(control => habilidadesArrControl.push(control));
      this.habilidadesControl.setValue(this.f['habilidadDestrezaExperienciaPrevia'].value);
    }

    setTimeout(() => {
      this.iniciando = false;
    }, 1000);
  }

  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.previousExperienceForm.controls;
  }

  getTitulosEducacionFormal() {
    this.cvService.getListEducacionFormal(this.ciudadanoId, true).subscribe(
      listado => {
        this.listTitulosEdFormal = listado;
      }
    );
  }

  addPreviousExperience() {
    this.submitted = true;
    if (this.previousExperienceForm.valid) {
      this.showLoading = true;
      const formSend: ExperienciaPrevia = this.previousExperienceForm.value;

      formSend.tipoExperienciaId = +this.f['tipoExperienciaId'].value;
      formSend.fechaIngreso = this.cvService.convertSringDate(this.f['fechaIngreso'].value);
      formSend.fechaRetiro = this.cvService.convertSringDate(this.f['fechaRetiro'].value);

      if (this.type == 'new') {
        this.cvService.addPreviousExperience(formSend).subscribe(
          response => {
            // Valida si el listado actual no tiene nada para entonces enviar petición de cambio a true
            if (this.list?.length == 0) {
              this.cvService.putTieneExperienciaPrevia(this.ciudadanoId, true).subscribe(
                response => {
                  this.cvService.toggleBooleanDataCiudadano('tieneExperienciaPrevia', response.tieneExperienciaLaboral);
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
        this.cvService.editPreviousExperience(formSend).subscribe(
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

  /**
   * Función que se encarga de asegurar que el campo ocupacion en el formuarlio cambie y de listar los conocimientos y habilidades
   */
  cambiaOcupacion($event: { itemData: Parametrico; }) {
    let itemData: Parametrico = $event.itemData;
    this.f['ocupacionId'].setValue(itemData.id);
    this.clearConocimientos();
    this.clearHabilidades();

    this.prs.getParametricos(PARAMETRICOS.CONOCIMIENTOS, PARAMETRICOS_FILTROS.CONOCIMIENTOS__OCUPACION_ID, itemData.cuocOcupacionId).subscribe(
      response => {
        this.listConocimientos = response;
      }
    );
    this.prs.getParametricos(PARAMETRICOS.DESTREZAS, PARAMETRICOS_FILTROS.DESTREZAS__OCUPACION_ID, itemData.cuocOcupacionId).subscribe(
      response => {
        this.listHabilidades = response;
      }
    );
  }
  /**
   * Funcion que se ejecuta cada vez que el control ocupacion del form builder cambia, incluyendo el patchvalue del form
   * Esto con el objetivo de asegurar la carga de los campos que dependen de la ocupacion
   */
  cambiaOcupacionIdForm() {
    this.f['ocupacionId'].valueChanges.subscribe(
      ocupacion => {
        if (ocupacion !== null && ocupacion !== undefined) {
          this.cvService.$denominaciones.subscribe(
            ocupaciones => {
              const ocupacionSelected = ocupaciones.find(o => o.id == ocupacion);
              if (ocupacionSelected) {
                this.prs.getParametricos(PARAMETRICOS.CONOCIMIENTOS, PARAMETRICOS_FILTROS.CONOCIMIENTOS__OCUPACION_ID, ocupacionSelected.cuocOcupacionId).subscribe(
                  response => {
                    this.listConocimientos = response;
                  }
                );
                this.prs.getParametricos(PARAMETRICOS.DESTREZAS, PARAMETRICOS_FILTROS.DESTREZAS__OCUPACION_ID, ocupacionSelected.cuocOcupacionId).subscribe(
                  response => {
                    this.listHabilidades = response;
                  }
                );
              }
            }
          );
        }
      }
    );
  }

  cambiaFechaIngreso() {
    this.f['fechaIngreso'].valueChanges.subscribe(
      fechaI => {
        if (fechaI !== null && fechaI !== undefined) {
          // Setea la fecha mínima que es la de ingreso para el campo fecha retiro
          this.minDateRetiro = fechaI;
          this.f['fechaRetiro'].setValue(null);
        }
      }
    );
  }

  /**
   * Función que se encarga de agregar la selección un campo multiselect al listado correspondiente
   */
  public seleccionarMultiCampo($event: { itemData: Parametrico; }, control: string) {
    switch (control) {
      case 'conocimientoCompetenciaExperienciaPrevia':
        let conocimientos = this.f['conocimientoCompetenciaExperienciaPrevia'] as FormArray;
        conocimientos.push(new FormControl($event.itemData.id));
        break;
      case 'habilidadDestrezaExperienciaPrevia':
        let habilidades = this.f['habilidadDestrezaExperienciaPrevia'] as FormArray;
        habilidades.push(new FormControl($event.itemData.id));
        break;
    }
  }
  /**
   * Función que se encarga de quitar del listado correspondiente el que eliminen en el campo multiselect
   */
  public quitarMulticampo($event: { itemData: Parametrico; }, control: string) {
    switch (control) {
      case 'conocimientoCompetenciaExperienciaPrevia':
        let conocimiento = this.f['conocimientoCompetenciaExperienciaPrevia'] as FormArray;
        let iC = conocimiento.controls.findIndex((control) => control.value == $event.itemData.id);
        conocimiento.removeAt(iC);
        break;
      case 'habilidadDestrezaExperienciaPrevia':
        let habilidad = this.f['habilidadDestrezaExperienciaPrevia'] as FormArray;
        let iH = habilidad.controls.findIndex((control) => control.value == $event.itemData.id);
        habilidad.removeAt(iH);
        break;
    }
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
          //Se añaden a la salida los caracteres validos
          out += number.charAt(i);
        }
      }
      this.f[control].setValue(out);
    }
  }

  clearConocimientos() {
    this.conocimientosControl.setValue('');
    let conocimiento = this.f['conocimientoCompetenciaExperienciaPrevia'] as FormArray;
    conocimiento.clear();
  }
  clearHabilidades() {
    this.habilidadesControl.setValue('');
    let habilidad = this.f['habilidadDestrezaExperienciaPrevia'] as FormArray;
    habilidad.clear();
  }

}
