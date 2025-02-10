import { Component, OnInit, Input } from '@angular/core';
import { AbstractControl, FormArray, FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { NgbActiveModal, NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';

import { ParametricosService, PARAMETRICOS, PARAMETRICOS_FILTROS } from "src/app/services/parametricos.service"
import { CvService } from "src/app/services/cv.service"

import { InformacionLaboral, Conocimiento, Habilidad } from "src/app/model/ciudadano";
import { ParametricoListado, Parametrico } from "src/app/model/parametricos";

@Component({
  selector: 'app-modal-form-working-information',
  templateUrl: './modal-form-working-information.component.html',
  styleUrls: ['./modal-form-working-information.component.css']
})
export class ModalFormWorkingInformationComponent implements OnInit {

  @Input() public type: string = 'new';
  @Input() public ciudadanoId: string = '';
  @Input() public data?: InformacionLaboral;
  @Input() public list?: InformacionLaboral[];

  workingInformationForm!: FormGroup;
  submitted: boolean = false;
  iniciando: boolean = true;
  showLoading: boolean = false;
  showFieldChildTipoExp: boolean = false;
  showFieldFechaRetiro: boolean = true;
  changeActiveOcupacion: boolean = false;
  typeStr: string = '';
  countMinDigit: number = 10;
  listConocimientos: Parametrico[] = [];
  listHabilidades: Parametrico[] = [];
  listPaises: Parametrico[] = [];
  listConocimientosSelected: string[] = [];
  listHabilidadesSelected: string[] = [];
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
    this.workingInformationForm = this.formBuilder.group({
      id: [null],
      ciudadanoId: [null],
      tipoExperienciaId: [null, Validators.required],
      nombreEmpresa: [null, Validators.required],
      fechaIngreso: [null, Validators.required],
      fechaRetiro: [null, Validators.required],
      trabajoActual: [false],
      sectorId: [null, Validators.required],
      telefonoEmpresa: [null],
      paisId: [null, Validators.required],
      cargo: [null, Validators.required],
      ocupacionEquivalenteId: [null, Validators.required],
      conocimientoCompetenciaInformacionLaboral: this.formBuilder.array([], Validators.required),
      habilidadDestrezaInformacionLaboral: this.formBuilder.array([], Validators.required),
      productoServicioProduceComercializa: [null],
      cuantasPresonasTrabajanConUsted: [null],
      funciones: [null, [Validators.required, Validators.minLength(20), Validators.maxLength(3000)]],
    });
    // Define la fecha máxima de los campos fecha ingreso y retiro
    const dateNow = new Date;
    this.maxDate = { year: new Date().getFullYear(), month: dateNow.getMonth() + 1, day: dateNow.getDate() };
  }

  ngOnInit(): void {
    this.iniciando = true;
    this.typeStr = this.type == 'new' ? 'Agregar' : 'Editar';
    this.f['ciudadanoId'].setValue(this.ciudadanoId);
    // Setea los cambios en los campos
    this.cambiaOcupacionIdForm();
    this.cambiaTipoExperiencia();
    this.cambiaFechaIngreso();
    this.cambiaPais();
    this.getPaises();

    if (this.data !== undefined) {
      this.workingInformationForm.patchValue(this.data);
      this.f['trabajoActual'].setValue(this.cvService.getValueBooleanForm(this.data.trabajoActual));
      this.fechaIngreso = this.cvService.convertStringToDate(this.data.fechaIngreso);
      this.fechaRetiro = this.cvService.convertStringToDate(this.data.fechaRetiro);
      // Transforma la info de algunos campos que son arreglo de números y q van en campos syncfusion
      // Conocimientos
      let conocimientosArrControl = this.f['conocimientoCompetenciaInformacionLaboral'] as FormArray;
      this.data.conocimientoCompetenciaInformacionLaboral.map((c: string) => new FormControl(c)).forEach(control => conocimientosArrControl.push(control));
      this.conocimientosControl.setValue(this.f['conocimientoCompetenciaInformacionLaboral'].value);
      // Habilidades
      let habilidadesArrControl = this.f['habilidadDestrezaInformacionLaboral'] as FormArray;
      this.data.habilidadDestrezaInformacionLaboral.map((h: string) => new FormControl(h)).forEach(control => habilidadesArrControl.push(control));
      this.habilidadesControl.setValue(this.f['habilidadDestrezaInformacionLaboral'].value);
      // Invoca change del check trabajo actual
      this.onCheckboxChange(null);
    }

    setTimeout(() => {
      this.iniciando = false;
    }, 1000);
  }

  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.workingInformationForm.controls;
  }

  getPaises() {
    this.cvService.$paisesNacimiento.subscribe(paises => this.listPaises = paises);
  }

  /**
   * Función que se encarga de organizar la data para el guardado
   */
  addWorkingInformation() {
    this.submitted = true;
    if (this.workingInformationForm.valid) {
      this.showLoading = true;
      const formSend: InformacionLaboral = this.workingInformationForm.value;

      formSend.tipoExperienciaId = +this.f['tipoExperienciaId'].value;
      formSend.sectorId = +this.f['sectorId'].value;
      formSend.paisId = +this.f['paisId'].value;
      formSend.cuantasPresonasTrabajanConUsted = +this.f['cuantasPresonasTrabajanConUsted'].value;
      formSend.fechaRetiro = this.cvService.convertSringDate(this.f['fechaRetiro'].value);
      formSend.fechaIngreso = this.cvService.convertSringDate(this.f['fechaIngreso'].value);

      if (this.type == 'new') {
        this.cvService.addWorkingInformation(formSend).subscribe(
          response => {
            // Valida si el listado actual no tiene nada para entonces enviar petición de cambio a true
            if (this.list?.length == 0) {
              this.cvService.putTieneExperienciaLaboral(this.ciudadanoId, true).subscribe(
                response => {
                  this.cvService.toggleBooleanDataCiudadano('tieneInformacionLaboral', response.tieneInformacionLaboral);
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
        this.cvService.editWorkingInformation(formSend).subscribe(
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

  onCheckboxChange(e: any) {
    const checked = e === null ? this.f['trabajoActual'].value : e.target.checked;
    this.f['fechaRetiro'].clearValidators();
    if (checked) {
      this.f['trabajoActual'].setValue(true);
      // Deja la fecha de retiro no requerido y no visible
      this.showFieldFechaRetiro = false;
      this.f['fechaRetiro'].setValue(null);
    } else {
      this.f['trabajoActual'].setValue(false);
      this.f['fechaRetiro'].addValidators([Validators.required]);
      this.showFieldFechaRetiro = true;
    }
    this.f['fechaRetiro'].updateValueAndValidity();
  }

  cambiaTipoExperiencia() {
    this.f['tipoExperienciaId'].valueChanges.subscribe(
      tipo => {
        // Valida que no esté en proceso de inicio
        if (!this.iniciando) {
          this.f['productoServicioProduceComercializa'].setValue('');
          this.f['cuantasPresonasTrabajanConUsted'].setValue('');
          this.f['productoServicioProduceComercializa'].clearValidators();
          this.f['cuantasPresonasTrabajanConUsted'].clearValidators();
          // Si el tipo de experiencia es independiente entonces deja requeridos los campos
          if (tipo == 2) {
            this.showFieldChildTipoExp = true;
            this.f['productoServicioProduceComercializa'].addValidators([Validators.required]);
            this.f['cuantasPresonasTrabajanConUsted'].addValidators([Validators.required, Validators.maxLength(3)]);
          } else {
            this.showFieldChildTipoExp = false;
          }
          this.f['productoServicioProduceComercializa'].updateValueAndValidity();
          this.f['cuantasPresonasTrabajanConUsted'].updateValueAndValidity();
        }
      }
    );
  }

  /**
   * Función que se encarga de asegurar que el campo ocupacion en el formuarlio cambie y de listar los conocimientos y habilidades
   */
  cambiaOcupacion($event: { itemData: Parametrico; }) {
    this.changeActiveOcupacion = true;
    let itemData: Parametrico = $event.itemData;
    setTimeout(() => {
      this.f['ocupacionEquivalenteId'].setValue(itemData.id);
    }, 300);
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
    this.changeActiveOcupacion = false;
  }
  /**
   * Funcion que se ejecuta cada vez que el control ocupacion del form builder cambia, incluyendo el patchvalue del form
   * Esto con el objetivo de asegurar la carga de los campos que dependen de la ocupacion
   */
  cambiaOcupacionIdForm() {
    this.f['ocupacionEquivalenteId'].valueChanges.subscribe(
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

  cambiaPais() {
    this.f['paisId'].valueChanges.subscribe(
      pais => {
        if (pais !== null) {
          this.f['telefonoEmpresa'].clearValidators();
          if (pais == 48) {
            this.countMinDigit = 10; // Setea la cantidad de dígitos mínimos para el campo telefono en caso de ser Colombia
            this.f['telefonoEmpresa'].addValidators([Validators.minLength(10), Validators.maxLength(10), this.validateTelefono.bind(this)]);
          } else {
            this.countMinDigit = 7; // Setea la cantidad de dígitos mínimos para el campo telefono
            this.f['telefonoEmpresa'].addValidators([Validators.minLength(7), Validators.maxLength(10), this.validateTelefono.bind(this)]);
          }
          this.f['telefonoEmpresa'].updateValueAndValidity();
        }
      }
    );
  }

  /**
   * Función que se encarga de agregar la selección un campo multiselect al listado correspondiente
   */
  public seleccionarMultiCampo($event: { itemData: Parametrico; }, control: string) {
    switch (control) {
      case 'conocimientoCompetenciaInformacionLaboral':
        let conocimientos = this.f['conocimientoCompetenciaInformacionLaboral'] as FormArray;
        conocimientos.push(new FormControl($event.itemData.id));
        break;
      case 'habilidadDestrezaInformacionLaboral':
        let habilidades = this.f['habilidadDestrezaInformacionLaboral'] as FormArray;
        habilidades.push(new FormControl($event.itemData.id));
        break;
    }
  }
  /**
   * Función que se encarga de quitar del listado correspondiente el que eliminen en el campo multiselect
   */
  public quitarMulticampo($event: { itemData: Parametrico; }, control: string) {
    switch (control) {
      case 'conocimientoCompetenciaInformacionLaboral':
        let conocimiento = this.f['conocimientoCompetenciaInformacionLaboral'] as FormArray;
        let iC = conocimiento.controls.findIndex((control) => control.value == $event.itemData.id);
        conocimiento.removeAt(iC);
        break;
      case 'habilidadDestrezaInformacionLaboral':
        let habilidad = this.f['habilidadDestrezaInformacionLaboral'] as FormArray;
        let iH = habilidad.controls.findIndex((control) => control.value == $event.itemData.id);
        habilidad.removeAt(iH);
        break;
    }
  }

  public caracteresFaltantes(formControlName: string, cantidad: number) {
    try {
      let restantes = cantidad - Number(this.f[formControlName]?.value?.length);
      if (isNaN(restantes)) {
        return cantidad;
      }
      return restantes;
    } catch (error) {
      return 0;
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

  clearConocimientos() {
    this.conocimientosControl.setValue('');
    let conocimiento = this.f['conocimientoCompetenciaInformacionLaboral'] as FormArray;
    conocimiento.clear();
  }
  clearHabilidades() {
    this.habilidadesControl.setValue('');
    let habilidad = this.f['habilidadDestrezaInformacionLaboral'] as FormArray;
    habilidad.clear();
  }

  /**
   * Función que realiza algunas validaciones custom sobre el campo telefono
   * Si el país de residencia seleccionado es colombia:
   * - El primer número digitado debe ser 6 o 3.
   * - Siempre de 10 digitos
   * Si el país de residencia es diferente a Colombia no se restringe el ingreso.
   * - Solo restringir a mínimo 7 y máximo 10 digitos
   */
  validateTelefono(control: AbstractControl) {
    if (control.value !== null) {
      const pais = this.f['paisId'].value;
      // Valida si el campo pais tiene algún valor y el listado de paises está lleno
      if (pais != null && this.listPaises.length > 0) {
        const paisSeleccionado: any = this.listPaises.find(element => element.id == pais);
        const firstDigit = control.value.substr(0, 1);

        if (paisSeleccionado.nombre.toLocaleLowerCase() == 'colombia' && firstDigit != '6' && firstDigit != '3') {
          return { firstDigit: true };
        }
      }
    }
    return null;
  }

}
