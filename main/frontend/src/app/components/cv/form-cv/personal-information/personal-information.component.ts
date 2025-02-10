import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { AbstractControl, FormArray, FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { NgbActiveModal, NgbDatepickerI18n, NgbDateStruct, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Observable, forkJoin, of, switchMap, tap } from 'rxjs';

import { PARAMETRICOS, ParametricosService, PARAMETRICOS_FILTROS } from "../../../../services/parametricos.service";
import { PrestadorService } from "../../../../services/prestador.service";
import { CvService } from "../../../../services/cv.service";
import { CustomDatepickerI18nService, I18n } from "src/app/services/custom-datepicker-i18n.service";
import { CiudadanoService } from "src/app/services/ciudadano.service";

import { ParametricoListado, Parametrico } from "../../../../model/parametricos";
import { CiudadanoGet, Complemento } from "../../../../model/ciudadano";
import { ModalValidationFormComponent } from "src/app/shared/components/modal-validation-form/modal-validation-form.component";
import { ModalSuccessFormComponent } from "src/app/shared/components/modal-success-form/modal-success-form.component";
import { ModalErrorFormComponent } from "src/app/shared/components/modal-error-form/modal-error-form.component";
import { ComplementosModalComponent } from "./complementos-modal/complementos-modal.component";

import { EmitType } from '@syncfusion/ej2-base';
import { Query, DataManager, WebApiAdaptor, } from '@syncfusion/ej2-data';
import { FilteringEventArgs } from '@syncfusion/ej2-dropdowns';

@Component({
  selector: 'app-personal-information',
  templateUrl: './personal-information.component.html',
  styleUrls: ['./personal-information.component.css'],
  providers: [I18n, { provide: NgbDatepickerI18n, useClass: CustomDatepickerI18nService }]
})
export class PersonalInformationComponent implements OnInit {

  ciudadano!: CiudadanoGet | null;
  iniciando: boolean = true;

  personalInformationForm!: FormGroup;
  submitted: boolean = false;
  showLoading: boolean = false;
  showDepartamento: boolean = true;
  showMunicipio: boolean = true;
  showBarrio: boolean = true;
  showDepartamentoN: boolean = true;
  showMunicipioN: boolean = true;
  showCatLicenciaCarro: boolean = true;
  showCatLicenciaMoto: boolean = true;
  showDni: boolean = false;
  showPoblacionFocalizada: boolean = false;
  showTieneLibreta: boolean = true;
  showTipoNumLibreta: boolean = true;
  showFieldsDireccion: boolean = true;
  date: { year: number; month: number; } | undefined;
  minDate = { year: 1900, month: 1, day: 1 };
  maxDate: { year: number; month: number; day: number };
  maxDateHoy: { year: number; month: number; day: number };
  model: NgbDateStruct | undefined;
  modelExpDoc: NgbDateStruct | undefined;
  countMinDigit: number = 10;
  countMinDigitOtroTel: number = 10;
  paisColombia: Parametrico | undefined;
  tipoDocumentoDni: Parametrico | undefined;

  listTiposDocumento: Parametrico[] = [];
  listTiposDocumentoAdicional: Parametrico[] = [];
  listPaisesNacimiento: Parametrico[] = [];
  listDepartamentosNacimiento: Parametrico[] = [];
  $listMunicipiosNacimiento?: Observable<Parametrico[]>;
  listPaisesResidencia: Parametrico[] = [];
  listDepartamentosResidencia: Parametrico[] = [];
  $listMunicipiosResidencia?: Observable<Parametrico[]>;
  listPrestadoresPreferencia: ParametricoListado[] = [];
  listPuntosAtencion: ParametricoListado[] = [];
  listGeneros: Parametrico[] = [];
  listSexos: Parametrico[] = [];
  listCategoriaLicenciaCarro: ParametricoListado[] = [];
  listCategoriaLicenciaMoto: Parametrico[] = [];
  listNacionalidades: Parametrico[] = [];
  listViaPrincipal: { id: string, texto: string }[] = [];
  arrComplementos: Complemento[] = [];
  alphabet: string = 'abcdefghijklmnopqrstuvwxyz';
  localidadesComuna: ParametricoListado[] = new Array().fill(null);

  public tipoPoblacionControl = new FormControl('');
  public condDiscapacidadControl = new FormControl('');
  public condSaludMentalControl = new FormControl('');
  public cargoInteresControl = new FormControl('');

  public denominaciones: any[] = [];
  public denominacionesCargando: boolean= true;

  // public data: DataManager = new DataManager({
  //   url: '/api/parametrico/lista/CUOCDenominacion',
  //   adaptor: new WebApiAdaptor(),
  //   crossDomain: true,
  // });

  public onFiltering: EmitType<FilteringEventArgs> = (e: FilteringEventArgs) => {
    let query: Query = new Query().select(['nombre', 'id']);
    //frame the query based on search string with filter type.
    query = e.text !== '' ? query.where('nombre', 'contains', e.text, true) : query; 
    //pass the filter data source, filter query to updateData method.
    e.updateData(this.denominaciones, query);
  };
  


  constructor(
    public formBuilder: FormBuilder,
    public parametricosService: ParametricosService,
    public prestadorService: PrestadorService,
    public cvService: CvService,
    public ciudadanoService: CiudadanoService,
    private modalService: NgbModal,
  ) {
    this.personalInformationForm = this.formBuilder.group({
      id: [null],
      tipoDocumentoId: [null, Validators.required],
      numeroDocumento: [null, Validators.required],
      tipoDocumentoAdicionalId: [null],
      numeroDocumentoAdicional: [null],
      primerNombre: [null, [Validators.required, Validators.pattern("^[a-zA-Z\u00C0-\u017F\\s]+$")]],
      segundoNombre: [null, Validators.pattern("^[a-zA-Z\u00C0-\u017F\\s]+$")],
      primerApellido: [null, [Validators.required, Validators.pattern("^[a-zA-Z\u00C0-\u017F\\s]+$")]],
      segundoApellido: [null, Validators.pattern("^[a-zA-Z\u00C0-\u017F\\s]+$")],
      fechaNacimiento: [null, Validators.required],
      estadoCivilId: [null],
      sexoId: [null, Validators.required],
      generoId: [null, Validators.required],
      cualGenero: [null],
      orientacionSexualId: [null, Validators.required],
      cualOrientacionSexual: [null],
      tieneLibretaMilitar: [null],
      tipoLibretaMilitarId: [null],
      numeroLibretaMiltar: [null],
      paisNacimientoId: [null, Validators.required],
      nacionalidadId: [null, Validators.required],
      departamentoNacimientoId: [null, Validators.required],
      municipioNacimientoId: [null, Validators.required],
      jefeHogar: [null, Validators.required],
      poblacionFocalizada: [null, Validators.required],
      grupoEtnico: [null],
      tipoPoblacion: this.formBuilder.array([]),
      condicionDiscapacidad: new FormArray([]),
      condicionSaludMental: new FormArray([]),
      sisben: [null, Validators.required],
      epsId: [null, Validators.required],
      // Datos de contacto
      correoElectronico: [null, [Validators.required, Validators.email]],
      paisResidenciaId: [null, Validators.required],
      departamentoResidenciaId: [null, Validators.required],
      municipioResidenciaId: [null, Validators.required],
      localidadComunaId: [null],
      prestadorPreferenciaId: [null, Validators.required],
      puntoAtencionId: [null, Validators.required],
      barrioResidencia: [null, Validators.required],
      perteneceARural: [null, Validators.required],
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
      estadoNacimiento: [''],
      ciudadNacimiento: [''],
      certificadoResidencia: [null],
      observacion: [null],
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
      estrato: [null],
      // Datos de perfil laboral
      perfilLaboral: [null, [Validators.required, Validators.minLength(20), Validators.maxLength(2000)]],
      rangoSalarialId: [null, Validators.required],
      posibilidadViajar: [null],
      posibilidadTrasladarse: [null],// Validators.required
      dispuestoCambiarMunicipio: [null, Validators.required],
      dispuestoDesplazarseDiariamente: [null, Validators.required],
      interesOfertasTeletrabajo: [null, Validators.required],
      situacionLaboralActualId: [null, Validators.required],
      propiedadMedioTransporte: [null, Validators.required],
      tieneLicenciaConduccionCarro: [null, Validators.required],
      tieneLicenciaConduccionMoto: [null, Validators.required],
      categoriaLicenciaCarroId: [null, Validators.required],
      categoriaLicenciaMotoId: [null, Validators.required],
      // En que me gustaria trabajar
      cargoIneteres: this.formBuilder.array([], Validators.required)
      // cargoIneteres: [null, Validators.required]
    });
    // Define la fecha máxima del campo fecha nacimiento
    const dateNow = new Date;
    this.maxDate = { year: new Date().getFullYear() - 14, month: dateNow.getMonth() + 1, day: dateNow.getDate() };
    this.maxDateHoy = { year: new Date().getFullYear(), month: dateNow.getMonth() + 1, day: dateNow.getDate() };


    cvService.$denominaciones.subscribe(data=>{
      this.denominaciones =data;
      this.denominacionesCargando=false;
    },error=>{
      this.denominaciones =[];
      this.denominacionesCargando=false;
    })
  }

  ngOnInit(): void {
    // Cargues de paramétricos y listados
    this.getParametricos();
    // Definición cambios sobre algunos campos
    this.cambiosPaisNacimiento();
    this.cambiosDeptoNacimiento();
    this.cambiosPaisResidencia();
    this.cambiosDeptoResidencia();
    this.cambiosMunicipioResidencia();
    this.cambiosPrestador();
    this.cambioSexo();
    this.cambioTieneLibreta();
    this.cambioPerteneceA();
    this.cambiosTieneLicenciaCarro();
    this.cambiosTieneLicenciaMoto();
    this.cambiosNacionalidad();
    this.cambiosPoblacionFocalizada();
    this.cambioTipoDocAdicional();
    // this.cambiosGrupoEtnico(null);
    this.cambioTipoPoblacionForm();
    this.cambioConDiscapacidadForm();
    this.cambioConSaludMentalForm();
    

    // Deshabilita algunos campos
    this.f['tipoDocumentoId'].disable();
    this.f['numeroDocumento'].disable();
    this.f['correoElectronico'].disable();
    this.f['direccionResidencia'].disable();
    this.f['prestadorPreferenciaId'].disable();
    this.f['puntoAtencionId'].disable();
    this.f['signoNumero'].setValue('#'); // Por defecto este campo siempre es #
    this.f['signoNumero'].disable();

    // Consulta la información del storage en el servicio
    this.ciudadano = this.cvService.getCiudadano;
    if (this.ciudadano !== null) {
      const dateObjectFechaNacimiento = new Date(this.ciudadano.fechaNacimiento);
      const dateObjectFechaExpDoc = new Date(this.ciudadano.fechaExpedicionDocumento);
      // Hace patchvalue de la data del ciudadano
      this.personalInformationForm.patchValue(this.ciudadano);

      // Transforma la info de algunos campos que son arreglo de números y q van en campos syncfusion
      // Tipo poblacion
      let tipoPoblacionArrControl = this.f['tipoPoblacion'] as FormArray;
      this.ciudadano.tipoPoblacion.map((t: number) => new FormControl(t.toString())).forEach(control => tipoPoblacionArrControl.push(control));
      this.tipoPoblacionControl.setValue(this.f['tipoPoblacion'].value);
      // Condiciones de discapacidad
      let condDiscapacidadArrControl = this.f['condicionDiscapacidad'] as FormArray;
      this.ciudadano.condicionDiscapacidad.map((d: number) => new FormControl(d.toString())).forEach(control => condDiscapacidadArrControl.push(control));
      this.condDiscapacidadControl.setValue(this.f['condicionDiscapacidad'].value);
      // Condiciones de salud mental
      let condSaludMentalArrControl = this.f['condicionSaludMental'] as FormArray;
      this.ciudadano.condicionSaludMental.map((d: number) => new FormControl(d.toString())).forEach(control => condSaludMentalArrControl.push(control));
      this.condSaludMentalControl.setValue(this.f['condicionSaludMental'].value);
      // Cargo Interes
      let cargoInteresArrControl = this.f['cargoIneteres'] as FormArray;
      this.ciudadano.cargoIneteres.map((d: string) => new FormControl(d)).forEach(control => cargoInteresArrControl.push(control));
      this.cargoInteresControl.setValue(this.f['cargoIneteres'].value);

      // Luego del patchvalue se mapean algunos valores para que coincidan con los listados
      this.model = { year: dateObjectFechaNacimiento.getFullYear(), month: dateObjectFechaNacimiento.getMonth() + 1, day: dateObjectFechaNacimiento.getDate() };
      this.modelExpDoc = { year: dateObjectFechaExpDoc.getFullYear(), month: dateObjectFechaExpDoc.getMonth() + 1, day: dateObjectFechaExpDoc.getDate() };
      this.f['jefeHogar'].setValue(this.getValueBooleanForm(this.ciudadano.jefeHogar));
      this.f['dispuestoCambiarMunicipio'].setValue(this.getValueBooleanForm(this.ciudadano.dispuestoCambiarMunicipio));
      this.f['dispuestoDesplazarseDiariamente'].setValue(this.getValueBooleanForm(this.ciudadano.dispuestoDesplazarseDiariamente));
      this.f['poblacionFocalizada'].setValue(this.getValueBooleanForm(this.ciudadano.poblacionFocalizada));
      this.f['sisben'].setValue(this.getValueBooleanForm(this.ciudadano.sisben));
      this.f['posibilidadViajar'].setValue(this.getValueBooleanForm(this.ciudadano.posibilidadViajar));
      this.f['posibilidadTrasladarse'].setValue(this.getValueBooleanForm(this.ciudadano.posibilidadTrasladarse));
      this.f['interesOfertasTeletrabajo'].setValue(this.getValueBooleanForm(this.ciudadano.interesOfertasTeletrabajo));
      this.f['propiedadMedioTransporte'].setValue(this.getValueBooleanForm(this.ciudadano.propiedadMedioTransporte));
      this.f['tieneLicenciaConduccionCarro'].setValue(this.getValueBooleanForm(this.ciudadano.tieneLicenciaConduccionCarro));
      this.f['tieneLicenciaConduccionMoto'].setValue(this.getValueBooleanForm(this.ciudadano.tieneLicenciaConduccionMoto));
      this.f['tieneLibretaMilitar'].setValue(this.getValueBooleanForm(this.ciudadano.tieneLibretaMilitar));
      this.f['perteneceARural'].setValue(this.getValueBooleanForm(this.ciudadano.perteneceARural));
      this.f['certificadoResidencia'].setValue(this.getValueBooleanForm(this.ciudadano.certificadoResidencia));
      this.f['grupoEtnico'].setValue(this.ciudadano.grupoEtnico === null ? this.ciudadano.grupoEtnico === null : this.ciudadano.grupoEtnico[0]);

      // Ejecuta validaciones de telefonos luego del patchvalue
      this.validateOnlyNumberInput(null, 'telefono');
      this.validateOnlyNumberInput(null, 'otroTelefono');      

      setTimeout(() => {
        this.getPuntosAtencion();
        this.setFieldsDireccion();
        // Realiza algunas validaciones dependiendo de la data cargada
        // Tipo documento DNI
        if (this.f['tipoDocumentoId'].value == 5) {
          this.f['tipoDocumentoAdicionalId'].addValidators(Validators.required);
          this.f['tipoDocumentoAdicionalId'].updateValueAndValidity();
          this.f['numeroDocumentoAdicional'].addValidators(Validators.required);
          this.f['numeroDocumentoAdicional'].updateValueAndValidity();
          this.showDni = true;
        }
        // Si el tipo documento es CC o ti la nacionalidad es Colombiano y no se puede cambiar || Se comenta pues la validación ya NO APLICA
        // if (this.f['tipoDocumentoId'].value == 1 || this.f['tipoDocumentoId'].value == 2) {
        //   const nacionalidadStr = 48;
        //   this.f['nacionalidadId'].setValue(nacionalidadStr);
        //   this.f['nacionalidadId'].updateValueAndValidity();
        //   this.f['nacionalidadId'].disable();
        // }
      }, 1000);
      setTimeout(() => {
        this.iniciando = false;
      }, 800);
    }
  }

  // Getter para fácil acceso a los controles de formulario
  get f() {
    return this.personalInformationForm.controls;
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

  getParametricos() {
    // Listado tipo de documentos adicional
    this.cvService.$tiposDocumento.subscribe(
      tipos => {
        this.listTiposDocumentoAdicional = tipos.filter(tipo => tipo.principal !== true);
        this.listTiposDocumento = tipos;
        this.tipoDocumentoDni = tipos.find(tipo => tipo.sigla == 'DNI');
      });
    // Listado de paises de nacimiento
    this.cvService.$paisesNacimiento.subscribe(
      (response) => {
        this.listPaisesNacimiento = response;
      }
    );
    // Listado de paises de residencia
    this.cvService.$paisesResidencia.subscribe(
      (response) => {
        this.listPaisesResidencia = response;
        // Consulta el pais colombia para unas validaciones
        this.paisColombia = this.listPaisesResidencia.find(element => element.nombre.toLocaleLowerCase() == 'colombia');
      }
    );
    // Listado de departamentos de residencia
    this.cvService.$departamentosResidencia.subscribe(
      (response) => {
        this.listDepartamentosResidencia = response;
      }
    );
    // Listado de departamentos de nacimiento
    this.cvService.$departamentosNacimiento.subscribe(
      (response) => {
        this.listDepartamentosNacimiento = response;
      }
    );
    // Listado de prestadores - esto por que está bloqueado y no se puede cambiar entonces se cargan todos
    this.prestadorService.getPrestadores.subscribe(
      prestadores => {
        this.listPrestadoresPreferencia = prestadores;
      }
    );
    // Listado de categoria licencia moto y carro
    this.cvService.$categoriaLicencia.subscribe(
      (response) => {
        this.listCategoriaLicenciaCarro = response.filter(categoria => categoria.tipo == 'Carro');
        this.listCategoriaLicenciaMoto = response.filter(categoria => categoria.tipo == 'Moto');
      }
    );
    // Listado de generos
    this.cvService.$generos.subscribe(
      (response) => {        
        this.listGeneros = response;
      }
    );

    // Listado de generos
    this.cvService.$sexos.subscribe(
      (response) => {
        this.listSexos = response;
      }
    );

    // Cargue de listados de direcciones
    this.listViaPrincipal = this.cvService.getListViaPrincipal;
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
        // Consume servicio para añadir parametrico en el storage
        this.prestadorService.setPuntosAtencionStorage(response);
        this.listPuntosAtencion = response;
        setTimeout(() => { this.showLoading = false; }, 1000);
      });
    }
  }

  cambiosPaisNacimiento() {
    this.f['paisNacimientoId'].valueChanges.subscribe(
      (pais) => {
        this.f['departamentoNacimientoId'].clearValidators();
        this.f['municipioNacimientoId'].clearValidators();
        this.f['estadoNacimiento'].clearValidators();
        this.f['ciudadNacimiento'].clearValidators();

        // Si cambia el pais entonces vacia algunos campos
        if (!this.iniciando) {
          this.f['estadoNacimiento'].setValue('');
          this.f['ciudadNacimiento'].setValue('');
        }

        if (pais == 48) { // this.paisColombia?.id
          this.f['departamentoNacimientoId'].addValidators(Validators.required);
          this.f['municipioNacimientoId'].addValidators(Validators.required);
          this.showDepartamentoN = true;
          this.showMunicipioN = true;
        } else {
          if (!this.iniciando) {
            this.f['departamentoNacimientoId'].setValue('');
            this.f['municipioNacimientoId'].setValue('');
            this.f['estadoNacimiento'].addValidators(Validators.required);
            this.f['ciudadNacimiento'].addValidators(Validators.required);
          }
          this.showDepartamentoN = false;
          this.showMunicipioN = false;
        }

        // Carga por defecto la nacionalidad de acuerdo al pais seleccionado solo si no es disabled
        if (!this.f['nacionalidadId'].disabled) {
          // const paisSeleccionado: Parametrico | undefined = this.listPaisesNacimiento.find(element => element.id == pais);
          this.f['nacionalidadId'].setValue(pais);
        }

        this.f['departamentoNacimientoId'].updateValueAndValidity();
        this.f['municipioNacimientoId'].updateValueAndValidity();
        this.f['nacionalidadId'].updateValueAndValidity();
        this.f['estadoNacimiento'].updateValueAndValidity();
        this.f['ciudadNacimiento'].updateValueAndValidity();

        this.parametricosService.getParametricos(PARAMETRICOS.PAISES).subscribe(
          paises => {
            this.listNacionalidades = paises.filter(pais => {
              if (pais.nacionalidad != '') {
                return pais.nacionalidad;
              }
              return false;
            });
            // Si el tipo doc es DNI en el listado de nacionalidad quita Colombiano
            // const tipoDocSeleccionado = this.listTiposDocumento.find(tipo => tipo.id == this.f['tipoDocumentoId'].value);
            // if (tipoDocSeleccionado?.sigla === 'DNI') {
            //   this.listNacionalidades.splice(this.listNacionalidades.findIndex(nac => nac.sigla == 'CO'), 1);
            // }
          }
        );
      }
    );
  }
  /**
   * Función que controla el evento de cambio sobre el campo pais para realizar algunas validaciones
   */
  cambiosPaisResidencia() {
    this.f['paisResidenciaId'].valueChanges.subscribe(
      pais => {
        this.f['departamentoResidenciaId'].clearValidators();
        this.f['municipioResidenciaId'].clearValidators();
        this.f['barrioResidencia'].clearValidators();
        this.f['perteneceARural'].clearValidators();
        this.f['telefono'].clearValidators();
        this.f['otroTelefono'].clearValidators();
        this.f['estado'].clearValidators();
        this.f['ciudad'].clearValidators();
        this.f['certificadoResidencia'].clearValidators();

        if (!this.iniciando) {
          this.f['telefono'].setValue('');
          this.f['otroTelefono'].setValue('');
          this.f['estado'].setValue('');
          this.f['ciudad'].setValue('');
        }

        // Valida el pais seleccionado
        // Si es Colombia entonces muestra los campos departamento, municipio, barrio, pertenece a, telefono (deben ser requeridos)
        if (pais == 48) { // this.paisColombia?.id
          this.f['departamentoResidenciaId'].addValidators(Validators.required);
          this.f['municipioResidenciaId'].addValidators(Validators.required);
          this.f['barrioResidencia'].addValidators(Validators.required);
          this.f['perteneceARural'].addValidators(Validators.required);
          this.f['certificadoResidencia'].addValidators(Validators.required);
          this.countMinDigit = 10; // Setea la cantidad de dígitos mínimos para el campo telefono en caso de ser Colombia
          this.countMinDigitOtroTel = 10; // Setea la cantidad de dígitos mínimos para el campo telefono en caso de ser Colombia
          this.showDepartamento = true;
          this.showMunicipio = true;
          this.showBarrio = true;
          // Validación para la dirección pues debe bloquear el campo direccion
          setTimeout(() => {
            this.validateDireccion(true);
          }, 800);
        } else {
          if (!this.iniciando) {
            this.resetFieldsDireccion(true);
            this.f['municipioResidenciaId'].setValue('');
            this.f['barrioResidencia'].setValue('');
            this.f['perteneceARural'].setValue('');
            this.f['certificadoResidencia'].setValue('');
            this.f['estado'].addValidators(Validators.required);
            this.f['ciudad'].addValidators(Validators.required);
            this.validateDireccion(false, true);
          }
          this.countMinDigit = 7; // Setea la cantidad de dígitos mínimos para el campo telefono
          this.countMinDigitOtroTel = 7; // Setea la cantidad de dígitos mínimos para el campo telefono
          this.showDepartamento = false;
          this.showMunicipio = false;
          this.showBarrio = false;
          // Validación para la dirección pues debe habilitarla y que la digiten
          this.validateDireccion(false);
        }
        this.f['telefono'].addValidators([Validators.minLength(this.countMinDigit), Validators.maxLength(10), this.validateTelefonoCel.bind(this)]);
        this.setRequiredControlTelefono();
        this.f['otroTelefono'].addValidators([Validators.minLength(this.countMinDigit), Validators.maxLength(10), this.validateTelefono.bind(this)]);
        this.setRequiredControlOtroTelefono();

        this.f['departamentoResidenciaId'].updateValueAndValidity();
        this.f['municipioResidenciaId'].updateValueAndValidity();
        this.f['telefono'].updateValueAndValidity();
        this.f['otroTelefono'].updateValueAndValidity();
        this.f['barrioResidencia'].updateValueAndValidity();
        this.f['certificadoResidencia'].updateValueAndValidity();
        this.f['perteneceARural'].updateValueAndValidity();
        this.f['estado'].updateValueAndValidity();
        this.f['ciudad'].updateValueAndValidity();
      }
    );
  }

  cambiosDeptoNacimiento() {
    this.f['departamentoNacimientoId'].valueChanges.subscribe(
      (depto) => {
        this.$listMunicipiosNacimiento = this.parametricosService.getParametricos(PARAMETRICOS.MUNICIPIO, PARAMETRICOS_FILTROS.MUNICIPIO__DEPARTAMENTO_ID, depto);
        if (!this.iniciando) {
          this.f['municipioNacimientoId'].setValue('');
        }
        this.f['municipioNacimientoId'].updateValueAndValidity();
      }
    );
  }
  /**
   * Función que controla el evento de cambio sobre el campo departamento y lanza la petición para consultar los municipios
   */
  cambiosDeptoResidencia() {
    this.f['departamentoResidenciaId'].valueChanges.subscribe(
      depto => {
        // Filtra el listado de municipios con respecto al departamento
        this.$listMunicipiosResidencia = this.parametricosService.getParametricos(PARAMETRICOS.MUNICIPIO, PARAMETRICOS_FILTROS.MUNICIPIO__DEPARTAMENTO_ID, depto);

        if (!this.iniciando) {
          this.f['municipioResidenciaId'].setValue('');
          this.f['barrioResidencia'].setValue('');
          this.f['perteneceARural'].setValue('');
          this.f['estrato'].setValue(null);
          this.resetFieldsDireccion(true);
        }
        this.f['municipioResidenciaId'].updateValueAndValidity();
        this.localidadesComuna=[];
      }
    );
  }
  /**
   * Función que controla el evento de cambio sobre el campo municipio
   */
  cambiosMunicipioResidencia() {
    this.f['municipioResidenciaId'].valueChanges.subscribe(
      municipio => {
        if (!this.iniciando && municipio !== null && municipio !== undefined && municipio !== '') {
          this.f['barrioResidencia'].setValue('');
          this.f['perteneceARural'].setValue('');
          this.f['estrato'].setValue(null);
          this.resetFieldsDireccion(true);
          this.f['localidadComunaId'].setValue('');
          this.f['localidadComunaId'].updateValueAndValidity(); 
          this.getlocalidadComuna(municipio);
        }        
      }
    );
  }

  cambiosTieneLicenciaCarro() {
    this.f['tieneLicenciaConduccionCarro'].valueChanges.subscribe(
      (tieneLicencia) => {
        this.f['categoriaLicenciaCarroId'].clearValidators();
        if (!this.iniciando) {
          this.f['categoriaLicenciaCarroId'].setValue('');
        }
        if (tieneLicencia == 1) {
          this.f['categoriaLicenciaCarroId'].addValidators([Validators.required]);
          this.showCatLicenciaCarro = true;
        } else if (tieneLicencia == 0) {
          this.showCatLicenciaCarro = false;
        }
        this.f['categoriaLicenciaCarroId'].updateValueAndValidity();
      }
    );
  }
  cambiosTieneLicenciaMoto() {
    this.f['tieneLicenciaConduccionMoto'].valueChanges.subscribe(
      (tieneLicencia) => {
        this.f['categoriaLicenciaMotoId'].clearValidators();
        if (!this.iniciando) {
          this.f['categoriaLicenciaMotoId'].setValue('');
        }
        if (tieneLicencia == 1) {
          this.f['categoriaLicenciaMotoId'].addValidators([Validators.required]);
          this.showCatLicenciaMoto = true;
        } else if (tieneLicencia == 0) {
          this.showCatLicenciaMoto = false;
        }
        this.f['categoriaLicenciaMotoId'].updateValueAndValidity();
      }
    );
  }

  /**
   * Función que controla el evento de cambio sobre el campo prestador de preferencia y lanza la petición para consultar los puntos de atención relacionados
   */
  cambiosPrestador() {
    this.f['prestadorPreferenciaId'].valueChanges.subscribe(
      prestador => {
        // Filtra el listado de puntos de atencion con respecto al prestador de preferencia
        const listPuntoAtencionStorage = this.prestadorService.getPuntosAtencionStorage;
        this.listPuntosAtencion = listPuntoAtencionStorage.filter(punto => punto.prestadorId == prestador);
        if (!this.iniciando) {
          this.f['puntoAtencionId'].setValue('');
        }
        this.f['puntoAtencionId'].updateValueAndValidity();
      }
    );
  }

  cambiosNacionalidad() {
    this.f['nacionalidadId'].valueChanges.subscribe(
      element => {
        if (element !== null) {
          if (element === 231) {
            this.cvService.$tiposDocumento.subscribe(
              tipos => {
                this.listTiposDocumentoAdicional = tipos.filter(tipo => tipo.principal !== true);
              });
          } else {
            this.cvService.$tiposDocumento.subscribe(
              tipos => {
                this.listTiposDocumentoAdicional = tipos.filter(tipo => tipo.sigla == 'CC' || tipo.sigla == 'PA');
              });
          }
        }
      }
    );
  }

  cambiosPoblacionFocalizada() {
    this.f['poblacionFocalizada'].valueChanges.subscribe(
      element => {
        this.f['grupoEtnico'].clearValidators();
        this.f['tipoPoblacion'].clearValidators();
        this.f['condicionDiscapacidad'].clearValidators();
        this.f['condicionSaludMental'].clearValidators();
        // Si la poblacion focalizada es SI muestras varios campos adicionales
        if (element == 1) {
          this.showPoblacionFocalizada = true;
          this.f['grupoEtnico'].addValidators([Validators.required]);
          this.tipoPoblacionControl.addValidators(Validators.required);
          this.f['tipoPoblacion'].addValidators([Validators.required]);
          this.f['condicionDiscapacidad'].addValidators([Validators.required]);
          this.f['condicionSaludMental'].addValidators([Validators.required]);
        } else if (element == 0) {
          this.showPoblacionFocalizada = false;
          this.f['grupoEtnico'].setValue('');
          this.clearTipoPoblacion();
          this.clearCondDiscapacidad();
          this.clearCondSaludMental();
        }

        this.f['grupoEtnico'].updateValueAndValidity();
        this.f['tipoPoblacion'].updateValueAndValidity();
        this.f['condicionDiscapacidad'].updateValueAndValidity();
        this.f['condicionSaludMental'].updateValueAndValidity();
      }
    );
  }

  cambiosGrupoEtnico(e: any) {
    const grupo = e == null ? this.f['grupoEtnicoId'].value : e.target.value;
    if (grupo !== undefined && grupo !== null && grupo !== '') {
      this.f['tipoPoblacion'].clearValidators();
      this.f['condicionDiscapacidad'].clearValidators();
      this.f['condicionSaludMental'].clearValidators();
    } else {
      this.f['grupoEtnico'].addValidators([Validators.required]);
      this.f['tipoPoblacion'].addValidators([Validators.required]);
      this.f['condicionDiscapacidad'].addValidators([Validators.required]);
      this.f['condicionSaludMental'].addValidators([Validators.required]);
    }

    if (e !== null) {
      this.f['grupoEtnico'].updateValueAndValidity();
      this.f['tipoPoblacion'].updateValueAndValidity();
      this.f['condicionDiscapacidad'].updateValueAndValidity();
      this.f['condicionSaludMental'].updateValueAndValidity();
    }
  }

  cambioSexo() {
    this.f['sexoId'].valueChanges.subscribe(
      sexo => {
        this.f['tieneLibretaMilitar'].clearValidators();

        // Si el genero es masculino  o no binario debe mostrar campo de tiene libreta
        if (sexo == 2 || sexo == 3) {
          this.showTieneLibreta = true;
          this.f['tieneLibretaMilitar'].addValidators([Validators.required]);
        } else {
          this.showTieneLibreta = false;
          this.showTipoNumLibreta = false;
          this.f['tieneLibretaMilitar'].setValue('');
          this.f['tipoLibretaMilitarId'].setValue('');
          this.f['numeroLibretaMiltar'].setValue('');
        }
        this.f['tieneLibretaMilitar'].updateValueAndValidity();
      }
    );
  }

  cambioTieneLibreta() {
    this.f['tieneLibretaMilitar'].valueChanges.subscribe(
      tiene => {
        if (!this.iniciando) {
          this.f['tipoLibretaMilitarId'].clearValidators();
          this.f['numeroLibretaMiltar'].clearValidators();
          this.f['tipoLibretaMilitarId'].setValue('');
          this.f['numeroLibretaMiltar'].setValue('');
          // Si tiene libreta entonces dejar requeridos los campos
          if (tiene == 1) {
            this.showTipoNumLibreta = true;
            this.f['tipoLibretaMilitarId'].addValidators([Validators.required]);
            this.f['numeroLibretaMiltar'].addValidators([Validators.required, Validators.pattern("^[0-9]*$"), Validators.minLength(6), Validators.maxLength(10)]);
          } else {
            this.showTipoNumLibreta = false;
          }
          this.f['tipoLibretaMilitarId'].updateValueAndValidity();
          this.f['numeroLibretaMiltar'].updateValueAndValidity();

        }
      }
    );
  }

  cambiosGenero($event:any){
    const val = $event.target.value;
    console.log(val);
    if(val==="5"){
      this.f['cualGenero'].addValidators([Validators.required]);
    }else{
      this.f['cualGenero'].setValidators(null);
    }
    this.f['cualGenero'].setValue('');
    this.f['cualGenero'].updateValueAndValidity();
  }

  cambiosOrientacionSexual($event:any){
    const val = $event.target.value;
    if(val==="5"){
      this.f['cualOrientacionSexual'].addValidators([Validators.required]);
    }else{
      this.f['cualOrientacionSexual'].setValidators(null);
    }
    this.f['cualOrientacionSexual'].setValue('');
    this.f['cualOrientacionSexual'].updateValueAndValidity();
  }

  cambioPerteneceA() {
    this.f['perteneceARural'].valueChanges.subscribe(
      pertenece => {
        if (pertenece !== '' && pertenece !== null && pertenece !== undefined) {
          this.f['barrioResidencia'].clearValidators();
          // Si pertenece a urbano entonces pone requeridos los campos de direccion
          if (pertenece == '0') {
            setTimeout(() => {
              this.validateDireccion(true);
            }, 800);
            // Validación barrio
            this.f['barrioResidencia'].addValidators([Validators.required]);
            this.showBarrio = true;
          } else if (pertenece == '1') {
            // Acá pertenece a Rural
            setTimeout(() => {
              this.validateDireccion(false);
            }, 800);
            // Validación barrio
            this.showBarrio = false;
            if (!this.iniciando) {
              this.f['barrioResidencia'].setValue('');
            }
          }
          this.f['barrioResidencia'].updateValueAndValidity();
        }
        this.getlocalidadComuna(this.f['municipioResidenciaId'].value);
      }
    );
  }

  cambioTipoDocAdicional() {
    this.f['tipoDocumentoAdicionalId'].valueChanges.subscribe(
      tipo => {
        if (tipo !== null) {
          this.f['numeroDocumentoAdicional'].clearValidators();

          switch (tipo) {
            case '5': // Pasaporte
              this.f['numeroDocumentoAdicional'].addValidators([Validators.required, Validators.pattern("^[a-zA-Z0-9]*$"), Validators.maxLength(20)]);
              break;
            default:
              this.f['numeroDocumentoAdicional'].addValidators([Validators.required, Validators.pattern("^[0-9]*$"), Validators.maxLength(20)]);
              break;
          }
          this.f['numeroDocumentoAdicional'].updateValueAndValidity();
        }
      }
    );
  }

  cambioTipoPoblacionForm() {
    this.f['tipoPoblacion'].valueChanges.subscribe(
      tipoP => {
        if (tipoP !== undefined && tipoP !== null && tipoP !== '') {
          this.f['grupoEtnico'].clearValidators();
          this.f['condicionDiscapacidad'].clearValidators();
          this.f['condicionSaludMental'].clearValidators();
        } else {
          this.f['grupoEtnico'].addValidators([Validators.required]);
          this.f['tipoPoblacion'].addValidators([Validators.required]);
          this.f['condicionDiscapacidad'].addValidators([Validators.required]);
          this.f['condicionSaludMental'].addValidators([Validators.required]);
        }
      }
    );
  }
  cambioConDiscapacidadForm() {
    this.f['condicionDiscapacidad'].valueChanges.subscribe(
      disc => {
        if (disc !== undefined && disc !== null && disc !== '') {
          this.f['tipoPoblacion'].clearValidators();
          this.f['grupoEtnico'].clearValidators();
          this.f['condicionSaludMental'].clearValidators();
        } else {
          this.f['grupoEtnico'].addValidators([Validators.required]);
          this.f['tipoPoblacion'].addValidators([Validators.required]);
          this.f['condicionDiscapacidad'].addValidators([Validators.required]);
          this.f['condicionSaludMental'].addValidators([Validators.required]);
        }
      }
    );
  }
  cambioConSaludMentalForm() {
    this.f['condicionSaludMental'].valueChanges.subscribe(
      saludM => {
        if (saludM !== undefined || saludM !== null || saludM !== '') {
          this.f['tipoPoblacion'].clearValidators();
          this.f['condicionDiscapacidad'].clearValidators();
          this.f['grupoEtnico'].clearValidators();
        } else {
          this.f['grupoEtnico'].addValidators([Validators.required]);
          this.f['tipoPoblacion'].addValidators([Validators.required]);
          this.f['condicionDiscapacidad'].addValidators([Validators.required]);
          this.f['condicionSaludMental'].addValidators([Validators.required]);
        }
      }
    );
  }

  /**
   * Función del submit del formulario para guardar la informacion personal del ciudadano
   */
  saveAction() {
    this.submitted = true;
    // Valida si el formuario ya contiene los campos requeridos
    if (this.personalInformationForm.valid) {
      this.showLoading = true;
      let formDataSend = this.personalInformationForm.value;
      const telefono = this.f['telefono'].value;
      const otroTelefono = this.f['otroTelefono'].value;

      // Transforma el nombre a mayúsculas
      formDataSend.primerNombre = this.f['primerNombre'].value.toUpperCase();
      formDataSend.segundoNombre = this.f['segundoNombre'].value.toUpperCase();
      formDataSend.primerApellido = this.f['primerApellido'].value.toUpperCase();
      formDataSend.segundoApellido = this.f['segundoApellido'].value.toUpperCase();
      // Convierte a string el telefono

      try {
        formDataSend.telefono = telefono.toString();
      } catch (error) {
        formDataSend.telefono = "";
      }

      try {
        formDataSend.otroTelefono = otroTelefono.toString();
      } catch (error) {
        formDataSend.otroTelefono = "";
      }
      // Convierte a string la fecha de nacimiento
      formDataSend.fechaNacimiento = this.cvService.convertSringDate(this.f['fechaNacimiento'].value);
      formDataSend.fechaExpedicionDocumento = this.cvService.convertSringDate(this.f['fechaExpedicionDocumento'].value);
      formDataSend.sexoId = +this.f['sexoId'].value;
      formDataSend.nacionalidadId = +this.f['nacionalidadId'].value;
      // Transforma los campos que son boolean
      formDataSend.jefeHogar = this.f['jefeHogar'].value == 1 ? true : false;
      formDataSend.localidadComunaId = this.f['localidadComunaId'].value == "" ? null : this.f['localidadComunaId'].value;
      formDataSend.dispuestoCambiarMunicipio = this.f['dispuestoCambiarMunicipio'].value == 1 ? true : false;
      formDataSend.poblacionFocalizada = this.f['poblacionFocalizada'].value == 1 ? true : false;
      formDataSend.dispuestoDesplazarseDiariamente = this.f['dispuestoDesplazarseDiariamente'].value == 1 ? true : false;
      formDataSend.sisben = this.f['sisben'].value == 1 ? true : false;
      formDataSend.posibilidadViajar = this.f['posibilidadViajar'].value == 1 ? true : false;
      formDataSend.posibilidadTrasladarse = this.f['posibilidadTrasladarse'].value == 1 ? true : false;
      formDataSend.interesOfertasTeletrabajo = this.f['interesOfertasTeletrabajo'].value == 1 ? true : false;
      formDataSend.propiedadMedioTransporte = this.f['propiedadMedioTransporte'].value == 1 ? true : false;
      formDataSend.tieneLicenciaConduccionCarro = this.f['tieneLicenciaConduccionCarro'].value == 1 ? true : false;
      formDataSend.tieneLicenciaConduccionMoto = this.f['tieneLicenciaConduccionMoto'].value == 1 ? true : false;
      formDataSend.perteneceARural = this.f['perteneceARural'].value == 1 ? true : false;
      formDataSend.tieneLibretaMilitar = this.f['tieneLibretaMilitar'].value == 1 ? true : false;
      formDataSend.certificadoResidencia = this.f['certificadoResidencia'].value == 1 ? true : false;
      formDataSend.tipoLibretaMilitarId = this.f['tipoLibretaMilitarId'].value == '' ? null : this.f['tipoLibretaMilitarId'].value;
      formDataSend.categoriaLicenciaCarroId = this.f['categoriaLicenciaCarroId'].value == '' ? null : +this.f['categoriaLicenciaCarroId'].value;
      formDataSend.categoriaLicenciaMotoId = this.f['categoriaLicenciaMotoId'].value == '' ? null : +this.f['categoriaLicenciaMotoId'].value;
      // Agrega los campos deshabilitados
      formDataSend.numeroDocumento = this.f['numeroDocumento'].value;
      formDataSend.tipoDocumentoId = +this.f['tipoDocumentoId'].value;
      formDataSend.correoElectronico = this.f['correoElectronico'].value;
      formDataSend.direccionResidencia = this.f['direccionResidencia'].value;
      formDataSend.prestadorPreferenciaId = this.f['prestadorPreferenciaId'].value;
      formDataSend.puntoAtencionId = this.f['puntoAtencionId'].value;
      // Agrega Direccion como arreglo
      formDataSend.direcciones = this.buildDireccion();
      // Envia el grupo etnico como arreglo
      formDataSend.grupoEtnico = this.f['grupoEtnico'].value == '' || this.f['grupoEtnico'].value == null ? [] : [this.f['grupoEtnico'].value];

      // this.personalInformationForm.disable();

      this.ciudadanoService.putSaveCiudadano(formDataSend).subscribe(
        (response) => {
          this.cvService.setCiudadano(response);
          const modalSuccess = this.modalService.open(ModalSuccessFormComponent);
          modalSuccess.componentInstance.body = 'Información personal actualizada con éxito';
          // Consulta los porcentajes para actualizarlos
          this.cvService.getPorcentajesAvance(this.ciudadano?.id).subscribe(
            response => { this.cvService.updatePorcentajes(response); }
          );
          this.showLoading = false;
        },
        (error) => {
          console.log(error);
          const modalError = this.modalService.open(ModalErrorFormComponent);
          modalError.componentInstance.body = 'Se ha producido un error, por favor inténtelo de nuevo!';
          this.showLoading = false;
        });
    } else {
      this.personalInformationForm.updateValueAndValidity();
      const modalRef = this.modalService.open(ModalValidationFormComponent);
      modalRef.componentInstance.message = 'Existen errores en la información ingresada. Por favor verifique y ajuste la información para continuar!!';
      this.showLoading = false;
      this.personalInformationForm.updateValueAndValidity();
    }
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

  validateOnlyNumberInput(evt: any, control: string) {
    const number = evt !== null ? evt.target.value : this.f[control].value;

    if (evt !== null) {
      const code = (evt.which) ? evt.which : evt.keyCode;
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

    if (control == 'telefono' || control == 'otroTelefono') {
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

      this.f[control].updateValueAndValidity();
      this.f[otherControl].updateValueAndValidity();
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
      if (pais != null && this.listPaisesResidencia.length > 0) {
        const paisSeleccionado: any = this.listPaisesResidencia.find(element => element.id == pais);
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
   * Función que realiza algunas validaciones custom sobre el campo Otro Telefono
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
      if (pais != null && this.listPaisesResidencia.length > 0) {
        const paisSeleccionado: any = this.listPaisesResidencia.find(element => element.id == pais);
        const firstDigit = control.value.substr(0, 1);

        if (paisSeleccionado.nombre.toLocaleLowerCase() == 'colombia' && firstDigit != '6') {
          return { firstDigit: true };
        }
      }
    }
    return null;
  }
  // Getters Validaciones OtroTelefono
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
   * Función que se encarga de agregar la selección un campo multiselect al listado correspondiente
   */
  public seleccionarMultiCampo($event: { itemData: Parametrico; }, control: string) {
    let itemData: Parametrico = $event.itemData;
    switch (control) {
      case 'cargoIneteres':
        let cargoInteres = this.f['cargoIneteres'] as FormArray;
        cargoInteres.push(new FormControl(itemData.id));
        break;
      case 'tipoPoblacion':
        let tipoPoblacion = this.f['tipoPoblacion'] as FormArray;
        tipoPoblacion.push(new FormControl(+itemData.id));

        if (itemData.id !== undefined && itemData.id !== null && itemData.id !== '') {
          this.f['grupoEtnico'].clearValidators();
          this.f['condicionDiscapacidad'].clearValidators();
          this.f['condicionSaludMental'].clearValidators();
        } else {
          this.f['grupoEtnico'].addValidators([Validators.required]);
          this.f['tipoPoblacion'].addValidators([Validators.required]);
          this.f['condicionDiscapacidad'].addValidators([Validators.required]);
          this.f['condicionSaludMental'].addValidators([Validators.required]);
        }

        this.f['grupoEtnico'].updateValueAndValidity();
        this.f['tipoPoblacion'].updateValueAndValidity();
        this.f['condicionDiscapacidad'].updateValueAndValidity();
        this.f['condicionSaludMental'].updateValueAndValidity();
        break;
      case 'condicionDiscapacidad':
        let condicionDiscapacidad = this.f['condicionDiscapacidad'] as FormArray;
        condicionDiscapacidad.push(new FormControl(+itemData.id));

        if (itemData.id !== undefined && itemData.id !== null && itemData.id !== '') {
          this.f['tipoPoblacion'].clearValidators();
          this.f['grupoEtnico'].clearValidators();
          this.f['condicionSaludMental'].clearValidators();
        } else {
          this.f['grupoEtnico'].addValidators([Validators.required]);
          this.f['tipoPoblacion'].addValidators([Validators.required]);
          this.f['condicionDiscapacidad'].addValidators([Validators.required]);
          this.f['condicionSaludMental'].addValidators([Validators.required]);
        }

        this.f['grupoEtnico'].updateValueAndValidity();
        this.f['tipoPoblacion'].updateValueAndValidity();
        this.f['condicionDiscapacidad'].updateValueAndValidity();
        this.f['condicionSaludMental'].updateValueAndValidity();
        break;
      case 'condicionSaludMental':
        let condicionSaludMental = this.f['condicionSaludMental'] as FormArray;
        condicionSaludMental.push(new FormControl(+itemData.id));

        if (itemData.id !== undefined || itemData.id !== null || itemData.id !== '') {
          this.f['tipoPoblacion'].clearValidators();
          this.f['condicionDiscapacidad'].clearValidators();
          this.f['grupoEtnico'].clearValidators();
        } else {
          this.f['grupoEtnico'].addValidators([Validators.required]);
          this.f['tipoPoblacion'].addValidators([Validators.required]);
          this.f['condicionDiscapacidad'].addValidators([Validators.required]);
          this.f['condicionSaludMental'].addValidators([Validators.required]);
        }

        this.f['grupoEtnico'].updateValueAndValidity();
        this.f['tipoPoblacion'].updateValueAndValidity();
        this.f['condicionDiscapacidad'].updateValueAndValidity();
        this.f['condicionSaludMental'].updateValueAndValidity();
        break;
    }
  }
  /**
   * Función que se encarga de quitar del listado correspondiente el que eliminen en el campo multiselect
   */
  public quitarMulticampo($event: { itemData: Parametrico; }, control: string) {
    switch (control) {
      case 'cargoIneteres':
        let cargoInteres = this.f['cargoIneteres'] as FormArray;
        let iC = cargoInteres.controls.findIndex((control) => control.value == $event.itemData.id);
        cargoInteres.removeAt(iC);
        break;
      case 'tipoPoblacion':
        let tipoPoblacion = this.f['tipoPoblacion'] as FormArray;
        let i = tipoPoblacion.controls.findIndex((control) => control.value == +$event.itemData.id);
        tipoPoblacion.removeAt(i);
        break;
      case 'condicionDiscapacidad':
        let condicionDiscapacidad = this.f['condicionDiscapacidad'] as FormArray;
        let iD = condicionDiscapacidad.controls.findIndex((control) => control.value == +$event.itemData.id);
        condicionDiscapacidad.removeAt(iD);
        break;
      case 'condicionSaludMental':
        let condicionSaludMental = this.f['condicionSaludMental'] as FormArray;
        let iS = condicionSaludMental.controls.findIndex((control) => control.value == +$event.itemData.id);
        condicionSaludMental.removeAt(iS);
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

  /**
   * Funciones para la lógica CRUD de los complementos
   */
  addComplement() {
    const modalComplemento = this.modalService.open(ComplementosModalComponent, {
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
          ciudadanoId: this.ciudadano?.id,
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

  setFieldsDireccion() {
    const direccion = this.ciudadano?.direcciones[0];
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

    if (validate) {
      this.showFieldsDireccion = true;
      this.f['direccionResidencia'].disable();
      this.f['viaPrincipalId'].addValidators([Validators.required]);
      this.f['viaPrincipal'].addValidators([Validators.required, Validators.maxLength(20)]);
      this.f['viaGeneradora'].addValidators([Validators.required]);
      this.f['viaGeneradoraPlaca'].addValidators([Validators.required]);
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
      this.f['direccionResidencia'].updateValueAndValidity();
    }

    this.f['viaPrincipalId'].updateValueAndValidity();
    this.f['viaPrincipal'].updateValueAndValidity();
    this.f['viaGeneradora'].updateValueAndValidity();
    this.f['viaGeneradoraPlaca'].updateValueAndValidity();    
    this.f['localidadComunaId'].updateValueAndValidity();
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
    this.f['localidadComunaId'].setValue('');
    this.arrComplementos = [];

    // Setea vacia la direccion si llega el parámetro a la función
    if (clearControlDireccion) {
      this.f['direccionResidencia'].setValue('');
    }
  }

  get requiredNumLibretaMilitar() {
    return this.f["numeroLibretaMiltar"].hasError("required");
  }
  get maxLengthValidNumLibretaMilitar() {
    return this.f["numeroLibretaMiltar"].hasError("maxlength");
  }
  get minLengthValidNumLibretaMilitar() {
    return this.f["numeroLibretaMiltar"].hasError("minlength");
  }

  clearTipoPoblacion() {
    this.tipoPoblacionControl.setValue('');
    let tipoPoblacion = this.f['tipoPoblacion'] as FormArray;
    tipoPoblacion.clear();
  }
  clearCondDiscapacidad() {
    this.condDiscapacidadControl.setValue('');
    let condicionDiscapacidad = this.f['condicionDiscapacidad'] as FormArray;
    condicionDiscapacidad.clear();
  }
  clearCondSaludMental() {
    this.condSaludMentalControl.setValue('');
    let condicionSaludMental = this.f['condicionSaludMental'] as FormArray;
    condicionSaludMental.clear();
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

}
