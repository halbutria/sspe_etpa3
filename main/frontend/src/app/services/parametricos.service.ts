import { Injectable } from '@angular/core';
import { of, Observable, Subscriber, UnaryFunction, pipe, map, forkJoin } from "rxjs";
import {
  HttpClient,
  HttpHeaders,
  HttpErrorResponse,
  HttpResponse,
} from "@angular/common/http";

import { environment } from "../../environments/environment";
import { Parametrico, ParametricoSalario, ParametricosStorage } from "../model/parametricos";

export enum PARAMETRICOS {
  MODALIDAD_TRABAJO            =  'ModalidadTrabajo',
  SECTOR_ECONOMICO             =  'SectorEconomico',
  SUB_SECTOR_ECONOMICO         =  'SubsectorEconomico',
  DEPARTAMENTOS                =  'Departamento',
  MUNICIPIO                    =  'Municipio',
  LOCALIDAD                    =  'Localidad',
  COMUNA                       =  'Comuna',
  CATEGORIA_LICENCIA           =  'CategoriaLicencia',
  AREA_EMPRESA                 =  'AreaEmpresa',
  MOTIVO_EXCEPCIONALIDAD       =  'MotivoExcepcionalidad',
  DISCAPACIDAD                 =  'Discapacidad',
  NIVEL_EDUCATIVO              =  'NivelEducativo',
  NIVEL_DOMINIO_IDIOMA         =  'NivelDominioIdioma',
  IDIOMA                       =  'Idioma',
  TIPO_CONTRATO                =  'TipoContrato',
  JORNADA_LABORAL              =  'JornadaLaboral',
  TIPO_SALARIO                 =  'TipoSalario',
  PERIODICIDAD_SALARIAL        =  'PeriodicidadSalarial',
  SALARIO_MENSUAL              =  'salario',
  TIPOS_DOCUMENTO              =  'TipoDocumento',
  ESTADOS_CIVIL                =  'EstadoCivil',
  GENEROS                      =  'Genero',
  SEXOS                        =  'Sexo',
  ORIENTACIONSEXUAL                        =  'OrientacionSexual',
  TIPO_LIBRETA_MILITAR         =  'TipoLibretaMilitar',
  PAISES                       =  'Pais',
  EPS                          =  'Eps',
  SITUACION_ACT_TRABAJO        =  'SituacionActualTrabajo',
  RANGO_SALARIAL               =  'RangoSalarial',
  DENOMINACIONES               =  'CUOCDenominacion',
  CONOCIMIENTOS                =  'CUOCConocimiento',
  DESTREZAS                    =  'CUOCDestreza',
  //                           Hidrocarburos
  TIPOS_PROYECTOS_HIDRO        =  'TipoProyecto',
  //                           REGISTRO DE HV
  GRUPO_ETNICO                 =  'GrupoEtnico',
  TIPO_POBLACION               =  'TipoPoblacion',
  TIPO_POBLACION_VULNERABLE    =  'TipoPoblacionVulnerable',
  SALUD_MENTAL                 =  'CondicionSaludMental',
  //                           Educacion formal
  NUCLEO_CONOCIMIENTO          =  'NucleoConocimiento',
  AREA_CONOCIMIENTO            =  'AreaConocimiento',
  ESTADO_EDUCACION             =  'EstadoEducacion',
  TITULO_HOMOLOGADO            =  'TituloHomologado',
  INSTITUCION                  =  'Institucion',
  //                           Información Laboral
  TIPO_EXPERIENCIA             =  'TipoExperiencia',
  SECTOR                       =  'Sector',
  //                           Educación No Formal
  TIPO_CAPACITACION            =  'TipoCursoComplementario',
  ESTADO_EDUCACION_NO_FORMAL   =  'EstadoEducacionNoFormal',
  //                           Conocimientos y destrezas
  CONOCIMIENTOS_BASE           =  'CUOCConocimientoBase',
  DESTREZAS_BASE               =  'CUOCDestrezaBase',
  //                           Experiencia Previa
  TIPO_EXPERIENCIA_PREVIA      =  'TipoExperienciaPrevia',
  //                           Redes Sociales
  RED_SOCIAL                   =  'RedSocial',
  TIPO_ZONA_GEOGRAFICA              =  'TipoZonaGeografica',



}

export enum PARAMETRICOS_FILTROS {
  MUNICIPIO__DEPARTAMENTO_ID                   = "departamentoID"    ,
  SUB_SECTOR_ECONOMICO__SECTOR_ECONOMICO_ID    = "sectorEconomicoID" ,
  LOCALIDAD__MUNICIPIO_ID                      = "MunicipioId"       ,
  COMUNA__MUNICIPIO_ID                         = "MunicipioId"       ,
  CONOCIMIENTOS__OCUPACION_ID                  = "OcupacionId",
  DESTREZAS__OCUPACION_ID                      = "OcupacionId",
}

@Injectable({
  providedIn: 'root'
})
export class ParametricosService {

  constructor(private http: HttpClient) { }
  /**
   * propiedad que almacena los parametricos que no se guardan en session storage
   */
  public parametricosExcluidosData:{
    [key:string]:Parametrico[]
  }={};
  /**
   * Funcion que consulta algún parametrico y devuelve un arreglo con los valores
   */
  public getParametricosDefault(tipo: string): Observable<Parametrico[]> {
    const url = `${environment.urlParametrico}/parametrico/lista/${tipo}`;
    return this.http.get<Parametrico[]>(url);
  }

  /**
   * Funcion que consume API para consultar los municipios por un departamento
   */
  public getMunicipiosByDepto(tipo: string, deptoId: string): Observable<Parametrico[]> {
    const url = `${environment.urlParametrico}/parametrico/lista/${tipo}?depratmentoID=${deptoId}`;
    return this.http.get<Parametrico[]>(url);
  }

  /**
   * Funcion que consume API para consultar algún parmétrico que dependa de otro valor (un solo valor)
   */
  public getParametricoById(tipo: string, tipoValue: string, value: string): Observable<Parametrico[]> {
    const url = `${environment.urlParametrico}/parametrico/lista/${tipo}?${tipoValue}=${value}`;
    return this.http.get<Parametrico[]>(url);
  }

  /**
   * Funcion que consume API para consultar los puntos de atención por un prestador de preferencia
   */
  public getPuntosAtencionByPrestador(tipo: string, prestadorId: string): Observable<Parametrico[]> {
    const url = `${environment.urlParametrico}/parametrico/lista/${tipo}?prestadorID=${prestadorId}`;
    return this.http.get<Parametrico[]>(url);
  }

  /**
   * Función que agrega paramétrico al session storage
   */
  public addParametricoSessionStorage(keyInObject: string, value: any) {
    // Valida si existe la variable Parametricos en el session storage
    let parametricos: any = this.getParametricosSessionStorage;
    if (parametricos !== null) {
      parametricos[keyInObject] = value;
    }

    sessionStorage.setItem('Parametricos', JSON.stringify(parametricos));
  }

  get getParametricosSessionStorage(): ParametricosStorage {
    let parametricos: ParametricosStorage = {};
    const itemSession = sessionStorage.getItem('Parametricos');
    if (itemSession) {
      parametricos = JSON.parse(itemSession);
    }
    return parametricos;
  }
  /**
   * Funcion que devuelve la data de un parametrico del session storage
   */
  getDataKeyParametricosStorage(key: string): Parametrico[] {
    const parametricos: any = this.getParametricosSessionStorage;
    return parametricos[key];

  }
  /**
   * entrega el nombre de un parametrio por su id despues de la carga
   **/
public  buscarNameParametricoById<T extends Parametrico[]>(ID:string): UnaryFunction<Observable<T>, Observable<string>> {
  return pipe(
   map((parametricos:Parametrico[])=> parametricos.filter(parametrico => parametrico.id == ID )
                                .map(parametrico => parametrico.nombre)
                                .reduce((pv,cv)=>cv,""))
  );
}
  /**
   * Gestiona la entrega general de parametricos controlando el almacenamiento en Storage
   * @example
   * ´´´ts
   * this.serviceParametricos.getParametricos(PARAMETRICOS.DEPARTAMENTOS).pipe(...).subscribe(...);
   * this.serviceParametricos.getParametricos(PARAMETRICOS.MUNICIPIO,'departamentoID','0').pipe(...).subscribe(...);
   * ´´´
   */
  public loadingParametricos:{[key:string]:boolean}={}
  public isLoadingParametrico(TIPO_PARAMETRICO:PARAMETRICOS,tipoValue?: PARAMETRICOS_FILTROS, value?: string){
    try {
      const storageKey = `${TIPO_PARAMETRICO}_${tipoValue}_${value}`;
      return this.loadingParametricos[storageKey];
    } catch (error) {
      return false;
    }
  }
  public markLoadingParametrico(TIPO_PARAMETRICO:PARAMETRICOS,tipoValue?: PARAMETRICOS_FILTROS, value?: string){
    try {
      const storageKey = `${TIPO_PARAMETRICO}_${tipoValue}_${value}`;
      this.loadingParametricos[storageKey] = true;
    } catch (error) {}
  }
  public markLoadedParametrico(TIPO_PARAMETRICO:PARAMETRICOS,tipoValue?: PARAMETRICOS_FILTROS, value?: string){
    try {
      const storageKey = `${TIPO_PARAMETRICO}_${tipoValue}_${value}`;
      this.loadingParametricos[storageKey] = false;
    } catch (error) {}
  }
   public getParametricos(TIPO_PARAMETRICO:PARAMETRICOS,tipoValue?: PARAMETRICOS_FILTROS, value?: string, usarCache:boolean=true) {

    return new Observable((subscriber:Subscriber<Parametrico[]>)=>{
      try {
        const storageKey = `${TIPO_PARAMETRICO}_${tipoValue}_${value}`;

        const dataParametricosStorage = this.getDataKeyParametricosStorage(storageKey);
        let listDataParamentricos:Parametrico[];
        if (dataParametricosStorage !== undefined && usarCache && !this.excludeParametricosStorage().includes(TIPO_PARAMETRICO)) {
            listDataParamentricos = dataParametricosStorage;
            // subscriber.next([{id:"",nombre:"Seleccione una opción"},...listDataParamentricos]);
            subscriber.next(listDataParamentricos);
            subscriber.complete();
          }
          else if(Object.keys(this.parametricosExcluidosData).includes(storageKey)){
            console.log("Excluidos?")
            listDataParamentricos = this.parametricosExcluidosData[storageKey];
            subscriber.next([{id:"",nombre:""},...listDataParamentricos]);
            subscriber.complete();
          }
          else {
            let $getparametrico:Observable<Parametrico[]>;
            this.markLoadingParametrico(TIPO_PARAMETRICO, tipoValue, value);
            if(tipoValue && value) {
              $getparametrico = this.getParametricoById(TIPO_PARAMETRICO,tipoValue,value)
            }
            else {
              $getparametrico = this.getParametricosDefault(TIPO_PARAMETRICO)
            }
            $getparametrico.subscribe((response) => {
              listDataParamentricos = response;
              if (!this.excludeParametricosStorage().includes(TIPO_PARAMETRICO)){
                this.addParametricoSessionStorage(storageKey, listDataParamentricos);
              }else{
                this.parametricosExcluidosData[storageKey] = listDataParamentricos;
              }
              // subscriber.next([{id:"",nombre:"Seleccione una opción"},...listDataParamentricos]);
              subscriber.next(listDataParamentricos);
              this.markLoadedParametrico(TIPO_PARAMETRICO,tipoValue,value);
              subscriber.complete();
            });
          }
        } catch (error) {
            subscriber.error(error);
        }
    })

  }
  /**
   * Listado de parametricos que se excluyen del localStorage Por limites de almacenamiento
   **/
  public excludeParametricosStorage(){
    return [PARAMETRICOS.DENOMINACIONES, PARAMETRICOS.CONOCIMIENTOS, PARAMETRICOS.DESTREZAS];
  }

  public getById( id:string, parametrico:PARAMETRICOS,tipoValue?: PARAMETRICOS_FILTROS, value?: string){
    if(this.isLoadingParametrico(parametrico,tipoValue,value)){
      return of(id);
    }else{
      return this.getParametricos(parametrico,tipoValue,value)
      .pipe(this.buscarNameParametricoById(id))
    }

  }

  public getByIds( ids:string[], parametrico:PARAMETRICOS,tipoValue?: PARAMETRICOS_FILTROS, value?: string){
    if(this.isLoadingParametrico(parametrico,tipoValue,value)){
      return of(ids);
    }
    else {
        let parametricos:Observable<string>[] = [];
        ids.forEach(id=> parametricos.push(
          this.getParametricos(parametrico,tipoValue,value)
          .pipe(this.buscarNameParametricoById(id))
        ))
        return forkJoin(parametricos);
    }
  }

  public getParametricoSalario(): Observable<ParametricoSalario> {
    const url = `${environment.urlParametrico}/parametrico/salario`;
    return this.http.get<ParametricoSalario>(url);
  }
}
