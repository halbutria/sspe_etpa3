import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AbstractControl, FormArray, FormControl, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { DateTime } from 'luxon';
import { BehaviorSubject, map, merge, Observable, of, Subject, switchMap, tap } from 'rxjs';
import { Parametrico, ParametricoSalario } from 'src/app/model/parametricos';
import { Prestador } from 'src/app/model/prestador';
import { EmpresaService } from 'src/app/services/empresa.service';
import {
  PARAMETRICOS,
  PARAMETRICOS_FILTROS,
  ParametricosService,
} from 'src/app/services/parametricos.service';
import { PrestadorService } from 'src/app/services/prestador.service';
import { ModalErrorFormComponent } from 'src/app/shared/components/modal-error-form/modal-error-form.component';
import { ModalLoadingComponent } from 'src/app/shared/components/modal-loading/modal-loading.component';
import { ModalSuccessFormComponent } from 'src/app/shared/components/modal-success-form/modal-success-form.component';
import { environment } from 'src/environments/environment';
import { ESTADO_VACANTE } from '../domain/dtos/estado-vacante';
import { Idioma, newIdioma } from '../domain/dtos/idioma';
import { newUbicacionVacante, UbicacionVacante } from '../domain/dtos/ubicacion-vacante';
import { formControlVacanteInfo, newVacante, Vacante, VacanteControlPro } from '../domain/dtos/vacante';


@Injectable()
export class RegistrarVacanteService {

  /*
   * ************************************************************************************************************************************************************
   *
   * .  ,-----.      ,--. ,-----.       ,--.            ,--.                                                                 ,--.
   * . '  .-.  '     |  |'  .-.  '    ,-'  '-. ,---.  ,-|  | ,---.      ,---.  ,---. ,--.--.     ,--,--.,--.--. ,---.  ,---. |  | ,--,--.,--.--.
   * . |  | |  |,--. |  ||  | |  |    '-.  .-'| .-. |' .-. || .-. |    | .-. || .-. ||  .--'    ' ,-.  ||  .--'| .-. :| .-. ||  |' ,-.  ||  .--'
   * . '  '-'  '|  '-'  /'  '-'  '      |  |  ' '-' '\ `-' |' '-' '    | '-' '' '-' '|  |       \ '-'  ||  |   \   --.' '-' '|  |\ '-'  ||  |
   * .  `-----'  `-----'  `-----'       `--'   `---'  `---'  `---'     |  |-'  `---' `--'        `--`--'`--'    `----'.`-  / `--' `--`--'`--'
   * .                                                                 `--'                                           `---'
   *
   *
   *
   *
   * ***********************************************************************
   * @todo: Se debe codificar la seleccion de este ID al buscar la empresa
   * ***********************************************************************
   */
  public empresaSeleccionadaID=1;
  /************************************************************************************************************************************************************/
  public registrarForm: FormGroup<Vacante> = newVacante();
  /** @todo: colocar el tipo correcto para el campo de archivo*/
  public solicitudAutorizacionExcepcionalidadFile:any=null;
  // ----------------------------------------------------------
  public getArrayControl(name:string):FormArray{
    return this.registrarForm.get(name) as FormArray
  }
  public getFormControl(name:string):FormControl{
    return this.registrarForm.get(name) as FormControl
  }

  public resetForm(){
    // reset formulario
    this.registrarForm.reset();

    for(var name in this.registrarForm.controls) {
      let control = this.registrarForm.get(name);
      if(Array.isArray(control?.value)){
        const control = <FormArray>this.registrarForm.get(name);
          while (control.length > 0) {
            control.removeAt(0)
          }
      }else{
        control?.reset();
      }
    }

    //default values ;
    this.getFormControl('requiereExperienciaGeneral').setValue(false);
    this.getFormControl('requiereCapacitacionEspecifica').setValue(false);
    this.getFormControl('requiereExperienciaEspecifica').setValue(false);
    this.getFormControl('requiereCertificacionEspecifica').setValue(false);
  }

  private dateformat='dd-MM-yyyy';


  /**
   * Cuenta cuando se termina de cargar la informacion de una vacante para editar
   */
  public onVacanteCargadaParaEditar = new BehaviorSubject<boolean>(false);
  public $actualizarSubSectores = new Subject<number>();

  public $modalidadesDeTrabajo: Observable<Parametrico[]>;
  public $sectoresEconomicos: Observable<Parametrico[]>;
  public $subSectoresEconomicos: Observable<Parametrico[]>;
  public $departamentos: Observable<Parametrico[]>;
  public $municipios: Observable<Parametrico[]>;

  public $categoriasLicencia: Observable<Parametrico[]>;
  public $categoriaLicenciaCarro: Observable<Parametrico[]>;
  public $categoriaLicenciaMoto: Observable<Parametrico[]>;
  public $areasEmpresa: Observable<Parametrico[]>;
  public $motivosExcepcionalidad: Observable<Parametrico[]>;
  public $discapacidades: Observable<Parametrico[]>;
  public $nivelesEducativos: Observable<Parametrico[]>;
  public $nivelesDominioIdioma: Observable<Parametrico[]>;
  public $idiomas: Observable<Parametrico[]>;
  public $tiposContrato: Observable<Parametrico[]>;
  public $jornadasLaborales: Observable<Parametrico[]>;
  public $tiposSalario: Observable<Parametrico[]>;
  public $periodicidadesSalariales: Observable<Parametrico[]>;
  public $prestadoresAlternos: Observable<Prestador[]>;
  public $salarioMensual: Observable<ParametricoSalario>;


    /**
 * bool tipo de seleccion
 */
  public tipoPoblacionVulnebaleSeelcionBool: Map<string, boolean> = new Map();


  /**
   * *******************************
   * HIDROCARBUROS
   * *******************************
  */
public $tiposProyectos: Observable<Parametrico[]>;
public $tiposPoblacionesVulnerables: Observable<Parametrico[]>;
public $tiposGruposEtnicos: Observable<Parametrico[]>;
public $tiposPoblaciones: Observable<Parametrico[]>;
public $tiposCodicionSaludMental: Observable<Parametrico[]>;
public $tipoZonasGeograficasRurales: Observable<Parametrico[]>;


  /**
   * Cuando se carguen las denominaciones y cambie las seleccion de denominaciones relacionadas se puede utlizar
   * RecalcularOcupaciones como un disparador adicional que ayuda a cargar posteriormente las destrezas y las competencias.
   * En la emision se le de debe pasar el valor de las denominaciones seleccionadas (ocupaciones relacionadas en el formulario de descripcion de vacante)
   */
  public $recalcularOcupaciones = new Subject<string>();
  //---------------------------------------------------------

  public $denominaciones:Observable<Parametrico[]>;
  public $destrezas:Observable<Parametrico[]>;
  public $conocimientos:Observable<Parametrico[]>;
  public $nivelEducativo:Observable<Parametrico[]>;

  constructor(public parametricosSrv: ParametricosService, public prestadorSrv:PrestadorService, public empresaSrv:EmpresaService, public http:HttpClient,private modalService: NgbModal) { 
    /**
     * ----------------------------------------------------------------
     * Carga de parametricos
     * ----------------------------------------------------------------
     */
    //modalidadesDeTrabajo
    this.$modalidadesDeTrabajo = this.parametricosSrv.getParametricos(PARAMETRICOS.MODALIDAD_TRABAJO);

    //sectoresEconomicos
    this.$sectoresEconomicos = this.parametricosSrv.getParametricos(
      PARAMETRICOS.SECTOR_ECONOMICO
    );
    //subSectoresEconomicos
    this.$subSectoresEconomicos = merge(this.registrarForm.get('sectorEconomicoId')?.valueChanges.pipe(map(_=>true)) || of(true), this.$actualizarSubSectores.pipe(map(_=>false))).pipe(
        tap((value)=>
        {
          if(value)
          {
            this.registrarForm.get('subsectorEconomicoId')?.setValue(null)
          }
        }),
        tap(_=>this.registrarForm.get('subsectorEconomicoId')?.disable()),
        map(_=>(this.registrarForm.get('sectorEconomicoId')?.value)),
        switchMap((sectorEconomicoId) =>
          this.parametricosSrv.getParametricos(
            PARAMETRICOS.SUB_SECTOR_ECONOMICO,
            PARAMETRICOS_FILTROS.SUB_SECTOR_ECONOMICO__SECTOR_ECONOMICO_ID,
            String(sectorEconomicoId)
          ).pipe(tap(_=>this.registrarForm.get('subsectorEconomicoId')?.enable()))
        ),
      )||of([]);
    //departamentos
    this.$departamentos = this.parametricosSrv.getParametricos(PARAMETRICOS.DEPARTAMENTOS);
    this.$municipios = this.parametricosSrv.getParametricos(PARAMETRICOS.MUNICIPIO,PARAMETRICOS_FILTROS.MUNICIPIO__DEPARTAMENTO_ID,'0');
    this.$categoriasLicencia = this.parametricosSrv.getParametricos(PARAMETRICOS.CATEGORIA_LICENCIA);
    this.$categoriaLicenciaCarro = this.$categoriasLicencia.pipe(map((categorias:Parametrico[]) => categorias.filter((cat: Parametrico) => cat.tipo == "Carro")));
    this.$categoriaLicenciaMoto = this.$categoriasLicencia.pipe(map((categorias:Parametrico[]) => categorias.filter((cat: Parametrico) => cat.tipo == "Moto")));
    this.$areasEmpresa = this.parametricosSrv.getParametricos(
      PARAMETRICOS.AREA_EMPRESA
    );
    this.$motivosExcepcionalidad = this.parametricosSrv.getParametricos(
      PARAMETRICOS.MOTIVO_EXCEPCIONALIDAD
    );

    this.$nivelesEducativos = this.parametricosSrv.getParametricos(
      PARAMETRICOS.NIVEL_EDUCATIVO
    );
    this.$nivelesDominioIdioma = this.parametricosSrv.getParametricos(
      PARAMETRICOS.NIVEL_DOMINIO_IDIOMA
    );
    this.$idiomas = this.parametricosSrv.getParametricos(
      PARAMETRICOS.IDIOMA
    );
    this.$tiposContrato = this.parametricosSrv.getParametricos(
      PARAMETRICOS.TIPO_CONTRATO
    );
    this.$jornadasLaborales = this.parametricosSrv.getParametricos(
      PARAMETRICOS.JORNADA_LABORAL
    );
    this.$tiposSalario = this.parametricosSrv.getParametricos(
      PARAMETRICOS.TIPO_SALARIO
    );
    this.$periodicidadesSalariales = this.parametricosSrv.getParametricos(
      PARAMETRICOS.PERIODICIDAD_SALARIAL
    );
    this.$salarioMensual = this.parametricosSrv.getParametricoSalario();

    this.$prestadoresAlternos = this.prestadorSrv.getPrestadores

    this.$tiposProyectos = this.parametricosSrv.getParametricos(PARAMETRICOS.TIPOS_PROYECTOS_HIDRO);

    this.$tiposPoblacionesVulnerables = this.parametricosSrv.getParametricos(PARAMETRICOS.TIPO_POBLACION_VULNERABLE);

    this.$tiposGruposEtnicos = this.parametricosSrv.getParametricos(PARAMETRICOS.GRUPO_ETNICO);

    this.$tiposPoblaciones = this.parametricosSrv.getParametricos(PARAMETRICOS.TIPO_POBLACION);

    this.$tiposCodicionSaludMental = this.parametricosSrv.getParametricos(PARAMETRICOS.SALUD_MENTAL);

    this.$discapacidades = this.parametricosSrv.getParametricos(PARAMETRICOS.DISCAPACIDAD);
    this.$tipoZonasGeograficasRurales = this.parametricosSrv.getParametricos(PARAMETRICOS.TIPO_ZONA_GEOGRAFICA)
    .pipe(map((tipos)=>{
      return tipos.filter(x=> x.rural || x.id =='' )
    }));
    this.$denominaciones = this.parametricosSrv.getParametricos(PARAMETRICOS.DENOMINACIONES);

    //-------------------------------------------------------------------------------------------------------

    /**
     * Rules:
     * 1) De las denominaciones seleccionadas busco la ocupacion a la que pertenecen
     * 2) Filtro las destrezas y los conocimientos con base en esas ocupaciones
     */

    let $ocupacionesFromDenominaciones = merge([(this.registrarForm.get("denominacionesRelacionadas") as FormArray).valueChanges, this.$recalcularOcupaciones] ).pipe
    (
          tap(console.group),
          // cargo los parametricos de las denominaciones seleccionadas
          switchMap((_:string[]) => this.$denominaciones.pipe(

              map(
                denominaciones => denominaciones.filter(
                        (denominacion:Parametrico) => {
                          return this.getArrayControl("denominacionesRelacionadas").value.includes(denominacion.id)
                        }
                )
              )
            )
          ),
          // De las denominaciones mapea las ocupacionesId
          map(denominaciones => denominaciones.map((denominacion:Parametrico) => denominacion.cuocOcupacionId)),

    );

    this.$destrezas = $ocupacionesFromDenominaciones.pipe(
      switchMap((ocupaciones)=>
                    this.parametricosSrv.getParametricos(PARAMETRICOS.DESTREZAS)
                    .pipe(
                      map(destrezas => destrezas.filter(destreza => ocupaciones.includes(destreza.cuocOcupacionId) ))
                    )
      ),
      //eliminar repetidos
      map(destrezas => destrezas.filter((value, index, array)=>{
        return index === array.findIndex((v)=> v.id === value.id);
      })),
      //ordenar
      map(destrezas => destrezas.sort((a:Parametrico,b:Parametrico)=>{
        return a.nombre > b.nombre ?1:-1;
      })),
    )

    this.$conocimientos = $ocupacionesFromDenominaciones.pipe(
      switchMap((ocupaciones)=>
                    this.parametricosSrv.getParametricos(PARAMETRICOS.CONOCIMIENTOS)
                    .pipe(
                      map(conocimientos => conocimientos.filter(conocimiento => ocupaciones.includes(conocimiento.cuocOcupacionId) ))
                    )
      ),
      //eliminar repetidos
      map(conocimientos => conocimientos.filter((value, index, array)=>{
        return index === array.findIndex((v)=> v.id === value.id);
      })),

      //ordenar
      map(conocimientos => conocimientos.sort((a:Parametrico,b:Parametrico)=>{
        return a.nombre > b.nombre ?1:-1;
      })),

    )
    //-------------------------------------------------------------------------------------------------------
    this.$nivelEducativo = this.parametricosSrv.getParametricos(PARAMETRICOS.NIVEL_EDUCATIVO);
  }

  public seleccionarMultiCampo(campo:string, $event: { itemData: Parametrico; }){
    let itemData:Parametrico = $event.itemData;
    let motivosForm =this.registrarForm.get(campo) as FormArray;
    motivosForm.markAsDirty();
    motivosForm.markAsTouched();
    motivosForm.updateValueAndValidity();
    if(itemData.id !== null)
    motivosForm.push(new FormControl(itemData.id))
  }

  public quitarMulticampo(campo:string, $event: { itemData: Parametrico; }){

    let motivosForm =this.registrarForm.get(campo) as FormArray;
    let i = motivosForm.controls.findIndex((control)=> control.value == $event.itemData.id);
    motivosForm.removeAt(i);

  }

  /** *
  @todo: agregar el tema de los headers para el envio del archivo
  {
       headers:{
        "Content-Type":"multipart/form-data; boundary=---------------------------293582696224464"
        //    'encType': 'multipart/form-data'
      }
    }
  **/
  public guardar(){

    this.modalopen(ModalLoadingComponent);

      let $httpMethodAction;
      if(this.getFormControl('id').value == null){
        $httpMethodAction =  this.http.post(
          environment.urlAPI+"/vacante",
          this.toFormData(this.registrarForm))
      }else{
        $httpMethodAction =  this.http.put(
          environment.urlAPI+"/vacante",
          this.toFormData(this.registrarForm))
      }

      let subscriber = {


        next:(response:any)=>{
          const idAntesEnvio = this.getFormControl('id').value
          this.getFormControl('id').setValue(response.id)
          this.getFormControl('identificador').setValue(response.identificador);
          const estadoVacnte = this.getFormControl("estadoId").value;
          const nombre = this.getFormControl("nombre").value;
          const identificador = response["identificador"];
          const mensaje= this.mensajeConfirmacionRegistroVacante(idAntesEnvio,response);
          // (estadoVacnte === 1)?`Se ha registrado la vacante  ${nombre} ${identificador}, puede continuar completando la información para finalizar el registro.`:`Tu vacante ${nombre} ${identificador} ha sido registrada con éxito.`;

          this.modalopen(ModalSuccessFormComponent,mensaje);
        },
        error:(error: any)=>{

          if(error?.error?.errors?.CodigoInternoVacante !== undefined){
            this.modalopen(ModalErrorFormComponent, error["error"].errors!.CodigoInternoVacante.join(",") );
          }else{
            this.modalopen(ModalErrorFormComponent,"Ocurrio un error al Guardar.");
          }
          console.error("Error del servidor al intentar guardar",error,this.registrarForm.value);
          console.log(error.error["errors"]);
          // alert("Ocurrio un error al Guardar");
        }};

      $httpMethodAction.subscribe(subscriber)
  }


  public cargarVacante(vacanteId:string, copia=false){
    this.http.get<any>(
      environment.urlAPI+"/vacante/"+vacanteId).pipe(map((vacante:any)=>{
        vacante.estadoId = vacante.estado.id;

        if(copia){
          vacante.id = null;
          vacante.identificador = null;
          vacante.estadoId = ESTADO_VACANTE.EN_PROCESO;
          vacante.codigoInternoVacante=null;

        }

        if(vacante.fechaEstimadaOcupacionCargo!=null){
          vacante.fechaEstimadaOcupacionCargo = this.convertStringToDate(vacante.fechaEstimadaOcupacionCargo)//DateTime.local(vacante.fechaEstimadaOcupacionCargo).toJSON();
        }
        if(vacante.fechaVencimientoVacante!=null){
          vacante.fechaVencimientoVacante = this.convertStringToDate(vacante.fechaVencimientoVacante)//DateTime.local(vacante.fechaVencimientoVacante).toJSON();
        }
        if(vacante.fechaLimiteEnvioHv!=null){
          vacante.fechaLimiteEnvioHv = this.convertStringToDate(vacante.fechaLimiteEnvioHv)//DateTime.local(vacante.fechaLimiteEnvioHv).toJSON();
        }
        return vacante;
      }))?.subscribe(vacante => {

        this.registrarForm.patchValue(vacante);
        // -----------------------------------------------------------
        // CARGANDO LAS UBICACIONES
        // -----------------------------------------------------------

        let ubicaciones =  vacante.ubicaciones.map((ubicacion: Partial<{ departamentoID: number | null; municipioID: number | null; localidadComunaId: number | null; numeroPuestos: number | null; }>)=>{
          let ubicacionVacante = newUbicacionVacante();
          ubicacionVacante.patchValue(ubicacion);
          return ubicacionVacante;
        });
        ubicaciones.forEach((ubicacion: UbicacionVacante) => {
          this.getArrayControl("ubicaciones").push(ubicacion);
        });
        // -----------------------------------------------------------
        // CARGANDO LOS IDIOMAS
        // -----------------------------------------------------------
        let idiomas = vacante.idiomas.map((idioma: Partial<{ idiomaId: number | null; nivelConversacionalId: number | null; nivelLecturaId: number | null; nivelEscrituraId: number | null; nivelEscuchaId: number | null; }>)=>{
          let idiomaVacante = newIdioma();
          idiomaVacante.patchValue(idioma);
          return idiomaVacante;
        })
        idiomas.forEach((idioma: Idioma) => {
          this.getArrayControl("idiomas").push(idioma);
        });
        // -----------------------------------------------------------
        // prestadoresAlternos
        // -----------------------------------------------------------
      vacante.prestadoresAlternos.map((prestador: string) =>{
          return new FormControl(prestador);
        }).forEach((prestador: FormControl) => {
          this.getArrayControl("prestadoresAlternos").push(prestador);
        });







      // -----------------------------------------------------------
      // motivosExcepcionalidad
      // -----------------------------------------------------------
      vacante.motivosExcepcionalidad.map((motivoExcepcionalidad: string) =>{
        return new FormControl(motivoExcepcionalidad);
      }).forEach((motivoExcepcionalidad: FormControl) => {
        this.getArrayControl("motivosExcepcionalidad").push(motivoExcepcionalidad);
      });
      // -----------------------------------------------------------
      // discapacidades
      // -----------------------------------------------------------
      vacante.discapacidades.map((discapacidad: string) =>{
        return new FormControl(discapacidad.toString());
      }).forEach((discapacidad: FormControl) => {
        this.getArrayControl("discapacidades").push(discapacidad);
      });
      // -----------------------------------------------------------
      // denominacionesRelacionadas
      // -----------------------------------------------------------
      vacante.denominacionesRelacionadas.map((denominacionRelacionada: string) =>{
        return new FormControl(denominacionRelacionada);
      }).forEach((denominacionRelacionada: FormControl) => {
        this.getArrayControl("denominacionesRelacionadas").push(denominacionRelacionada);
      });
      // -----------------------------------------------------------
      // conocimientosCompetencias
      // -----------------------------------------------------------
      vacante.conocimientosCompetencias.map((conocimientoCompetencia: string) =>{
        return new FormControl(conocimientoCompetencia);
      }).forEach((conocimientoCompetencia: FormControl) => {
        this.getArrayControl("conocimientosCompetencias").push(conocimientoCompetencia);
      });
      // -----------------------------------------------------------
      // habilidadesDestrezas
      // -----------------------------------------------------------
      vacante.habilidadesDestrezas.map((habilidadDestreza: string) =>{
        return new FormControl(habilidadDestreza);
      }).forEach((habilidadDestreza: FormControl) => {
        this.getArrayControl("habilidadesDestrezas").push(habilidadDestreza);
      });


      // -----------------------------------------------------------
      // tipo de poblacion
      // -----------------------------------------------------------

      vacante.poblacionesVulnerables.map((poblacionesVulnerables: string) =>{
        return new FormControl(poblacionesVulnerables.toString());
      }).forEach((poblacionesVulnerables: FormControl) => {
        this.getArrayControl("poblacionesVulnerables").push(poblacionesVulnerables);
      });


      // -----------------------------------------------------------
      // tipo de grupos etnicos
      // -----------------------------------------------------------

      vacante.gruposEtnicos.map((gruposEtnicos: string) =>{
        return new FormControl(gruposEtnicos.toString());
      }).forEach((gruposEtnicos: FormControl) => {
        this.getArrayControl("gruposEtnicos").push(gruposEtnicos);
      });


      // -----------------------------------------------------------
      // tipo de poblacion
      // -----------------------------------------------------------

      vacante.tiposPoblacion.map((tiposPoblacion: string) =>{
        return new FormControl(tiposPoblacion.toString());
      }).forEach((tiposPoblacion: FormControl) => {
        this.getArrayControl("tiposPoblacion").push(tiposPoblacion);
      });

      // -----------------------------------------------------------
      // tipo de condicionesSaludMental
      // -----------------------------------------------------------

      vacante.condicionesSaludMental.map((condicionesSaludMental: string) =>{
        return new FormControl(condicionesSaludMental.toString());
      }).forEach((condicionesSaludMental: FormControl) => {
        this.getArrayControl("condicionesSaludMental").push(condicionesSaludMental);
      });


      // -----------------------------------------------------------
      // tipo de zonas geograficas
      // -----------------------------------------------------------

      vacante.zonasGeograficas.map((zonasGeograficas: string) =>{
        return new FormControl(zonasGeograficas.toString());
      }).forEach((zonasGeograficas: FormControl) => {
        this.getArrayControl("zonasGeograficas").push(zonasGeograficas);
      });






        this.onVacanteCargadaParaEditar.next(true);
      })
  }

  private toFormData<T extends AbstractControl>( formValue: T ) {
    const formData = new FormData();
    if(this.solicitudAutorizacionExcepcionalidadFile != null){
      formData.append("solicitudAutorizacionExcepcionalidadFile",
      this.solicitudAutorizacionExcepcionalidadFile.files[0],
      this.solicitudAutorizacionExcepcionalidadFile.files[0].name);
    }else if(this.getFormControl('solicitudAutorizacionExcepcionalidadFilePath').value == null){
      formData.append("solicitudAutorizacionExcepcionalidadFile","");
    }

    if(this.isVacanteHidrocarburos()){
      formData.append('gestionadaPorPrestador','true');
    }

    for ( const key of Object.keys(formValue.value) ) {

      const value = formValue.get(key)?.value;

      if(value === null || value ==="null" ){

      }
      else if(Array.isArray(value) && value.length === 0){

      }else if(Array.isArray(value) ){
        value.forEach((element,i) => {

          // si el elemento es un OBJETO
          if( typeof element === 'object'){
            //-------------------------------
            //caso especial para fechas
            let fechas = ['fechaEstimadaOcupacionCargo','fechaVencimientoVacante','fechaLimiteEnvioHv']
            if(fechas.includes(key)){
              try {
                formData.append(key, DateTime.fromObject(element).toFormat(this.dateformat))
              } catch (error) {
                console.error("Fecha no reconocida",key,element,error);
              }
            }else{
              //-------------------------------
              let keys = Object.keys(element)
              keys.forEach(k =>{
                //Guarda KEY[i].campo1
                //Guarda KEY[i].campo2
                if(element[k] !== null){
                  formData.append(key+"["+i+"]."+k,element[k]);
                }

              })
            }
          }else{
            //si es un arreglo
            formData.append(key+"["+i+"]",element)
          }
        });
      }
      else if(typeof value === 'object'){


        //caso especial para fechas
        let fechas = ['fechaEstimadaOcupacionCargo','fechaVencimientoVacante','fechaLimiteEnvioHv']
        if(fechas.includes(key)){
          try {
            formData.append(key, DateTime.fromObject(value).toFormat(this.dateformat))
          } catch (error) {
            console.error("Fecha no reconocida",key,value,error);
          }
        }else{
          let keys = Object.keys(value)
          keys.forEach(k =>{
            //Guarda KEY.campo1
            //Guarda KEY.campo2
            formData.append(key+"."+k,value[k]);
          })
        }


      }
      else{
        formData.append(key, value);
      }
    }

    return formData;
  }

  private controlIsValid(formControlName:string){
    return (this.getFormControl(formControlName).dirty ) && !this.getFormControl(formControlName).errors;
  }
  private controlIsInvalid(formControlName:string){
    return (this.getFormControl(formControlName).dirty ) && this.getFormControl(formControlName).errors
  }

  public formControlValidStyle(formControlName:string){
    try {
      return {
        "is-valid": this.getFormControl(formControlName).dirty && !this.getFormControl(formControlName).errors,
        "is-invalid": this.getFormControl(formControlName).dirty && this.getFormControl(formControlName).errors,
      };
    } catch (error) {
      console.log("error con el campo",formControlName,error);
      return {}
    }

  }


  // indica si un campo tiene un tipo de error de validacion
  public isValid(error:string, formControlName:string){
    try {
      let control = this.getFormControl(formControlName);
      if(control.errors !=null){
        const controlErrors: ValidationErrors = control.errors;
        return Object.keys(controlErrors).includes(error)==true?false:true;
      }else{
        return true
      }
    } catch (error) {
      console.error("isValid:",formControlName," ",error)
      return true;
    }
  }

  public isDirtyOrTouched(formControlName:string){
    try {

      return this.getFormControl(formControlName).dirty || this.getFormControl(formControlName).touched;
    } catch (error) {
      console.log("isDirtyOrTouched_ Campo no existe",formControlName);
      return true;

    }
  }
  public getRequiredMinlength(formControlName:string){
    let errors = this.getFormControl(formControlName).errors
    if(errors!=null){
      return errors['minlength']['requiredLength']
    }
  }
  public getRequiredMaxlength(formControlName:string){
    let errors = this.getFormControl(formControlName).errors
    if(errors!=null){
      return errors['maxlength']['requiredLength']
    }
  }


  public getRequiredMin(formControlName:string){
    let errors = this.getFormControl(formControlName).errors
    if(errors!=null){
      return errors['min']['min']
    }
  }

  public getRequiredMax(formControlName:string){
    let errors = this.getFormControl(formControlName).errors
    if(errors!=null){
      return errors['max']['max']
    }
  }


  public caracteresFaltantes(formControlName:string, cantidad:number){
    try {
      let restantes = cantidad - Number(this.registrarForm.get(formControlName)?.value?.length);
      if(isNaN(restantes)){
        return cantidad;
      }
      return restantes;
    } catch (error) {
      return 0;
    }
  }





/**
 * Determina si la vacante que se esta registrando es de tipo hidrocarburos,
 * Validando si el subsector seleccionado es SUB_SECTOR_ECONOMICO_HIDROCARBUROS
 */
  public isVacanteHidrocarburos(){
    const SUB_SECTOR_ECONOMICO_HIDROCARBUROS = "1";
    try {
      let subsectorEconomicoId = this.getFormControl("subsectorEconomicoId");
      return subsectorEconomicoId.value == SUB_SECTOR_ECONOMICO_HIDROCARBUROS;
    } catch (error) {
      return false;
    }
  }



  /**
   * CALCULOS DE HIDROCARBUROS
   */

  /**
   * Una vacante exige Mano de obra calificada cuando el minimo nivel educativo requerido es TECNICO LABORAL
   */
  public calcularManoDeObraCalificada(){
    const NIVEL_EDUCATIVO_TECNICO_LABORAL = 6;
    let nivelMinimoEstudioId = this.getFormControl("nivelMinimoEstudioId")
    // Arreglo que define los niveles educativos para que la mano de obra sea SI - true
    const arrNivelesManoObraSi = [6, 7, 8, 9, 10, 11, 12];
    return arrNivelesManoObraSi.includes(+nivelMinimoEstudioId.value)
  }


  public calcularRangoRemitirCandidatoInicial(){
    let manoDeObraCalificada = this.getFormControl("manoObraCalificada").value;
    let puestosRequeridos = this.getArrayControl("puestosRequeridos").value;

    if(manoDeObraCalificada == true){
      // Numero de puestos de trabajo * 10    | MOC = true
      return puestosRequeridos * 10;
    }else{
      // Numero de puestos de trabajo * 15    | MOC = false
      return puestosRequeridos * 15;

    }
  }
  public calcularRangoRemitirCandidatoFinal(){
    let manoDeObraCalificada = this.getFormControl("manoObraCalificada").value;
    let puestosRequeridos = this.getArrayControl("puestosRequeridos").value;
    if(manoDeObraCalificada == true){
      // Numero de puestos de trabajo * 15    | MOC = true
      return puestosRequeridos * 15;
    }else{
      // Numero de puestos de trabajo * 20    | MOC = false
      return puestosRequeridos * 20;

    }
  }



public modalopen(component:any,content:any = null){ //ModalLoadingComponent
  this.modalService.dismissAll();
  const modalRef= this.modalService.open(component, {
    centered: true , animation: true,backdrop: 'static'
  });

  modalRef.componentInstance.body = content;//{Tipo:"error",Mensaje:"Error al consultar detalle de vacante"}
  return modalRef;
}

public convertStringToDate(dateStrFull: string | null | undefined) {
  if (dateStrFull !== '' && dateStrFull !== null && dateStrFull !== undefined) {
    // Format 2014-12-25T00:00:00
    const date = new Date(dateStrFull);
    return { year: date.getFullYear(), month: date.getMonth() + 1, day: date.getDate() };
  }
  return undefined;
  }

public mensajeConfirmacionRegistroVacante(idAntesEnvio:any,response:any){
  const estadoVacnte = this.getFormControl("estadoId").value;
  const nombre = this.getFormControl("nombre").value;
  const identificador = response["identificador"];
  const accionMensaje = (idAntesEnvio==null)?"registrada":"modificada"
  const mensaje= (estadoVacnte === 1)?`Tu vacante ${nombre} ${identificador} ha sido ${accionMensaje} con éxito, puede continuar completando la información para finalizar el registro.`:`Tu vacante ${nombre} ${identificador} ha sido ${accionMensaje} con éxito.`;
  return mensaje;
}


public formControlInfo(name:string):VacanteControlPro{
 const controlInfo =  formControlVacanteInfo();
 type ObjectKey = keyof typeof formControlVacanteInfo;
 const nameKey = name as ObjectKey;
 return (controlInfo[nameKey] === undefined)?{name,nameNav:""}:controlInfo[nameKey];
}


public enableOrDisableField(enable:boolean|string, control:FormControl){
  console.log(control)
  if(enable == true){
    control.addValidators([Validators.required])
    control.enable()
  }else{
    control.setValue(null);
    control.removeValidators([Validators.required])
    control.disable()
    control.markAsPristine()
    control.markAsUntouched()
  }
}


}

