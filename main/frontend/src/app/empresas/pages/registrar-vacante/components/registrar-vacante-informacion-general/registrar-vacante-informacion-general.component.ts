import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { faCampground } from '@fortawesome/free-solid-svg-icons';
import { ModalDismissReasons, NgbDateStruct, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { left } from '@popperjs/core';
import { DropDownListComponent, MultiSelectComponent, TaggingEventArgs } from '@syncfusion/ej2-angular-dropdowns';
import { DateTime } from 'luxon';
import { debounceTime, forkJoin, map, merge, mergeAll, of, retry, switchMap, tap } from 'rxjs';
import { cloneUbicacionVacante, newUbicacionVacante, UbicacionVacante } from 'src/app/empresas/domain/dtos/ubicacion-vacante';
import { diasHabilesService } from 'src/app/empresas/use-cases/dias-habiles.service';
import { RegistrarVacanteService } from 'src/app/empresas/use-cases/registrar-vacante.service';
import { Parametrico } from 'src/app/model/parametricos';
import {
  PARAMETRICOS,
  PARAMETRICOS_FILTROS,
} from 'src/app/services/parametricos.service';

@Component({
  selector: 'registrar-vacante-informacion-general',
  templateUrl: './registrar-vacante-informacion-general.component.html',
  styleUrls: ['./registrar-vacante-informacion-general.component.css'],
})
export class RegistrarVacanteInformacionGeneralComponent implements OnInit {
  closeResult = '';
  constructor(
    public srv: RegistrarVacanteService,
    public srvDiasHabiles:diasHabilesService,
    private modalService: NgbModal
  ) {}
  public PARAMETRICOS = PARAMETRICOS;
  public PARAMETRICOS_FILTROS= PARAMETRICOS_FILTROS;
  /**Formulario general de ubicaciones */
  public ubicacionForm: FormGroup<UbicacionVacante> = newUbicacionVacante();
  /**campo especial para gestionar el valor del listado de motivo */
  public motivosExcepcionalidadControl: FormControl<string|null> = new FormControl<string>("");
  /**campo especial para gestionar el valor del listado de prestadores*/
  public prestadoresAlternosControl: FormControl<string|null> = new FormControl<string>("");

  /**campo especial para gestionar el valor del listado de poblaciones Vulnerables*/
  public poblacionesVulnerablesControl: FormControl<string|null> = new FormControl<string>("");

  /**campo especial para gestionar el valor del listado de grupos etnicos*/
  public gruposEtnicosControl: FormControl<string|null> = new FormControl<string>("");

  /**campo especial para gestionar el valor del listado de tipo control*/
  public tiposPoblacionControl: FormControl<string|null> = new FormControl<string>("");

  /**campo especial para gestionar el valor del listado de discapacidades*/
  public discapacidadesControl: FormControl<string|null> = new FormControl<string>("");

  /**campo especial para gestionar el valor del listado de discapacidades*/
  public condicionesSaludMentalControl: FormControl<string|null> = new FormControl<string>("");

/**campo especial para gestionar el valor del listado de zona geografica*/
public zonasGeograficasControl: FormControl<string|null> = new FormControl<string>("");

public descripcionTipoProyectoSeleccionado: string = "";


/**
 * MIN MAX REGLAS PARA LAS FECHAS
 */

  public fechaMinimaEstimadaOcupacionCargo:NgbDateStruct={day:1,month:1,year:1970};
  public fechaMaximaEstimadaOcupacionCargo:NgbDateStruct={day:1,month:1,year:1970};
  public fechaMinimalimiteEnvioHV:NgbDateStruct={day:1,month:1,year:1970};
  public fechaMaximaLimiteEnvioHV:NgbDateStruct={day:1,month:1,year:1970};


  /**
 * MultiSelectComponent
 */
  @ViewChild('multiselectdiscapacidades')
  public multiselectdiscapacidades!: MultiSelectComponent;
  @ViewChild('multiselectgruposEtnicos')
  public multiselectgruposEtnicos!: MultiSelectComponent;
  @ViewChild('multiselecttiposPoblacion')
  public multiselecttiposPoblacion!: MultiSelectComponent;
  @ViewChild('multiselectcondicionesSaludMental')
  public multiselectcondicionesSaludMental!: MultiSelectComponent;
  @ViewChild('multiselectpoblacionesVulnerables')
  public multiselectpoblacionesVulnerables!: MultiSelectComponent;
  @ViewChild('multiselectZonaRural')
  public multiselectZonaRural!:MultiSelectComponent;





public $departamentos = of([]).pipe(
    tap(_=>this.ubicacionForm.get('departamentoID')?.disable()),
    switchMap((_)=>this.srv.$departamentos)).pipe(tap(_=>this.ubicacionForm.get('departamentoID')?.enable()));

  public $municipios = (
      this.ubicacionForm.get('departamentoID') as FormControl
      ).valueChanges.pipe(
        tap((_) => {
          (this.ubicacionForm.get('municipioID') as FormControl).disable();
          (this.ubicacionForm.get('municipioID') as FormControl).setValue('');
           this.ubicacionForm.get('municipioID')?.reset();
        }),
        debounceTime(1000),
        switchMap((departamentoId) =>
          this.srv.parametricosSrv.getParametricos(
            PARAMETRICOS.MUNICIPIO,
            PARAMETRICOS_FILTROS.MUNICIPIO__DEPARTAMENTO_ID,
            departamentoId
          )
        ),tap(
          ()=>{
            (this.ubicacionForm.get('municipioID') as FormControl).enable();
          }
        )
    );

  public $localidades = (
    this.ubicacionForm.get('municipioID') as FormControl
  ).valueChanges.pipe(
    tap((_) => {
      (this.ubicacionForm.get('localidadComunaId') as FormControl).disable();
      (this.ubicacionForm.get('localidadComunaId') as FormControl).setValue('');
    }),
    debounceTime(1000),
    switchMap((departamentoId: string) => {
      let $localidades = this.srv.parametricosSrv.getParametricos(
        PARAMETRICOS.LOCALIDAD,
        PARAMETRICOS_FILTROS.LOCALIDAD__MUNICIPIO_ID,
        departamentoId
      );

      let $comunas = this.srv.parametricosSrv.getParametricos(
        PARAMETRICOS.COMUNA,
        PARAMETRICOS_FILTROS.COMUNA__MUNICIPIO_ID,
        departamentoId
      );
      return forkJoin([$localidades, $comunas]);
    }),
    map((parametricos)=>{
      return [...parametricos[0],...parametricos[1]]
    }),tap(()=>{
      (this.ubicacionForm.get('localidadComunaId') as FormControl).enable();
    })
  );

  public $responsables = this.srv.getFormControl("sedeId")
            .valueChanges.pipe(
                switchMap(
                  (sedeID:number)=>
                      this.srv.empresaSrv.getEmpresaSedeBySedeID(sedeID)
                ),
                map(
                  (sede)=>sede.usuarios
                )
            );

  public $descripcionModalidadSeleccionada = this.srv.getFormControl("modalidadTrabajoId")
      .valueChanges.pipe(
        switchMap(
          modalidadId => {
            return this.srv.$modalidadesDeTrabajo.pipe(map((modalidades:Parametrico[]) => {
             try {
              let modalidad =  modalidades.find(m => m.id == modalidadId);
              return modalidad?.descripcion??"Debe seleccionar una Modalidad de trabajo para ver su detalle";
             } catch (error) {
              return "Debe seleccionar una Modalidad de trabajo para ver su detalle"
             }

            }))
          }
        )
      );

  ngOnInit(): void {
    /**
     *  VALORES MAX Y MIN PARA LAS FECHAS
     */

    let dt = DateTime.local();

     this.fechaMinimalimiteEnvioHV=dt.plus({day:this.srvDiasHabiles.cantidadDiasHabiles()});
     this.fechaMaximaLimiteEnvioHV=dt.plus({month:6}) ;


    setTimeout(()=>{
      /** ----------------------------------
       * @todo: SEDE QUEMADA  DE DONDE SE DEBE CARGAR???
       */
      this.srv.getFormControl("sedeId").setValue(4)
    },2000)
    this.ajustarValoresYValidaciones();


    this.prestadoresAlternosControl.setValue(this.srv.getArrayControl("prestadoresAlternos").value)
    this.poblacionesVulnerablesControl.setValue(this.srv.getArrayControl("poblacionesVulnerables").value)
    this.gruposEtnicosControl.setValue(this.srv.getArrayControl("gruposEtnicos").value)
    this.tiposPoblacionControl.setValue(this.srv.getArrayControl("tiposPoblacion").value)
    this.condicionesSaludMentalControl.setValue(this.srv.getArrayControl("condicionesSaludMental").value)
    this.zonasGeograficasControl.setValue(this.srv.getArrayControl("zonasGeograficas").value)

    this.discapacidadesControl.setValue(this.srv.getArrayControl("discapacidades").value)
    this.motivosExcepcionalidadControl.setValue(this.srv.getArrayControl("motivosExcepcionalidad").value)
    this.srv.onVacanteCargadaParaEditar.subscribe(cargo =>{
      this.prestadoresAlternosControl.setValue(this.srv.getArrayControl("prestadoresAlternos").value)
      this.discapacidadesControl.setValue(this.srv.getArrayControl("discapacidades").value)
      this.motivosExcepcionalidadControl.setValue(this.srv.getArrayControl("motivosExcepcionalidad").value)
      this.poblacionesVulnerablesControl.setValue(this.srv.getArrayControl("poblacionesVulnerables").value)
      this.gruposEtnicosControl.setValue(this.srv.getArrayControl("gruposEtnicos").value)
      this.tiposPoblacionControl.setValue(this.srv.getArrayControl("tiposPoblacion").value)
      this.condicionesSaludMentalControl.setValue(this.srv.getArrayControl("condicionesSaludMental").value)
      this.zonasGeograficasControl.setValue(this.srv.getArrayControl("zonasGeograficas").value)
    });



    let nivelMinimoEstudioId                   = this.srv.getFormControl("nivelMinimoEstudioId")
    let manoObraCalificada                      = this.srv.getFormControl("manoObraCalificada");
    let graduado                               = this.srv.getFormControl("graduado")
    let puestosRequeridos                      = this.srv.getArrayControl("puestosRequeridos")
    let rangoRemitirCandidatoInicial           = this.srv.getFormControl("rangoRemitirCandidatoInicial")
    let rangoRemitirCandidatoFinal             = this.srv.getFormControl("rangoRemitirCandidatoFinal")

    this.srv.enableOrDisableField(false,                               manoObraCalificada);
    this.srv.enableOrDisableField(false,                               rangoRemitirCandidatoInicial);
    this.srv.enableOrDisableField(false,                               rangoRemitirCandidatoFinal);


    manoObraCalificada.setValue(this.srv.calcularManoDeObraCalificada());
    nivelMinimoEstudioId.valueChanges.subscribe((value)=>{
      manoObraCalificada.setValue(this.srv.calcularManoDeObraCalificada(),{emitEvent:true});
      if(value > 1){
        graduado.setValidators([Validators.required]);
      }else{
        graduado.clearValidators();
        graduado.setValue(null);
      }
      graduado.updateValueAndValidity();
    });

    rangoRemitirCandidatoInicial.setValue(this.srv.calcularRangoRemitirCandidatoInicial(),{emitEvent:true});
    rangoRemitirCandidatoFinal.setValue(this.srv.calcularRangoRemitirCandidatoFinal(),{emitEvent:true});
    merge(manoObraCalificada.valueChanges,puestosRequeridos.valueChanges).subscribe((_)=>{
      rangoRemitirCandidatoInicial.setValue(this.srv.calcularRangoRemitirCandidatoInicial(),{emitEvent:true});
      rangoRemitirCandidatoFinal.setValue(this.srv.calcularRangoRemitirCandidatoFinal(),{emitEvent:true});
    })

    this.cambiosTipoProyecto();

  }

  public eliminarUbicacion(ubicacion: UbicacionVacante | null | undefined){
    let ubicacionesArr = this.srv.registrarForm.controls["ubicaciones"] as FormArray<FormGroup<UbicacionVacante>>;
    let index = ubicacionesArr.controls.findIndex((control)=> control.value.departamentoID == ubicacion?.departamentoID && control.value.municipioID == ubicacion?.municipioID && control.value.localidadComunaId == ubicacion?.localidadComunaId);
    ubicacionesArr.removeAt(index);
  }
  open(content: any) {

    this.ubicacionForm.reset();

    this.modalService
      .open(content, { ariaLabelledBy: 'modal-basic-title',size: 'lg',backdrop: 'static', animation: true })
      .result.then(
        (result) => {

          let ubicacionArr = this.srv.registrarForm.controls["ubicaciones"] as FormArray<FormGroup<UbicacionVacante>>
          if(this.ubicacionForm.valid){
            ubicacionArr.push(cloneUbicacionVacante(this.ubicacionForm));

            (this.ubicacionForm.get('departamentoID') as FormControl).setValue('');
            this.ubicacionForm.reset()
          }
          this.closeResult = `Closed with: ${result}`;

        },
        (reason) => {
          (this.ubicacionForm.get('departamentoID') as FormControl).setValue('');
          this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
        }
      );
  }

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }


  /***
   * MOTIVOS SELECCION MULTIPLE
   * GESTION DE ACCIONES PARA AGREGAR Y QUITAR MOTIVOS
   */


  public IsRequiereLicenciaConduccion(){
    return this.booleanIsTrue("requiereLicenciaConduccion");
  }
  public IsRequiereLicenciaConduccionCarro(){
    return this.booleanIsTrue("requiereLicenciaConduccionCarro");
  }
  public IsRequiereLicenciaConduccionMoto(){
    return this.booleanIsTrue("requiereLicenciaConduccionMoto");
  }

  public IsSolicitudExcepcionalidad(){
    return this.booleanIsTrue("solicitudExcepcionalidad");
  }
  public IsGestionadaPorPrestadorAlterno(){
    return this.booleanIsTrue("gestionadaPorPrestadorAlterno");
  }
  public IsAptaParaPersonasConDiscapacidad(){
    return this.booleanIsTrue("aptaParaPersonasConDiscapacidad");
  }

  private booleanIsTrue(campo:string){
    try {
      if(this.srv.registrarForm.get(campo)?.value === true || this.srv.registrarForm.get(campo)?.value === false){
        return this.srv.registrarForm.get(campo)?.value
      }
      return this.srv.registrarForm.get(campo)?.value.toLowerCase() === 'true';
    } catch (error) {
      return false;
    }
  }



  public onFileSelect($event:any){
    let file:File = $event.target.files[0];

    if(file.size<=100000000){
      this.srv.solicitudAutorizacionExcepcionalidadFile = $event.target;
    } else{
      console.log("Tamaño del archivo no permitido.");
    }
  }

  // Ajustes de valores en los campos y validaciones
  public ajustarValoresYValidaciones(){


    let nombre = this.srv.getFormControl("nombre");
    let puestosRequeridos = this.srv.getFormControl("puestosRequeridos");
    let requiereLicenciaConduccion  = this.srv.getFormControl("requiereLicenciaConduccion");
    let requiereLicenciaConduccionCarro = this.srv.getFormControl("requiereLicenciaConduccionCarro");
    let requiereLicenciaConduccionMoto= this.srv.getFormControl("requiereLicenciaConduccionMoto");
    let categoriaLicenciaCarroId = this.srv.getFormControl("categoriaLicenciaCarroId");
    let categoriaLicenciaMotoId = this.srv.getFormControl("categoriaLicenciaMotoId");
    let solicitudExcepcionalidad = this.srv.getFormControl("solicitudExcepcionalidad");
    let motivosExcepcionalidad = this.srv.getArrayControl("motivosExcepcionalidad");
    let gestionadaPorPrestadorAlterno = this.srv.getFormControl("gestionadaPorPrestadorAlterno");
    let prestadoresAlternos = this.srv.getArrayControl("prestadoresAlternos");
    let aptaParaPersonasConDiscapacidad = this.srv.getFormControl("aptaParaPersonasConDiscapacidad");
    let discapacidades = this.srv.getArrayControl("discapacidades");
    let fechaLimiteEnvioHv = this.srv.getFormControl("fechaLimiteEnvioHv");
    let solicitudAutorizacionExcepcionalidadFile = this.srv.getFormControl("solicitudAutorizacionExcepcionalidadFile");
    let subsectorEconomicoId = this.srv.getFormControl("subsectorEconomicoId");
    let tipoProyectoId = this.srv.getFormControl("tipoProyectoId");
    let codigoInternoVacante = this.srv.getFormControl("codigoInternoVacante");
    let gestionadaPorPrestador = this.srv.getFormControl("gestionadaPorPrestador");


    let manoObraCalificada                      = this.srv.getFormControl("manoObraCalificada")
    let rangoRemitirCandidatoInicial           = this.srv.getFormControl("rangoRemitirCandidatoInicial")
    let rangoRemitirCandidatoFinal             = this.srv.getFormControl("rangoRemitirCandidatoFinal")
    let priorizarPoblacionVulnerable             = this.srv.getFormControl("priorizarPoblacionVulnerable")
    let poblacionesVulnerables                 = this.srv.getFormControl("poblacionesVulnerables")
    let priorizarZonaRural             = this.srv.getFormControl("priorizarZonaRural")

    let sectorEconomicoId = this.srv.getFormControl("sectorEconomicoId");
    let subSectorEconomicoId = this.srv.getFormControl("subSectorEconomicoId");

    /**Se debe impulsar el cambio del valor cuando es diferente de null para que recargue los subsectores */
    if(sectorEconomicoId.value != null){
      let sectorEconomicoIdValue = sectorEconomicoId.value;
      setTimeout(()=>{
        this.srv.$actualizarSubSectores.next(sectorEconomicoIdValue);
        console.log("Emitiendo", sectorEconomicoIdValue)
      },1000)


    }

    // nombre solo en mayusculas
     nombre.valueChanges.subscribe((_) => {
      try {
        nombre.setValue( nombre.value.toLocaleUpperCase(),{emitEvent:false});
      } catch {}
    });
    // solo valores numericos
    puestosRequeridos.valueChanges.subscribe((_) => {
      puestosRequeridos.setValue( String(puestosRequeridos.value).replace(/[^0-9]/gi, '') ,{emitEvent:false});
    });

    // solo valores numericos modal puestos de trabajos
    this.ubicacionForm.get('numeroPuestos')?.valueChanges.subscribe((_) => {
      const valorInicicial = String(this.ubicacionForm.get('numeroPuestos')?.value);
      let valor = null
      if(valorInicicial !== "null"){
        valor = Number(valorInicicial.replace(/[^0-9]/gi, ''));
      }
      this.ubicacionForm.get('numeroPuestos')?.setValue(valor ,{emitEvent:false});
    });

    // si requiereLicenciaConduccion cambia blanquea requiereLicenciaConduccionCarro y requiereLicenciaConduccionMoto
    requiereLicenciaConduccion.valueChanges.subscribe((requiere) => {
        if(requiere === "true"){
          requiereLicenciaConduccionCarro.setValidators([Validators.required])
          requiereLicenciaConduccionMoto.setValidators([Validators.required])
        }else{
          requiereLicenciaConduccionCarro.setValidators(null)
          requiereLicenciaConduccionMoto.setValidators(null)
        }
        requiereLicenciaConduccionCarro.setValue(null);
        requiereLicenciaConduccionMoto.setValue(null);
        requiereLicenciaConduccionCarro.updateValueAndValidity();
        requiereLicenciaConduccionMoto.updateValueAndValidity();
    });

    // si requiereLicenciaConduccionCarro cambia blanquea categoriaLicenciaCarroId
    requiereLicenciaConduccionCarro.valueChanges.subscribe((requiere)=>{
      if(requiere === "true" ){
        categoriaLicenciaCarroId.setValidators([Validators.required]);
      }else{
        categoriaLicenciaCarroId.setValidators(null);
      }
      categoriaLicenciaCarroId.setValue(null);
      categoriaLicenciaCarroId.updateValueAndValidity();
    })
    // si requiereLicenciaConduccionMoto cambia blanquea categoriaLicenciaMotoId
    requiereLicenciaConduccionMoto.valueChanges.subscribe((requiere)=>{
      if(requiere === "true"){
        categoriaLicenciaMotoId.setValidators([Validators.required]);
      }else{
        categoriaLicenciaMotoId.setValidators(null);
      }
      categoriaLicenciaMotoId.setValue(null);
      categoriaLicenciaMotoId.updateValueAndValidity();
    })

    this.motivosExcepcionalidadControl.setValue(motivosExcepcionalidad.value)
      solicitudExcepcionalidad.valueChanges.subscribe((value)=>{
        if(value == "true"){
          motivosExcepcionalidad.addValidators([Validators.required]);
          solicitudAutorizacionExcepcionalidadFile.addValidators([Validators.required]);
        }else{
          motivosExcepcionalidad.removeValidators([Validators.required]);
          solicitudAutorizacionExcepcionalidadFile.removeValidators([Validators.required]);
          // Borrando los motivos de Excepcionalidad.
          this.motivosExcepcionalidadControl.setValue(null)
        }
        motivosExcepcionalidad.updateValueAndValidity();
        solicitudAutorizacionExcepcionalidadFile.updateValueAndValidity();
      })

      // Controlando cuando cambia la seleccion de motivos de excepcionalidad
      // tener en cuenta que este campo es local y solo de control
      // no esta relacionado con la data del formulario
      this.motivosExcepcionalidadControl.valueChanges.subscribe(value => {
        if(value == null) {
          motivosExcepcionalidad.clear();
        }
      })



/*       if(gestionadaPorPrestadorAlterno.value=="true"){
        prestadoresAlternos.addValidators([Validators.required]);
      } */
      gestionadaPorPrestadorAlterno.valueChanges.subscribe(value => {
        if(value=="true"){
          prestadoresAlternos.addValidators([Validators.required])
        } else {
          prestadoresAlternos.removeValidators([Validators.required])
          this.prestadoresAlternosControl.setValue(null);
        }
      });

      // Controlando cuando cambia la seleccion de motivos de prestadores alternos
      // tener en cuenta que este campo es local y solo de control
      // no esta relacionado con la data del formulario
      this.prestadoresAlternosControl.valueChanges.subscribe(value => {
        if(value == null) {
          prestadoresAlternos.clear()
        }
      })

      //---------------------------------------------------------------
      //aptaParaPersonasConDiscapacidad
      //---------------------------------------------------------------
 /*      if(aptaParaPersonasConDiscapacidad.value=="true"){
        discapacidades.addValidators([Validators.required]);
      } */
      aptaParaPersonasConDiscapacidad.valueChanges.subscribe(value => {
        if(value=="true"){
          discapacidades.addValidators([Validators.required])
        } else {
          discapacidades.removeValidators([Validators.required])
          this.discapacidadesControl.setValue(null);
        }
      });

      // Controlando cuando cambia la seleccion de discapacidades
      // tener en cuenta que este campo es local y solo de control
      // no esta relacionado con la data del formulario
      this.discapacidadesControl.valueChanges.subscribe(value => {
        if(value == null) {
          discapacidades.clear()
        }
      })


      //fechas
      //-----------------------------------------------------
      //fechaMinimaEstimadaOcupacionCargo
      //-----------------------------------------------------
      let dt = DateTime.fromObject(fechaLimiteEnvioHv.value);
      if(dt.isValid){
        this.fechaMinimaEstimadaOcupacionCargo=dt.plus({day:1});
        this.fechaMaximaEstimadaOcupacionCargo=dt.plus({month:6});
      }
      fechaLimiteEnvioHv.valueChanges.subscribe((fechaSeleccionada:{ year: number, month: number, day: number}) => {
        let dt = DateTime.fromObject(fechaSeleccionada);
        this.fechaMinimaEstimadaOcupacionCargo=dt.plus({day:1});
        this.fechaMaximaEstimadaOcupacionCargo=dt.plus({month:6});
      });


      /*
      =======================================================
      -------------------------------------------------------
      HIDROCARBUROS
      =======================================================
      */

      subsectorEconomicoId.valueChanges.subscribe(_=>{
        if(this.srv.isVacanteHidrocarburos()){
          priorizarPoblacionVulnerable.setValidators([Validators.required])
          priorizarZonaRural.setValidators([Validators.required])
          tipoProyectoId.setValidators([Validators.required])
          tipoProyectoId.updateValueAndValidity()
          codigoInternoVacante.setValidators([Validators.required, Validators.maxLength(10),Validators.minLength(5),Validators.pattern(/^[A-zÑñ0-9]*$/)])
          codigoInternoVacante.updateValueAndValidity();
          gestionadaPorPrestador.setValue(true);
          gestionadaPorPrestador.updateValueAndValidity();
          gestionadaPorPrestador.disable();
          aptaParaPersonasConDiscapacidad.clearValidators();
          aptaParaPersonasConDiscapacidad.setValue(null);
          aptaParaPersonasConDiscapacidad.clearValidators();

          gestionadaPorPrestadorAlterno.clearValidators();
          gestionadaPorPrestadorAlterno.setValue(null);
          gestionadaPorPrestadorAlterno.clearValidators();

        }else{
          tipoProyectoId.clearValidators()
          tipoProyectoId.setValue(null)
          tipoProyectoId.updateValueAndValidity()
          codigoInternoVacante.clearValidators()
          codigoInternoVacante.setValue(null)
          codigoInternoVacante.updateValueAndValidity()
          priorizarPoblacionVulnerable.clearValidators()
          priorizarPoblacionVulnerable.setValue(null)
          priorizarZonaRural.clearValidators()
          priorizarZonaRural.setValue(null)

          aptaParaPersonasConDiscapacidad.setValidators([Validators.required])
          aptaParaPersonasConDiscapacidad.updateValueAndValidity()

          // gestionadaPorPrestador.setValue(null);
          gestionadaPorPrestador.updateValueAndValidity();
          gestionadaPorPrestador.enable();

          gestionadaPorPrestadorAlterno.setValidators([Validators.required])
          // gestionadaPorPrestadorAlterno.setValue(null);
          gestionadaPorPrestadorAlterno.updateValueAndValidity();
        }
      });


      rangoRemitirCandidatoInicial.setValue(this.srv.calcularRangoRemitirCandidatoInicial(),{emitEvent:true});
      rangoRemitirCandidatoFinal.setValue(this.srv.calcularRangoRemitirCandidatoFinal(),{emitEvent:true});
      merge(manoObraCalificada.valueChanges,puestosRequeridos.valueChanges).subscribe((_)=>{
        rangoRemitirCandidatoInicial.setValue(this.srv.calcularRangoRemitirCandidatoInicial(),{emitEvent:true});
        rangoRemitirCandidatoFinal.setValue(this.srv.calcularRangoRemitirCandidatoFinal(),{emitEvent:true});
      })


      priorizarPoblacionVulnerable.valueChanges.subscribe((valor:boolean) => {

        if(valor){
          poblacionesVulnerables.setValidators([Validators.required]);
          poblacionesVulnerables.updateValueAndValidity();
        }{
          poblacionesVulnerables.clearValidators();
          this.multiselectpoblacionesVulnerables?.selectAll(false);
        }


      })

      priorizarZonaRural.valueChanges.subscribe((valor) => {
       let nombreZonaGeografica = this.srv.getFormControl('nombreZonaGeografica');
       let zonasGeograficas = this.srv.getArrayControl("zonasGeograficas")
       if(valor === "true"){
        nombreZonaGeografica.setValidators([Validators.required,Validators.maxLength(50), Validators.minLength(3)])
        nombreZonaGeografica.updateValueAndValidity()
        zonasGeograficas.setValidators([Validators.required])
        zonasGeograficas.updateValueAndValidity()
       }else{
        nombreZonaGeografica.clearValidators();
        zonasGeograficas.clearValidators();
        nombreZonaGeografica.updateValueAndValidity()
        zonasGeograficas.updateValueAndValidity()
       }
       nombreZonaGeografica.setValue("");
       this.multiselectZonaRural?.selectAll(false);
      })

      poblacionesVulnerables.valueChanges.subscribe((valor:string[]) => {
        let eshidro = this.srv.isVacanteHidrocarburos();
        //['3' persona con discapacidad, '4' grupo etnico , '6' condicion salud mental, '7' tipo polbacion]
        let discapacidades       = ((valor.find(x=> x.toString() === "3") !==undefined && eshidro && valor.length > 0 ));
        let gruposEtnicos        = ((valor.find(x=> x.toString() === "4") !==undefined && eshidro && valor.length > 0 ));
        let condicionSaludMental = ((valor.find(x=> x.toString() === "6") !==undefined && eshidro && valor.length > 0 ));
        let tiposPoblacion       = ((valor.find(x=> x.toString() === "7") !==undefined && eshidro && valor.length > 0 ));

        this.srv.tipoPoblacionVulnebaleSeelcionBool.set('discapacidades',discapacidades);
        this.srv.tipoPoblacionVulnebaleSeelcionBool.set('gruposEtnicos',gruposEtnicos);
        this.srv.tipoPoblacionVulnebaleSeelcionBool.set('condicionesSaludMental',condicionSaludMental);
        this.srv.tipoPoblacionVulnebaleSeelcionBool.set('tiposPoblacion',tiposPoblacion);


        this.srv.tipoPoblacionVulnebaleSeelcionBool.forEach((value, key) => {
          let frmControl = this.srv.getArrayControl(key) as FormArray;
          if (value) {
            console.log(key,"obliga");
            frmControl.setValue([]);
            frmControl.setValidators([Validators.required])
            frmControl.updateValueAndValidity();
          } else {

            switch (key) {
              case 'discapacidades':
                this.multiselectdiscapacidades?.selectAll(false);
                this.multiselectdiscapacidades?.refresh();
                break;
              case 'gruposEtnicos':
                this.multiselectgruposEtnicos?.selectAll(false);
                this.multiselectgruposEtnicos?.refresh();
                break;
                case 'tiposPoblacion':
                  this.multiselecttiposPoblacion?.selectAll(false);
                  this.multiselecttiposPoblacion?.refresh();
                break;
                case 'condicionesSaludMental':
                  this.multiselectcondicionesSaludMental?.selectAll(false);
                  this.multiselectcondicionesSaludMental?.refresh();
                break;
              }

            frmControl.clearValidators();
            frmControl.updateValueAndValidity()
          }
        });

      })

}


public isVacanteHidrocarburosPoblacionVulnerable(){
  let eshidro = this.srv.isVacanteHidrocarburos();
  let valor = this.srv.getFormControl("priorizarPoblacionVulnerable").value;
  let valorbool = (valor==="true" || valor) == true;
  return ( valorbool && eshidro )?true:false;
}

public isVacanteHidrocarburosTipoZonaRural(){

  let eshidro = this.srv.isVacanteHidrocarburos();
  let valor = this.srv.getFormControl("priorizarZonaRural").value;
  let valorbool = (valor==="true" || valor) == true;
  return ( valorbool && eshidro )?true:false;
}

public isTipoPoblacionVulnerable(tipo:string){
  return this.srv.tipoPoblacionVulnebaleSeelcionBool.get(tipo);
}



public validarUbicacionEsDuplicada(){
  let departamentoID = Number(this.ubicacionForm.get('departamentoID')?.value);
  let municipioID = Number(this.ubicacionForm.get('municipioID')?.value);
  let localidadComunaId = Number(this.ubicacionForm.get('localidadComunaId')?.value);
  const existe= this.srv.getArrayControl('ubicaciones').value.find((x:any)=> x.departamentoID== departamentoID && x.municipioID == municipioID && x.localidadComunaId == localidadComunaId) ;
  return (existe === undefined )?false:true;
}



public validarcantidadCargosUbicacionVacante() {

  let cantidaUbicacionSeleccionadas = this.srv.getArrayControl('ubicaciones').value.reduce(
    (accumulator:any, currentValue:any) => accumulator + currentValue?.numeroPuestos,
    0
  );

  let puestoFormulario = Number(this.ubicacionForm.get('numeroPuestos')?.value);
  let totalPuestoaPorIngresar = cantidaUbicacionSeleccionadas+puestoFormulario;
  let puestosRequeridos = Number(this.srv.getFormControl('puestosRequeridos')?.value);
  return (puestosRequeridos>=totalPuestoaPorIngresar)?false:true;
}

public validarForumalarioUbibacion(){
  if(this.validarUbicacionEsDuplicada()|| this.validarcantidadCargosUbicacionVacante() || this.ubicacionForm.invalid){
    return true;
  }
  return false;
}

public nombreArchivo(nombre:string){
  return nombre?.split('/')?.pop();
}

public eliminarArchivo(){
 this.srv.getFormControl('solicitudAutorizacionExcepcionalidadFilePath').setValue(null);
}

public mostrargraduado(){
  let nivelMinimoEstudioValor = this.srv.getFormControl("nivelMinimoEstudioId").value;
  return (nivelMinimoEstudioValor==1 || nivelMinimoEstudioValor === null)?false:true;
}

  /**
   * Función que invoca los cambios del campo tipo de proyecto para poder definir la descripción del popover
   */
  cambiosTipoProyecto() {
    this.srv.getFormControl("tipoProyectoId").valueChanges.subscribe(
      tipoId => {
        if (tipoId !== null) {
          this.srv.$tiposProyectos.subscribe(
            tipos => {
              try {
                let tipo =  tipos.find(m => m.id == tipoId);
                this.descripcionTipoProyectoSeleccionado = tipo?.descripcion??"Debe seleccionar un Tipo de proyecto para ver su detalle!";
              } catch (error) {
               this.descripcionTipoProyectoSeleccionado = "Debe seleccionar una Tipo de proyecto para ver su detalle!";
              }
            }
          );
        }
      }
    );
  }

}
