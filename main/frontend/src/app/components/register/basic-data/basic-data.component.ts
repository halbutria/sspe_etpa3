import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { NgbActiveModal, NgbDateStruct, NgbModal, NgbDatepickerI18n } from '@ng-bootstrap/ng-bootstrap';

import { PARAMETRICOS, PARAMETRICOS_FILTROS, ParametricosService } from "../../../services/parametricos.service";
import { CiudadanoService } from "../../../services/ciudadano.service";
import { RegisterService } from "../../../services/register.service";
import { PrestadorService } from "../../../services/prestador.service";
import { CvService } from "src/app/services/cv.service";
import { ParametricoListado } from "../../../model/parametricos";
import { Ciudadano, Complemento, CreateRequest } from "../../../model/ciudadano";
import { CustomDatepickerI18nService, I18n } from "../../../services/custom-datepicker-i18n.service";
import { ModalValidationComponent } from "../modal-validation/modal-validation.component";
import { ComplementosDireccionModalComponent } from "./complementos-direccion-modal/complementos-direccion-modal.component";
import { TratamientoDatosModalComponent } from "./tratamiento-datos-modal/tratamiento-datos-modal.component";

import { PasswordValidators } from "../../../shared/password-validators";
import { Prestador } from 'src/app/model/prestador';
import { debounceTime, forkJoin, map, switchMap, tap } from 'rxjs';
import { ThisReceiver } from '@angular/compiler';


@Component({
  selector: 'app-basic-data',
  templateUrl: './basic-data.component.html',
  styleUrls: ['./basic-data.component.css'],
  providers: [I18n, { provide: NgbDatepickerI18n, useClass: CustomDatepickerI18nService }]
})
export class BasicDataComponent implements OnInit {

  basicDataForm!: FormGroup;
  submitted: boolean = false;
  showLoading: boolean = false;
  listTipoDocumento: ParametricoListado[] = [];
  listGeneros: ParametricoListado[] = [];
  listPaises: ParametricoListado[] = [];
  listDepartamentos: ParametricoListado[] = [];
  listMunicipios: ParametricoListado[] = [];
  listPrestadoresPreferencia: Prestador[] = [];
  listPuntosAtencion: ParametricoListado[] = [];
  listPreguntasSeguridad: ParametricoListado[] = [];
  date: { year: number; month: number; } | undefined;
  minDate = { year: 1900, month: 1, day: 1 };
  maxDate: { year: number; month: number; day: number };
  maxDateHoy: { year: number; month: number; day: number };
  model: NgbDateStruct | undefined;
  modelExpDoc: NgbDateStruct | undefined;
  showPassword: boolean = false;
  showPasswordConfirm: boolean = false;
  showDepartamento: boolean = true;
  showMunicipio: boolean = true;
  showFieldsDireccion: boolean = true;
  countMinDigit: number = 10;
  listViaPrincipal: { id: string, texto: string }[] = [];
  arrComplementos: Complemento[] = [];
  alphabet: string = 'abcdefghijklmnopqrstuvwxyz';
  localidadesComuna: ParametricoListado[] = [];


  listNombreCampos: any = {};

  constructor(
    public formBuilder: FormBuilder,
    public parametricosService: ParametricosService,
    public ciudadanoService: CiudadanoService,
    public registerService: RegisterService,
    public prestadorService: PrestadorService,
    public cvService: CvService,
    private modalService: NgbModal
  ) {
    //Inicia el formulario
    this.basicDataForm = this.formBuilder.group({
      tipoDocumentoId: [null, Validators.required],
      numeroDocumento: [null, Validators.required],
      correoElectronico: [null, [Validators.required, Validators.email]],
      password: [null, Validators.compose([
        Validators.required,
        Validators.minLength(8),
        Validators.maxLength(17),
        PasswordValidators.patternValidator(new RegExp("(?=.*[0-9])"), {
          requiresDigit: true
        }),
        PasswordValidators.patternValidator(new RegExp("(?=.*[A-Z])"), {
          requiresUppercase: true
        }),
        PasswordValidators.patternValidator(new RegExp("(?=.*[a-z])"), {
          requiresLowercase: true
        }),
        PasswordValidators.patternValidator(new RegExp("(?=.*[!\"#$%&'()*+,-./:;<=>?@\[\\\]^_`{|}~])"), {
          requiresSpecialChars: true
        })
      ])],
      confirmPassword: [null, [Validators.required, Validators.minLength(8)]],
      primerNombre: [null, [Validators.required, Validators.pattern("^[a-zA-Z\u00C0-\u017F\\s]+$")]],
      segundoNombre: ['', Validators.pattern("^[a-zA-Z\u00C0-\u017F\\s]+$")],
      primerApellido: [null, [Validators.required, Validators.pattern("^[a-zA-Z\u00C0-\u017F\\s]+$")]],
      segundoApellido: ['', Validators.pattern("^[a-zA-Z\u00C0-\u017F\\s]+$")],
      fechaNacimiento: [null, Validators.required],
      sexoId: [null, Validators.required],
      telefono: ['', [
        Validators.required,
        Validators.minLength(10),
        Validators.maxLength(10),
        this.validateTelefonoCel.bind(this)
      ]],
      otroTelefono: ['', [
        Validators.required,
        Validators.minLength(10),
        Validators.maxLength(10),
        this.validateTelefono.bind(this)
      ]],
      fechaExpedicionDocumento: [null, Validators.required],
      estado: [''],
      ciudad: [''],
      // Dirección
      direccionResidencia: [null, Validators.required],
      viaPrincipalId: [null],
      viaPrincipalNombre: [null],
      viaPrincipal: [null, Validators.maxLength(20)],
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
      paisResidenciaId: [null, Validators.required],
      departamentoResidenciaId: [null, Validators.required],
      municipioResidenciaId: [null, Validators.required],
      localidadComunaId: [null],
      barrioResidencia: [null],
      prestadorPreferenciaId: [null, Validators.required],
      puntoAtencionId: [null, Validators.required],
      perteneceARural: [null, Validators.required],
      preguntaSeguridadId: [null, Validators.required],
      preguntaSeguridadRespuesta: [null, Validators.required],
      preguntaLibre: [null],
      terminosCondiciones: [null, Validators.required],
      tratamientoDatosPersonales: [null, Validators.required],
    }, {
      validators: PasswordValidators.MatchValidator
    });
    // Define la fecha máxima del campo fecha nacimiento
    const dateNow = new Date;
    this.maxDate = { year: new Date().getFullYear() - 14, month: dateNow.getMonth() + 1, day: dateNow.getDate() };
    this.maxDateHoy = { year: new Date().getFullYear(), month: dateNow.getMonth() + 1, day: dateNow.getDate() };
  }

  ngOnInit(): void {
    // Convoca función para consultar los parametricos para el formulario
    this.getTipoDocumentos();
    this.getGeneros();
    this.getPaises();
    this.getDepartamentos();
    this.getMunicipios();
    this.getPreguntasSeguridad();
    this.getPuntosAtencion();
    // Cargue de listados de direcciones
    this.listViaPrincipal = this.cvService.getListViaPrincipal;

    this.cambioPerteneceA();

    // Valida si ya hay un proceso de registro creado
    const dataRegister = this.registerService.getRegisterData();
    if (dataRegister) {
      this.basicDataForm.patchValue(dataRegister);
      this.model = dataRegister.fechaNacimiento;
      this.modelExpDoc = dataRegister.fechaExpedicionDocumento;
      this.f['perteneceARural'].setValue(this.getValueBooleanForm(dataRegister.perteneceARural));
      // Simula change del depto para llenar el municipio y el de el prestador para llenar puntos de atencion
      this.changePais(null);
      this.changeDepartamento(null);
      this.changePrestador(null);
      this.setFieldsDireccion(dataRegister);
    } else {
      // Valida si ya hay un proceso de validación creado
      const dataValidate = this.registerService.getValidateData();
      if (dataValidate) {
        this.basicDataForm.controls['tipoDocumentoId'].setValue(+dataValidate.TipoDocumentoId);
        this.basicDataForm.controls['numeroDocumento'].setValue(dataValidate.NumeroDocumento);
        this.basicDataForm.controls['correoElectronico'].setValue(dataValidate.CorreoElectronico);
        this.basicDataForm.controls['fechaExpedicionDocumento'].setValue(dataValidate.fechaExpedicionDocumento === undefined ? '' : this.registerService.convertSringDate(dataValidate.fechaExpedicionDocumento));
        this.basicDataForm.controls['terminosCondiciones'].setValue(dataValidate.terminosCondiciones);
        this.basicDataForm.controls['tratamientoDatosPersonales'].setValue(dataValidate.tratamientoDatosPersonales);


        this.modelExpDoc = dataValidate.fechaExpedicionDocumento;
      }
    }

    // Deja disabled los campos que vienen llenos para que no los pueda editar
    this.f['tipoDocumentoId'].disable();
    this.f['numeroDocumento'].disable();
    this.f['correoElectronico'].disable();
    this.f['signoNumero'].setValue('#'); // Por defecto este campo siempre es #
    this.f['signoNumero'].disable();
    if (this.f["paisResidenciaId"].value == 48) {
      this.f['direccionResidencia'].disable();
    }

    this.registerService.disableTabsByTab([3]);

    this.listNombreCampos = this.registerService.getListNombresCamposForm();
 
  }

  /**
   * Funcion que recibe un boolean para identificar si devuelve 1, 0 o null
   */
  getValueBooleanForm(value: boolean): boolean | number | null {
    let response = null;
    if (value === true) {
      response = 1;
    }
    if (value === false) {
      response = 0;
    }
    return response;
  }

  getlocalidadComuna(municipioId: string){
    this.localidadesComuna=[];
    let $localidades = this.parametricosService.getParametricos(
          PARAMETRICOS.LOCALIDAD,
          PARAMETRICOS_FILTROS.LOCALIDAD__MUNICIPIO_ID,
          municipioId
        );
    let $comunas = this.parametricosService.getParametricos(
                  PARAMETRICOS.COMUNA,
                  PARAMETRICOS_FILTROS.COMUNA__MUNICIPIO_ID,
                  municipioId
                );
    forkJoin([$localidades,$comunas]).subscribe(([data1, data2]) => {
      this.localidadesComuna = [...data1,...data2].map(function (element) {
          return { id: element.id, nombre: element.nombre }
        });
      });
  }

  /**
   * Función que invoca el servicio para consultar al API los tipos de documentos
   */
  getTipoDocumentos() {
    // Si existen los parametricos de tipo documento
    const listTipoDocumentoStorage = this.parametricosService.getDataKeyParametricosStorage('TipoDocumento');
    if (listTipoDocumentoStorage !== undefined) {
      // Llena el listado de tipos documento con lo registrado en el storage
      this.listTipoDocumento = listTipoDocumentoStorage;
    } else {
      this.showLoading = true;
      this.parametricosService.getParametricosDefault('TipoDocumento').subscribe((response) => {
        this.listTipoDocumento = response.map(function (element) {
          return { id: element.id, nombre: element.nombre, sigla: element.sigla, principal: element.principal }
        });
        setTimeout(() => { this.showLoading = false; }, 300);
      });
    }
  }
  /**
   * Función que invoca el servicio para consultar al API el listado generos
   */
  getGeneros() {
    // Consulta si existen los parametricos de Genero
    const listGeneroStorage = this.parametricosService.getDataKeyParametricosStorage('Genero');
    if (listGeneroStorage !== undefined) {
      // Llena el listado de generos con lo registrado en el storage
      this.listGeneros = listGeneroStorage;
    } else {
      this.showLoading = true;
      this.parametricosService.getParametricosDefault('Genero').subscribe((response) => {
        this.listGeneros = response.map(function (element) {
          return { id: element.id, nombre: element.nombre }
        });

        // Consume servicio para añadir parametrico en el storage
        this.parametricosService.addParametricoSessionStorage('Genero', this.listGeneros);
        setTimeout(() => { this.showLoading = false; }, 300);
      });
    }
  }
  /**
   * Función que invoca el servicio para consultar al API el listado de paises
   */
  getPaises() {
    // Consulta si existen los parametricos de Paises
    const listPaisStorage = this.parametricosService.getDataKeyParametricosStorage('Pais');
    if (listPaisStorage !== undefined) {
      // Llena el listado de Paises con lo registrado en el storage
      this.listPaises = listPaisStorage;
      // Si no hay país seleccionado entonces por defecto deja Colombia
      if (this.f['paisResidenciaId'].value == null) {
        const paisColombia: any = this.listPaises.find(element => element.nombre.toLocaleLowerCase() == 'colombia');
        this.f['paisResidenciaId'].setValue(paisColombia.id);
        this.f['paisResidenciaId'].updateValueAndValidity();

        setTimeout(() => {
          // Consulta los prestadores
          this.getPrestadores(this.f['paisResidenciaId'].value);
        }, 500);
      }
    } else {
      this.showLoading = true;
      this.parametricosService.getParametricosDefault('Pais').subscribe((response) => {
        this.listPaises = response.map(function (element) {
          return { id: element.id, nombre: element.nombre.toUpperCase() }
        });

        // Consume servicio para añadir parametrico en el storage
        this.parametricosService.addParametricoSessionStorage('Pais', this.listPaises);
        setTimeout(() => {
          this.showLoading = false;
          // Si no hay país seleccionado entonces por defecto deja Colombia
          if (this.f['paisResidenciaId'].value == null) {
            const paisColombia: any = this.listPaises.find(element => element.nombre.toLocaleLowerCase() == 'colombia');
            this.f['paisResidenciaId'].setValue(paisColombia.id);
            this.f['paisResidenciaId'].updateValueAndValidity();

            // Consulta los prestadores
            this.getPrestadores(this.f['paisResidenciaId'].value);
          }
        }, 300);
      });
    }
  }
  /**
   * Función que invoca el servicio para consultar al API el listado de departamentos
   */
  getDepartamentos() {
    // Consulta si existen los parametricos de Departamentos
    const listDepartamentoStorage = this.parametricosService.getDataKeyParametricosStorage('Departamento');
    if (listDepartamentoStorage !== undefined) {
      this.listDepartamentos = listDepartamentoStorage;
    } else {
      this.showLoading = true;
      this.parametricosService.getParametricosDefault('Departamento').subscribe((response) => {
        this.listDepartamentos = response.map(function (element) {
          return { id: element.id, nombre: element.nombre }
        });

        // Consume servicio para añadir parametrico en el storage
        this.parametricosService.addParametricoSessionStorage('Departamento', this.listDepartamentos);
        setTimeout(() => { this.showLoading = false; }, 300);
      });
    }
  }
  /**
   * Función que invoca el servicio para consultar al API el listado de preguntas de seguridad
   */
  getPreguntasSeguridad() {
    // Consulta si existen los parametricos de Preguntas de seguridad
    const listPreguntaSeguridadStorage = this.parametricosService.getDataKeyParametricosStorage('PreguntaSeguridad');
    if (listPreguntaSeguridadStorage !== undefined) {
      // Llena el listado de Preguntas de Seguridad con lo registrado en el storage
      this.listPreguntasSeguridad = listPreguntaSeguridadStorage;
    } else {
      this.showLoading = true;
      this.parametricosService.getParametricosDefault('PreguntaSeguridad').subscribe((response) => {
        this.listPreguntasSeguridad = response.map(function (element) {
          return { id: element.id, nombre: element.nombre }
        });       
        // Consume servicio para añadir parametrico en el storage
        this.parametricosService.addParametricoSessionStorage('PreguntaSeguridad', this.listPreguntasSeguridad);
        setTimeout(() => { this.showLoading = false; }, 300);
      });
    }
  }
  /**
   * Función que invoca el servicio para consultar al API el listado de prestadores de preferencia
   */
  getPrestadores(pais: string) {
    const paisColombia: any = this.listPaises.find(element => element.nombre.toLocaleLowerCase() == 'colombia');
    // Consulta si existen los parametricos de Prestadores
    const listPrestadorStorage = this.prestadorService.getPrestadoresStorage
    if (listPrestadorStorage.length !== 0) {
      // Llena el listado de Prestadores con lo registrado en el storage pero según el pais
      if (pais !== paisColombia.id) {
        this.listPrestadoresPreferencia = listPrestadorStorage.filter(prest => prest.coberturaNacional === true);
      }
    } else {
      this.showLoading = true;
      this.prestadorService.getPrestadoresByDepto(0).subscribe((response) => {
        // Carga los prestadores pero según el pais
        if (pais !== paisColombia.id) {
          this.listPrestadoresPreferencia = response.filter(prest => prest.coberturaNacional === true);
        }

        // Consume servicio para añadir parametrico en el storage
        this.prestadorService.setPrestadoresStorage(response);
        setTimeout(() => { this.showLoading = false; }, 1000);
      });
    }
  }
  /**
   * Función que invoca el servicio para consultar al API o storage el listado de puntos de atencion
   */
  getPuntosAtencion() {
    // Consulta si existen los parametricos de Puntos de atencion
    const listPuntoAtencionStorage = this.prestadorService.getPuntosAtencionStorage;
    if (listPuntoAtencionStorage.length === 0) {
      this.showLoading = true;
      this.prestadorService.getPuntosAtencionByPrestador('00000000-0000-0000-0000-000000000000').subscribe((response) => {
        const responsePuntosAtencion = response;

        // Consume servicio para añadir parametrico en el storage
        this.prestadorService.setPuntosAtencionStorage(responsePuntosAtencion);
        setTimeout(() => { this.showLoading = false; }, 1000);
      });
    }
  }
  /**
   * Función que invoca el servicio para consultar al API o storage el listado de Municipios
   */
  getMunicipios() {
    // Consulta si existen los parametricos de Municipios
    const listMunicipioStorage = this.parametricosService.getDataKeyParametricosStorage('Municipio');
    if (listMunicipioStorage === undefined) {
      this.showLoading = true;
      this.parametricosService.getParametricoById('Municipio', 'departamentoID', '0').subscribe((response) => {
        const responseMunicipios = response.map(function (element) {
          return { id: element.id, nombre: element.nombre, departamentoId: element.departamentoId }
        });

        // Consume servicio para añadir parametrico en el storage
        this.parametricosService.addParametricoSessionStorage('Municipio', responseMunicipios);
        this.showLoading = false;
        setTimeout(() => { this.showLoading = false; }, 1000);
      });
    }
  }
  /**
   * Función que controla el evento de cambio sobre el campo pais para realizar algunas validaciones
   * @param e event
   */
  changePais(e: any) {
    const pais = e == null ? this.f['paisResidenciaId'].value : e.target.value;
    const paisSeleccionado: any = this.listPaises.find(element => element.id == pais);
    this.f['departamentoResidenciaId'].clearValidators();
    this.f['municipioResidenciaId'].clearValidators();
    this.f['perteneceARural'].clearValidators();
    this.f['telefono'].clearValidators();
    this.f['otroTelefono'].clearValidators();
    this.f['estado'].clearValidators();
    this.f['ciudad'].clearValidators();

    // Sólo si el cambio del campo se genera desde el html entonces vacia algunos campos
    if (e !== null) {
      this.f['direccionResidencia'].setValue('');
      this.f['codigoPostal'].setValue('');
      this.f['telefono'].setValue('');
      this.f['otroTelefono'].setValue('');
      this.f['perteneceARural'].setValue('');
      this.f['prestadorPreferenciaId'].setValue('');
      this.f['puntoAtencionId'].setValue('');
      this.f['estado'].setValue('');
      this.f['ciudad'].setValue('');
      this.listMunicipios = [];
      this.listPrestadoresPreferencia = [];
      this.listPuntosAtencion = [];
    }

    // Valida el pais seleccionado
    // Si es Colombia entonces muestra los campos departamento y municipio (deben ser requeridos)
    if (paisSeleccionado.nombre.toLocaleLowerCase() == 'colombia') {
      this.f['departamentoResidenciaId'].addValidators(Validators.required);
      this.f['municipioResidenciaId'].addValidators(Validators.required);
      this.f['perteneceARural'].addValidators(Validators.required);
      this.countMinDigit = 10; // Setea la cantidad de dígitos mínimos para el campo telefono en caso de ser Colombia
      this.showDepartamento = true;
      this.showMunicipio = true;
      this.validateDireccion(true);
    } else {
      this.f['departamentoResidenciaId'].setValue('');
      this.f['municipioResidenciaId'].setValue('');
      this.f['estado'].addValidators(Validators.required);
      this.f['ciudad'].addValidators(Validators.required);
      this.countMinDigit = 7; // Setea la cantidad de dígitos mínimos para el campo telefono
      this.showDepartamento = false;
      this.showMunicipio = false;
      this.validateDireccion(false);
      // Al no existir departamento entonces filtra el listado de prestadores con respecto a cobertura nacional
      const listPrestadorStorage: Prestador[] = this.prestadorService.getPrestadoresStorage;
      this.listPrestadoresPreferencia = listPrestadorStorage.filter(prest => prest.coberturaNacional === true);
    }

    this.f['telefono'].addValidators([Validators.minLength(this.countMinDigit), Validators.maxLength(10), this.validateTelefonoCel.bind(this)]);
    this.setRequiredControlTelefono();
    this.f['otroTelefono'].addValidators([Validators.minLength(this.countMinDigit), Validators.maxLength(10), this.validateTelefono.bind(this)]);
    this.setRequiredControlOtroTelefono();

    this.f['departamentoResidenciaId'].updateValueAndValidity();
    this.f['municipioResidenciaId'].updateValueAndValidity();
    this.f['telefono'].updateValueAndValidity();
    this.f['otroTelefono'].updateValueAndValidity();
    this.f['direccionResidencia'].updateValueAndValidity();
    this.f['prestadorPreferenciaId'].updateValueAndValidity();
    this.f['puntoAtencionId'].updateValueAndValidity();
    this.f['perteneceARural'].updateValueAndValidity();
    this.f['estado'].updateValueAndValidity();
    this.f['ciudad'].updateValueAndValidity();
  }
  /**
   * Función que controla el evento de cambio sobre el campo departamento y lanza la petición para consultar los municipios
   * @param e event
   */
  changeDepartamento(e: any) {
    this.showLoading = true;
    const depto = e == null ? this.f['departamentoResidenciaId'].value : e.target.value;

    // Filtra el listado de municipios con respecto al departamento
    const listMunicipioStorage = this.parametricosService.getDataKeyParametricosStorage('Municipio');
    this.listMunicipios = listMunicipioStorage.filter(muni => muni.departamentoId == depto);

    // Filtra el listado de prestadores con respecto al departamento
    const listPrestadorStorage: Prestador[] = this.prestadorService.getPrestadoresStorage;
    this.listPrestadoresPreferencia = listPrestadorStorage.filter(prest => prest.departamentoId == depto);

    this.showLoading = false;
    // Vacia value de municipio y prestador solo si no es change del campo
    if (e !== null) {
      this.f['municipioResidenciaId'].setValue('');
      this.f['municipioResidenciaId'].updateValueAndValidity();
      this.f['prestadorPreferenciaId'].setValue('');
      this.f['prestadorPreferenciaId'].updateValueAndValidity();
      this.f['puntoAtencionId'].setValue('');
      this.f['puntoAtencionId'].updateValueAndValidity();
      this.listPuntosAtencion = [];
      this.resetFieldsDireccion(true);
      this.f['direccionResidencia'].updateValueAndValidity();
      this.f['perteneceARural'].setValue('');

      this.f['localidadComunaId'].setValue(null);
      this.f['localidadComunaId'].updateValueAndValidity();  
      this.f['barrioResidencia'].setValue(null);
      this.f['barrioResidencia'].updateValueAndValidity();  
      this.localidadesComuna=[];
    }
  }
  /**
   * Función que controla el evento de cambio sobre el campo municipios para aplicar algunas validaciones
   */
  changeMunicipios(e: any) {
    const muni = e == null ? this.f['municipioResidenciaId'].value : e.target.value;
    // Vacia value de municipio y prestador solo si no es change del campo
    if (e !== null) {
      this.resetFieldsDireccion(true);
      this.f['direccionResidencia'].updateValueAndValidity();
      this.f['perteneceARural'].setValue('');
    }

    this.getlocalidadComuna(muni);
  }
  /**
   * Función que controla el evento de cambio sobre el campo prestador de preferencia y lanza la petición para consultar los puntos de atención relacionados
   * @param e event
   */
  changePrestador(e: any) {
    this.showLoading = true;
    const prestador = e == null ? this.f['prestadorPreferenciaId'].value : e.target.value;

    // Filtra el listado de puntos de atencion con respecto al prestador de preferencia
    const listPuntoAtencionStorage = this.prestadorService.getPuntosAtencionStorage;
    this.listPuntosAtencion = listPuntoAtencionStorage.filter(punto => punto.prestadorId == prestador);

    this.showLoading = false;
    // Vacia value de puntos de atencion solo si no viene de cambiar el prestador
    if (e !== null) {
      this.f['puntoAtencionId'].setValue('');
      this.f['puntoAtencionId'].updateValueAndValidity();
    }
  }
  changePregunta(e: any) {
    // Vacia value de respuesta si hay cambio en la pregunta
    if (e !== null) {
      this.f['preguntaSeguridadRespuesta'].setValue('');
      this.f['preguntaSeguridadRespuesta'].updateValueAndValidity();
    }

    const pregunta = this.f['preguntaSeguridadId'].value;
    if(pregunta==="1"){
      this.f['preguntaLibre'].addValidators([Validators.required,Validators.minLength(6)]);
      this.f['preguntaLibre'].setValue('');
      this.f['preguntaLibre'].updateValueAndValidity(); 
    }else{
      this.f['preguntaLibre'].setValidators(null);
      this.f['preguntaLibre'].setValue('');
      this.f['preguntaLibre'].updateValueAndValidity(); 
    }

  }

  cambioPerteneceA() {
    this.f['perteneceARural'].valueChanges.subscribe(
      pertenece => {
        if (pertenece !== '' && pertenece !== null && pertenece !== undefined) {
          // Si pertenece a urbano entonces pone requeridos los campos de direccion
          if (pertenece === '0') {
            setTimeout(() => {
              this.validateDireccion(true);
            }, 800);
          } else if (pertenece === '1') {
            // Acá pertenece a Rural
            setTimeout(() => {
              this.validateDireccion(false);
            }, 800);
          }
        }
      }
    );
  }

  isWeekend(date: NgbDateStruct) {
    const d = new Date(date.year, date.month - 1, date.day);
    return d.getDay() === 0 || d.getDay() === 6;
  }

  isDisabled(date: NgbDateStruct, current: { month: number }) {
    return date.month !== current.month;
  }

  /**
   * Función del submit del formulario continuar con el proceso al siguiente paso
   */
  saveAction() {
    this.submitted = true;
    // Valida si el formuario ya contiene los campos requeridos
    if (this.basicDataForm.valid) {
      this.basicDataForm.disable();
      let formDataSend: CreateRequest = this.basicDataForm.value;
      formDataSend.perteneceARural = this.f['perteneceARural'].value == 1 ? true : false;
      // Agrega Direccion como arreglo
      formDataSend.direcciones = this.buildDireccion();
      // Debe ir al siguiente paso
      setTimeout(() => {
        this.showLoading = false;
        // Transforma el nombre a mayúsculas
        this.f['primerNombre'].setValue(this.f['primerNombre'].value.toUpperCase());
        this.f['segundoNombre'].setValue(this.f['segundoNombre'].value.toUpperCase());
        this.f['primerApellido'].setValue(this.f['primerApellido'].value.toUpperCase());
        this.f['segundoApellido'].setValue(this.f['segundoApellido'].value.toUpperCase());
        this.registerService.putRegisterData(formDataSend, 'register');
        this.registerService.changeShowAddNotifications();
      }, 1000);
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
    return this.basicDataForm.controls;
  }
  // Funciones getter para validaciones de la contraseña
  get passwordValid() {
    return this.basicDataForm.controls["password"].errors === null;
  }
  get requiredValid() {
    return !this.basicDataForm.controls["password"].hasError("required");
  }
  get minLengthValid() {
    return !this.basicDataForm.controls["password"].hasError("minlength");
  }
  get maxLengthValid() {
    return !this.basicDataForm.controls["password"].hasError("maxlength");
  }
  get requiresDigitValid() {
    return !this.basicDataForm.controls["password"].hasError("requiresDigit");
  }
  get requiresUppercaseValid() {
    return !this.basicDataForm.controls["password"].hasError("requiresUppercase");
  }
  get requiresLowercaseValid() {
    return !this.basicDataForm.controls["password"].hasError("requiresLowercase");
  }
  get requiresSpecialCharsValid() {
    return !this.basicDataForm.controls["password"].hasError("requiresSpecialChars");
  }

  /**
   * Función que se encarga de hacer el toggle de show de un campo tipo password
   * @param controlP string que identifica el control o campo de contraseña
   */
  toggleShowPassword(controlP: string) {
    if (controlP == 'password') {
      this.showPassword = !this.showPassword;
    }
    if (controlP == 'confirmPassword') {
      this.showPasswordConfirm = !this.showPasswordConfirm;
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

    // Sólo modifica validaciones de teléfonos si el control contiene 'telefono'
    if (control.includes("elefono")) {
      // Setea el requerido de los campos telefono
      const otherControl = control === 'telefono' ? 'otroTelefono' : 'telefono';

      if (number == '') {
        // Vacio
        this.f[otherControl].addValidators([Validators.required]);
        if (this.f[otherControl].value == '' || this.f[otherControl].value == null) {
          this.f[control].addValidators([Validators.required]);
        }
      } else {
        // Lleno
        // si agregan teléfono entonces el otro lo deja no requerido
        this.f[otherControl].removeValidators([Validators.required]);
      }
      this.f[otherControl].updateValueAndValidity();
    }

    this.f[control].updateValueAndValidity();
  }

  /**
   * Función que valida sobre un input (control) que sólo sean letras
   */
  validateOnlyLetters(evt: any, control: string) {
    var regex = new RegExp("^[a-zA-Z\u00C0-\u017F\\s+]+$");
    if (!regex.test(evt.target.value)) {
      this.f[control].setValue(evt.target.value.substr(0, evt.target.value.length - 1));
    }
  }

  /**
   * Función que realiza algunas validaciones custom sobre el campo telefono celular
   * Si el país de residencia seleccionado es colombia:
   * - El primer número digitado debe ser 3.
   * - Siempre de 10 digitos
   * Si el país de residencia es diferente a Colombia no se restringe el ingreso.
   * - Solo restringir a mínimo 7 y máximo 10 digitos
   */
  validateTelefonoCel(control: AbstractControl) {
    if (control.value !== null && control.value !== '') {
      const pais = this.f['paisResidenciaId'].value;
      // Valida si el campo pais tiene algún valor y el listado de paises está lleno
      if (pais != null && this.listPaises.length > 0) {
        const paisSeleccionado: any = this.listPaises.find(element => element.id == pais);
        const firstDigit = control.value.substr(0, 1);

        if (paisSeleccionado.nombre.toLocaleLowerCase() == 'colombia' && firstDigit != '3') {
          return { firstDigit: true };
        }
      }
    }
    return null;
  }
  get telefonoRequired() {
    return this.f['telefono'].hasError("required");
  }
  get telefonoMinLength() {
    return this.f['telefono'].hasError("minlength");
  }
  get telefonoMaxLength() {
    return this.f['telefono'].hasError("maxlength");
  }
  get firstDigitValid() {
    return this.f['telefono'].hasError("firstDigit");
  }

  /**
   * Función que realiza algunas validaciones custom sobre el campo telefono fijo
   * Si el país de residencia seleccionado es colombia:
   * - El primer número digitado debe ser 6
   * - Siempre de 10 digitos
   * Si el país de residencia es diferente a Colombia no se restringe el ingreso.
   * - Solo restringir a mínimo 7 y máximo 10 digitos
   */
  validateTelefono(control: AbstractControl) {
    if (control.value !== null && control.value !== '') {
      const pais = this.f['paisResidenciaId'].value;
      // Valida si el campo pais tiene algún valor y el listado de paises está lleno
      if (pais != null && this.listPaises.length > 0) {
        const paisSeleccionado: any = this.listPaises.find(element => element.id == pais);
        const firstDigit = control.value.substr(0, 1);

        if (paisSeleccionado.nombre.toLocaleLowerCase() == 'colombia' && firstDigit != '6') {
          return { firstDigit: true };
        }
      }
    }
    return null;
  }
  get otroTelefonoRequired() {
    return this.f['otroTelefono'].hasError("required");
  }
  get otroTelefonoMinLength() {
    return this.f['otroTelefono'].hasError("minlength");
  }
  get otroTelefonoMaxLength() {
    return this.f['otroTelefono'].hasError("maxlength");
  }
  get otroTelefonoFirstDigitValid() {
    return this.f['otroTelefono'].hasError("firstDigit");
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

  /**
   * Función que restringe el pegado de información en el campo Confrimacion contraseña
   */
  onPasteConfirmPassword(event: ClipboardEvent) {
    event.preventDefault();
  }

  /**
   * Función que controla el evento lost focus del campo contraseña para validar el de confirmar contraseña
   */
  lostFocusValidateConfirmPassword(event: any) {
    this.f['confirmPassword'].updateValueAndValidity();
  }

  setRequiredControlTelefono() {
    const telefono = this.f['telefono'].value;
    const otroTelefono = this.f['otroTelefono'].value;

    if ((telefono == null || telefono == '') && (otroTelefono == null || otroTelefono == '')) {
      this.f['telefono'].addValidators(Validators.required);
    }
  }
  setRequiredControlOtroTelefono() {
    const telefono = this.f['telefono'].value;
    const otroTelefono = this.f['otroTelefono'].value;

    if ((telefono == null || telefono == '') && (otroTelefono == null || otroTelefono == '')) {
      this.f['otroTelefono'].addValidators(Validators.required);
    }
  }

  /**
   * Funciones para la lógica CRUD de los complementos
   */
  addComplement() {
    const modalComplemento = this.modalService.open(ComplementosDireccionModalComponent, {
      size: 'md', backdrop: 'static', animation: true
    });
    modalComplemento.result.then(response => {
      if (response != null) {
        this.arrComplementos.push(response);
        this.concatDireccionResidencia(null);
      }
    });
  }
  deleteComplement(complemento: Complemento) {
    this.arrComplementos.splice(this.arrComplementos.findIndex(c => c == complemento), 1);
    this.concatDireccionResidencia(null);
  }

  buildDireccion() {
    if (this.f['paisResidenciaId'].value == 48 && this.f['perteneceARural'].value == 0) {
      return [
        {
          id: null,
          viaPrincipalId: this.f['viaPrincipalId'].value,
          viaPrincipalNombre: this.listViaPrincipal[this.listViaPrincipal.findIndex(v => v.id == this.f['viaPrincipalId'].value)].texto,
          viaPrincipal: this.f['viaPrincipal'].value,
          viaPrincipalLetraId: this.f['viaPrincipalLetraId'].value,
          viaPrincipalLetraNombre: this.f['viaPrincipalLetraId'].value,
          viaPrincipalBisId: this.f['viaPrincipalBisId'].value,
          viaPrincipalBisNombre: this.f['viaPrincipalBisId'].value,
          viaPrincipalSegundaLetraId: this.f['viaPrincipalSegundaLetraId'].value,
          viaPrincipalSegundaLetraNombre: this.f['viaPrincipalSegundaLetraId'].value,
          viaPrincipalCuadranteId: this.f['viaPrincipalCuadranteId'].value,
          viaPrincipalCuadranteNombre: this.f['viaPrincipalCuadranteId'].value,
          viaGeneradora: this.f['viaGeneradora'].value,
          viaGeneradoraLetraId: this.f['viaGeneradoraLetraId'].value,
          viaGeneralLetraNombre: this.f['viaGeneradoraLetraId'].value,
          viaGeneradoraPlaca: this.f['viaGeneradoraPlaca'].value,
          viaGeneradoraCuadranteId: this.f['viaGeneradoraCuadranteId'].value,
          viaGeneradoraCuadranteNombre: this.f['viaGeneradoraCuadranteId'].value,
          direccionComplemento: this.arrComplementos
        }
      ];
    } else {
      return [];
    }
  }

  setFieldsDireccion(data: any) {
    const direccion = data.direcciones[0];
    this.f['viaPrincipalId'].setValue(direccion?.viaPrincipalId);
    this.f['viaPrincipalNombre'].setValue(direccion?.viaPrincipalNombre);
    this.f['viaPrincipal'].setValue(direccion?.viaPrincipal);
    this.f['viaPrincipalLetraId'].setValue(direccion?.viaPrincipalLetraId);
    this.f['viaPrincipalLetraNombre'].setValue(direccion?.viaPrincipalLetraNombre);
    this.f['viaPrincipalBisId'].setValue(direccion?.viaPrincipalBisId);
    this.f['viaPrincipalBisNombre'].setValue(direccion?.viaPrincipalBisNombre);
    this.f['viaPrincipalSegundaLetraId'].setValue(direccion?.viaPrincipalSegundaLetraId);
    this.f['viaPrincipalSegundaLetraNombre'].setValue(direccion?.viaPrincipalSegundaLetraNombre);
    this.f['viaPrincipalCuadranteId'].setValue(direccion?.viaPrincipalCuadranteId);
    this.f['viaPrincipalCuadranteNombre'].setValue(direccion?.viaPrincipalCuadranteNombre);
    this.f['viaGeneradora'].setValue(direccion?.viaGeneradora);
    this.f['viaGeneradoraLetraId'].setValue(direccion?.viaGeneradoraLetraId);
    this.f['viaGeneralLetraNombre'].setValue(direccion?.viaGeneralLetraNombre);
    this.f['viaGeneradoraPlaca'].setValue(direccion?.viaGeneradoraPlaca);
    this.f['viaGeneradoraCuadranteId'].setValue(direccion?.viaGeneradoraCuadranteId);
    this.f['viaGeneradoraCuadranteNombre'].setValue(direccion?.viaGeneradoraCuadranteNombre);
    // Recorre los complementos de la direccion para insetarlos en el arreglo
    for (const key in direccion?.direccionComplemento) {
      if (Object.prototype.hasOwnProperty.call(direccion?.direccionComplemento, key)) {
        const element: Complemento = direccion?.direccionComplemento[+key] as Complemento;
        this.arrComplementos.push(element);
      }
    }
  }
  
  /**
   * Función que recibe un boolean para setear las validaciones de la direccion
   */
  validateDireccion(validate: boolean, clearControlDireccion: boolean = false) {
    this.f['viaPrincipalId'].clearValidators();
    this.f['viaPrincipal'].clearValidators();
    this.f['viaGeneradora'].clearValidators();
    this.f['viaGeneradoraPlaca'].clearValidators();
    this.f['localidadComunaId'].clearValidators();
    this.f['barrioResidencia'].clearValidators();
    

    if (validate) {
      this.showFieldsDireccion = true;
      this.f['direccionResidencia'].disable();
      this.f['viaPrincipalId'].addValidators([Validators.required]);
      this.f['viaPrincipal'].addValidators([Validators.required]);
      this.f['viaGeneradora'].addValidators([Validators.required]);
      this.f['viaGeneradoraPlaca'].addValidators([Validators.required]);
      this.f['barrioResidencia'].addValidators([Validators.required]);
      if(this.localidadesComuna.length>0)
      this.f['localidadComunaId'].addValidators([Validators.required]);
    } else {
      this.showFieldsDireccion = false;
      this.f['direccionResidencia'].enable();
      this.resetFieldsDireccion();
    }
    // Setea vacia la direccion si llega el parámetro a la función
    if (clearControlDireccion) {
      this.f['direccionResidencia'].setValue('');
    }

    this.f['viaPrincipalId'].updateValueAndValidity();
    this.f['viaPrincipal'].updateValueAndValidity();
    this.f['viaGeneradora'].updateValueAndValidity();
    this.f['viaGeneradoraPlaca'].updateValueAndValidity();
    this.f['localidadComunaId'].updateValueAndValidity();
    this.f['barrioResidencia'].updateValueAndValidity();
  }
  /**
   * Función que setea a vacío los valores de los campos de la direccion
   */
  resetFieldsDireccion(clearControlDireccion: boolean = false) {
    this.f['viaPrincipalId'].setValue('');
    this.f['viaPrincipalNombre'].setValue('');
    this.f['viaPrincipal'].setValue('');
    this.f['viaPrincipalLetraId'].setValue('');
    this.f['viaPrincipalLetraNombre'].setValue('');
    this.f['viaPrincipalBisId'].setValue('');
    this.f['viaPrincipalBisNombre'].setValue('');
    this.f['viaPrincipalSegundaLetraId'].setValue('');
    this.f['viaPrincipalSegundaLetraNombre'].setValue('');
    this.f['viaPrincipalCuadranteId'].setValue('');
    this.f['viaPrincipalCuadranteNombre'].setValue('');
    this.f['viaGeneradora'].setValue('');
    this.f['viaGeneradoraLetraId'].setValue('');
    this.f['viaGeneralLetraNombre'].setValue('');
    this.f['viaGeneradoraPlaca'].setValue('');
    this.f['viaGeneradoraCuadranteId'].setValue('');
    this.f['viaGeneradoraCuadranteNombre'].setValue('');
    this.f['codigoPostal'].setValue('');
    this.f['barrioResidencia'].setValue('');
    this.arrComplementos = [];

    // Setea vacia la direccion si llega el parámetro a la función
    if (clearControlDireccion) {
      this.f['direccionResidencia'].setValue('');
    }
  }
  concatDireccionResidencia(e: any) {
    // Concatena los campos de la dirección en el mismo orden y cada vez q haya algún cambio en los campos
    const viaPrincipalId = (this.f['viaPrincipalId'].value == null) ? '' : ' ' + this.f['viaPrincipalId'].value;
    const viaPrincipal = (this.f['viaPrincipal'].value == null) ? '' : ' ' + this.f['viaPrincipal'].value;
    const viaPrincipalLetraId = (this.f['viaPrincipalLetraId'].value == null) ? '' : ' ' + this.f['viaPrincipalLetraId'].value;
    const viaPrincipalBisId = (this.f['viaPrincipalBisId'].value == null) ? '' : ' ' + this.f['viaPrincipalBisId'].value;
    const viaPrincipalSegundaLetraId = (this.f['viaPrincipalSegundaLetraId'].value == null) ? '' : ' ' + this.f['viaPrincipalSegundaLetraId'].value;
    const viaPrincipalCuadranteId = (this.f['viaPrincipalCuadranteId'].value == null) ? '' : ' ' + this.f['viaPrincipalCuadranteId'].value;
    const signoNumero = (this.f['signoNumero'].value == null) ? '' : ' ' + this.f['signoNumero'].value;
    const viaGeneradora = (this.f['viaGeneradora'].value == null) ? '' : ' ' + this.f['viaGeneradora'].value;
    const viaGeneradoraLetraId = (this.f['viaGeneradoraLetraId'].value == null) ? '' : ' ' + this.f['viaGeneradoraLetraId'].value;
    const viaGeneradoraPlaca = (this.f['viaGeneradoraPlaca'].value == null) ? '' : ' ' + this.f['viaGeneradoraPlaca'].value;
    const viaGeneradoraCuadranteId = (this.f['viaGeneradoraCuadranteId'].value == null) ? '' : ' ' + this.f['viaGeneradoraCuadranteId'].value;
    // Concatena el string
    let strDireccion = viaPrincipalId + viaPrincipal + viaPrincipalLetraId + viaPrincipalBisId + viaPrincipalSegundaLetraId + viaPrincipalCuadranteId +
      signoNumero + viaGeneradora + viaGeneradoraLetraId + viaGeneradoraPlaca + viaGeneradoraCuadranteId;
    // Le agrega los complementos agregados
    if (this.arrComplementos.length > 0) {
      for (const cpto in this.arrComplementos) {
        if (this.arrComplementos.hasOwnProperty.call(this.arrComplementos, cpto)) {
          const element = this.arrComplementos[cpto];
          if (element != undefined) {
            strDireccion += ` - ${element.complementoId} ${element.complemento}`;
          }
        }
      }
    }
    this.f['direccionResidencia'].setValue(strDireccion);
  }

  /**
   * Función que valida al momento de llenado del campo si agregaron algún caracter espcial o tildes para no
   */
  validateViaPrincipal (evt: any) {
    const code = (evt.which) ? evt.which : evt.keyCode;
    const text = evt.target.value;
    let out = '';

    if (code != 8) { // backspace.
      out = text.replace(/[^a-zA-Z0-9 ñÑ]/g, '');
      this.f["viaPrincipal"].setValue(out);
    }
  }

  getListErrorsForm(): string[] {
    const list: string[] = [];
    Object.keys(this.f).forEach(key => {
      const controlErrors = this.basicDataForm.get(key)?.errors;
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
