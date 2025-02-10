import { EventEmitter, Injectable, Output } from '@angular/core';
import { of, Observable, map, tap } from "rxjs";
import {
  HttpClient,
  HttpHeaders,
  HttpErrorResponse,
  HttpResponse,
} from "@angular/common/http";

import { PARAMETRICOS, ParametricosService, PARAMETRICOS_FILTROS } from 'src/app/services/parametricos.service';
import { environment } from "../../environments/environment";
import {
  Ciudadano, CiudadanoGet, EducacionFormal, TieneEducacionFormal,
  InformacionLaboral, TieneInformacionLaboral, EducacionNoFormal, TieneEducacionNoFormal,
  Idioma,
  ExperienciaPrevia,
  TieneExperienciaPrevia,
  ConocimientoModel,
  DestrezaModel,
  PorcentajesCv,
  RedSocial
} from "../model/ciudadano";
import { Parametrico } from 'src/app/model/parametricos';

@Injectable({
  providedIn: 'root'
})
export class CvService {

  @Output() tabActive: EventEmitter<number> = new EventEmitter<number>();
  @Output() updateCiudadano: EventEmitter<CiudadanoGet | undefined> = new EventEmitter<CiudadanoGet | undefined>();

  public $tiposDocumento: Observable<Parametrico[]>;
  public $paisesNacimiento: Observable<Parametrico[]>;
  public $departamentosNacimiento: Observable<Parametrico[]>;
  // public $municipiosNacimiento: Observable<Parametrico[]>;
  public $paisesResidencia: Observable<Parametrico[]>;
  public $departamentosResidencia: Observable<Parametrico[]>;
  // public $municipiosResidencia: Observable<Parametrico[]>;
  public $estadosCivil: Observable<Parametrico[]>;
  public $generos: Observable<Parametrico[]>;
  public $orientacionSexual: Observable<Parametrico[]>;
  public $sexos: Observable<Parametrico[]>;
  public $tipoLibretaMilitar: Observable<Parametrico[]>;
  public $eps: Observable<Parametrico[]>;
  public $situacionActualTrabajo: Observable<Parametrico[]>;
  public $rangoSalarial: Observable<Parametrico[]>;
  public $categoriaLicencia: Observable<Parametrico[]>;
  public $denominaciones: Observable<Parametrico[]>;
  public $grupoEtnico: Observable<Parametrico[]>;
  public $tipoPoblacion: Observable<Parametrico[]>;
  public $discapacidad: Observable<Parametrico[]>;
  public $saludMental: Observable<Parametrico[]>;
  // Educacion formal
  public $nivelEducativo: Observable<Parametrico[]>;
  public $nucleoConocimiento: Observable<Parametrico[]>;
  public $areaConocimiento: Observable<Parametrico[]>;
  public $estadoEducacion: Observable<Parametrico[]>;
  public $tituloHomologado: Observable<Parametrico[]>;
  public $institucion: Observable<Parametrico[]>;
  // Informacion Laboral
  public $tipoExperiencia: Observable<Parametrico[]>;
  public $sector: Observable<Parametrico[]>;
  // Educación No Formal
  public $tipoCapacitacion: Observable<Parametrico[]>;
  public $estadoEducacionNoFormal: Observable<Parametrico[]>;
  // Idiomas
  public $idiomas: Observable<Parametrico[]>;
  // Conocimientos y destrezas
  public $cuocConocimientosBase: Observable<Parametrico[]>;
  public $cuocDestrezasBase: Observable<Parametrico[]>;
  // Experiencia Previa
  public $tipoExpPrevia: Observable<Parametrico[]>;
  // Redes Sociales
  public $redSocial: Observable<Parametrico[]>;

  constructor(
    private http: HttpClient,
    public parametricosService: ParametricosService) {
    /**
     * Carga de paramétricos
     */
    this.$tiposDocumento = this.parametricosService.getParametricos(PARAMETRICOS.TIPOS_DOCUMENTO);
    this.$paisesNacimiento = this.parametricosService.getParametricos(PARAMETRICOS.PAISES);
    this.$departamentosNacimiento = this.parametricosService.getParametricos(PARAMETRICOS.DEPARTAMENTOS);
    // this.$municipiosNacimiento = this.parametricosService.getParametricos(PARAMETRICOS.MUNICIPIO, PARAMETRICOS_FILTROS.MUNICIPIO__DEPARTAMENTO_ID, '0');
    this.$paisesResidencia = this.parametricosService.getParametricos(PARAMETRICOS.PAISES);
    this.$departamentosResidencia = this.parametricosService.getParametricos(PARAMETRICOS.DEPARTAMENTOS);
    // this.$municipiosResidencia = this.parametricosService.getParametricos(PARAMETRICOS.MUNICIPIO, PARAMETRICOS_FILTROS.MUNICIPIO__DEPARTAMENTO_ID, '0');
    this.$estadosCivil = this.parametricosService.getParametricos(PARAMETRICOS.ESTADOS_CIVIL);
    this.$generos = of([
      {id:"1", nombre:"Masculino"},
      {id:"2", nombre:"Femenino"},
      {id:"3", nombre:"Transgénero"},
      {id:"4", nombre:"Prefiero no responder"},
      {id:"5", nombre:" Me identificó con un género no indicado anteriormente"}
    ]);
    
    // this.parametricosService.getParametricos(PARAMETRICOS.GENEROS)
    // .pipe(
    //   tap((data:Parametrico[]) => {
    //     data.push({
    //             id:"0",
    //             nombre:"Otro"
    //           });
    //   })
    // );
    
    this.$orientacionSexual = of([
      {id:"1", nombre:"Heterosexual"},
      {id:"2", nombre:"Gay/Lesbiana"},
      {id:"3", nombre:"Bisexual"},
      {id:"4", nombre:"Prefiero no responder"},
      {id:"5", nombre:" Me identificó con un género no indicado anteriormente"}
    ]);
    
    // this.parametricosService.getParametricos(PARAMETRICOS.GENEROS)//ORIENTACIONSEXUAL
    // .pipe(
    //   tap((data:Parametrico[]) => {
    //     data.push({
    //             id:"0",
    //             nombre:"Otro O"
    //           });
    //   })
    // );

    this.$sexos = this.parametricosService.getParametricos(PARAMETRICOS.GENEROS);//SEXOS
    this.$tipoLibretaMilitar = this.parametricosService.getParametricos(PARAMETRICOS.TIPO_LIBRETA_MILITAR);
    this.$eps = this.parametricosService.getParametricos(PARAMETRICOS.EPS);
    this.$situacionActualTrabajo = this.parametricosService.getParametricos(PARAMETRICOS.SITUACION_ACT_TRABAJO);
    this.$rangoSalarial = this.parametricosService.getParametricos(PARAMETRICOS.RANGO_SALARIAL);
    this.$categoriaLicencia = this.parametricosService.getParametricos(PARAMETRICOS.CATEGORIA_LICENCIA);
    this.$denominaciones = this.parametricosService.getParametricos(PARAMETRICOS.DENOMINACIONES);
    this.$grupoEtnico = this.parametricosService.getParametricos(PARAMETRICOS.GRUPO_ETNICO);
    this.$tipoPoblacion = this.parametricosService.getParametricos(PARAMETRICOS.TIPO_POBLACION);
    this.$discapacidad = this.parametricosService.getParametricos(PARAMETRICOS.DISCAPACIDAD);
    this.$saludMental = this.parametricosService.getParametricos(PARAMETRICOS.SALUD_MENTAL);
    // Educación formal
    this.$nivelEducativo = this.parametricosService.getParametricos(PARAMETRICOS.NIVEL_EDUCATIVO).pipe(
      map(list => {
        return list.filter(item => item.id !== '1');
      })
    );
    this.$nucleoConocimiento = this.parametricosService.getParametricos(PARAMETRICOS.NUCLEO_CONOCIMIENTO);
    this.$areaConocimiento = this.parametricosService.getParametricos(PARAMETRICOS.AREA_CONOCIMIENTO);
    this.$estadoEducacion = this.parametricosService.getParametricos(PARAMETRICOS.ESTADO_EDUCACION);
    this.$tituloHomologado = this.parametricosService.getParametricos(PARAMETRICOS.TITULO_HOMOLOGADO);
    this.$institucion = this.parametricosService.getParametricos(PARAMETRICOS.INSTITUCION);
    // Informacion Laboral
    this.$tipoExperiencia = this.parametricosService.getParametricos(PARAMETRICOS.TIPO_EXPERIENCIA);
    this.$sector = this.parametricosService.getParametricos(PARAMETRICOS.SECTOR);
    // Educación No Formal
    this.$tipoCapacitacion = this.parametricosService.getParametricos(PARAMETRICOS.TIPO_CAPACITACION);
    this.$estadoEducacionNoFormal = this.parametricosService.getParametricos(PARAMETRICOS.ESTADO_EDUCACION_NO_FORMAL);
    // Idiomas
    this.$idiomas = this.parametricosService.getParametricos(PARAMETRICOS.IDIOMA);
    // Conocimientos y destrezas
    this.$cuocConocimientosBase = this.parametricosService.getParametricos(PARAMETRICOS.CONOCIMIENTOS_BASE);
    this.$cuocDestrezasBase = this.parametricosService.getParametricos(PARAMETRICOS.DESTREZAS_BASE);
    // Experiencia Previa
    this.$tipoExpPrevia = this.parametricosService.getParametricos(PARAMETRICOS.TIPO_EXPERIENCIA_PREVIA);
    // Redes Sociales
    this.$redSocial = this.parametricosService.getParametricos(PARAMETRICOS.RED_SOCIAL);
  }

  get getCiudadano(): CiudadanoGet | any {
    const itemSession = sessionStorage.getItem('Ciudadano');
    if (itemSession) {
      return JSON.parse(itemSession);
    } else {
      return null;
    }
  }

  /**
   * Función que setea o guarda la información del cuidadano luego del login
   */
  public setCiudadano(data: CiudadanoGet | Ciudadano | any) {
    sessionStorage.setItem('Ciudadano', JSON.stringify(data));
    this.updateCiudadano.emit(data);
  }

  public resetCiudadano() {
    sessionStorage.removeItem('Ciudadano');
  }

  public toggleBooleanDataCiudadano(key: string, value: boolean) {
    let dataCiudadano = this.getCiudadano;
    if (dataCiudadano !== undefined) {
      dataCiudadano[key] = value;
      this.setCiudadano(dataCiudadano);
    }
  }

  /**
   * Servicios para lógica de la pestaña Educación Formal
   */
  public addFormalEducation(data: EducacionFormal): Observable<EducacionFormal> {
    const url = `${environment.urlCiudadano}/EducacionFormal`;
    return this.http.post<EducacionFormal>(url, data);
  }
  public editFormalEducation(data: EducacionFormal): Observable<EducacionFormal> {
    const url = `${environment.urlCiudadano}/EducacionFormal`;
    return this.http.put<EducacionFormal>(url, data);
  }
  public deleteFormalEducation(id: string | undefined): Observable<any> {
    const url = `${environment.urlCiudadano}/EducacionFormal/${id}`;
    return this.http.delete<any>(url);
  }
  public putTieneEducacionFormal(ciudadanoId: string | undefined, tieneEducacionFormal: boolean): Observable<TieneEducacionFormal> {
    const url = `${environment.urlCiudadano}/CambioTieneEducacionFormal`;
    return this.http.put<TieneEducacionFormal>(url, { ciudadanoId, tieneEducacionFormal });
  }
  public getListEducacionFormal(ciudadanoId: string | undefined, filtroGraduado: boolean | null = null): Observable<EducacionFormal[]> {
    let url = `${environment.urlCiudadano}/EducacionFormal/lista/${ciudadanoId}`;
    if (filtroGraduado !== null) {
      url += `?Graduado=${filtroGraduado}`;
    }
    return this.http.get<EducacionFormal[]>(url);
  }

  /**
   * Servicios para lógica de la pestaña Información Laboral
   */
  public addWorkingInformation(data: InformacionLaboral): Observable<InformacionLaboral> {
    const url = `${environment.urlCiudadano}/InformacionLaboral`;
    return this.http.post<InformacionLaboral>(url, data);
  }
  public editWorkingInformation(data: InformacionLaboral): Observable<InformacionLaboral> {
    const url = `${environment.urlCiudadano}/InformacionLaboral`;
    return this.http.put<InformacionLaboral>(url, data);
  }
  public deleteWorkingInformation(id: string | undefined): Observable<any> {
    const url = `${environment.urlCiudadano}/InformacionLaboral/${id}`;
    return this.http.delete<any>(url);
  }
  public putTieneExperienciaLaboral(ciudadanoId: string | undefined, tieneInformacionLaboral: boolean): Observable<TieneInformacionLaboral> {
    const url = `${environment.urlCiudadano}/CambioTieneInformacionLaboral`;
    return this.http.put<TieneInformacionLaboral>(url, { ciudadanoId, tieneInformacionLaboral });
  }
  public getListInformacionLaboral(ciudadanoId: string | undefined): Observable<InformacionLaboral[]> {
    const url = `${environment.urlCiudadano}/InformacionLaboral/lista/${ciudadanoId}`;
    return this.http.get<InformacionLaboral[]>(url);
  }

  /**
   * Servicios para lógica de la pestaña Educación No Formal
   */
  public addNoFormalEducation(data: EducacionNoFormal): Observable<EducacionNoFormal> {
    const url = `${environment.urlCiudadano}/EducacionNoFormal`;
    return this.http.post<EducacionNoFormal>(url, data);
  }
  public editNoFormalEducation(data: EducacionNoFormal): Observable<EducacionNoFormal> {
    const url = `${environment.urlCiudadano}/EducacionNoFormal`;
    return this.http.put<EducacionNoFormal>(url, data);
  }
  public deleteNoFormalEducation(id: string | undefined): Observable<any> {
    const url = `${environment.urlCiudadano}/EducacionNoFormal/${id}`;
    return this.http.delete<any>(url);
  }
  public putTieneEducacionNoFormal(ciudadanoId: string | undefined, tieneEducacionNoFormal: boolean): Observable<TieneEducacionNoFormal> {
    const url = `${environment.urlCiudadano}/CambioTieneEducacionNoFormal`;
    return this.http.put<TieneEducacionNoFormal>(url, { ciudadanoId, tieneEducacionNoFormal });
  }
  public getListEducacionNoFormal(ciudadanoId: string | undefined): Observable<EducacionNoFormal[]> {
    const url = `${environment.urlCiudadano}/EducacionNoFormal/lista/${ciudadanoId}`;
    return this.http.get<EducacionNoFormal[]>(url);
  }

  /**
   * Cargues de listados de campos de la direccion
   */
  get getListViaPrincipal() {
    return [
      { id: 'CL', texto: 'CALLE' },
      { id: 'KR', texto: 'CARRERA' },
      { id: 'DG', texto: 'DIAGONAL' },
      { id: 'TV', texto: 'TRANSVERSAL' },
      { id: 'AV', texto: 'AVENIDA' },
      { id: 'AC', texto: 'AVENIDA CALLE' },
      { id: 'AK', texto: 'AVENIDA CARRERA' },
      { id: 'AU', texto: 'AUTOPISTA' },
      { id: 'CQ', texto: 'CIRCULAR' },
      { id: 'CV', texto: 'CIRCUNVALAR' },
      // { id: 'CC', texto: 'Cuentas' },
      // { id: 'PJ', texto: 'Pasaje' },
      // { id: 'PS', texto: 'Paseo' },
      // { id: 'PT', texto: 'Peatonal' },
      // { id: 'TC', texto: 'Troncal' },
      // { id: 'VT', texto: 'Variante' },
      // { id: 'VI', texto: 'Via' },
      // { id: 'Otro', texto: 'Otro' },
      // { id: 'AGRUPACIÓN', texto: 'Agrupación' },
      // { id: 'APTO', texto: 'Apartamento' },
      // { id: 'BL', texto: 'Bloque' },
      // { id: 'BUL', texto: 'Bulevar' },
      // { id: 'BÓDEGA', texto: 'Bódega' },
      // { id: 'CARRETERA', texto: 'Carretera' },
      // { id: 'CASA', texto: 'Casa' },
      // { id: 'COMUNAL', texto: 'Comunal' },
      // { id: 'CONJ', texto: 'Conjunto' },
      // { id: 'CONSULTORIO', texto: 'Consultorio' },
      // { id: 'DEPO', texto: 'Déposito' },
      // { id: 'EDIF', texto: 'Edificio' },
      // { id: 'ENTRADA', texto: 'Entrada' },
      // { id: 'ESQUINA', texto: 'Esquina' },
      // { id: 'ETAPA', texto: 'Etapa' },
      // { id: 'GJ', texto: 'Garaje' },
      // { id: 'INT', texto: 'Interior' },
      // { id: 'KM', texto: 'Kilómetro' },
      // { id: 'LOCAL', texto: 'Local' },
      // { id: 'LOTE', texto: 'Lote' },
      // { id: 'MZ', texto: 'Manzana' },
      // { id: 'MEZZ', texto: 'Mezzanine' },
      // { id: 'MÓDULO', texto: 'Módulo' },
      // { id: 'OF', texto: 'Oficina' },
      // { id: 'PARCELA', texto: 'Parcela' },
      // { id: 'PASEO', texto: 'Paseo' },
      // { id: 'PENTHOUSE', texto: 'Penthouse' },
      // { id: 'PISO', texto: 'Piso' },
      // { id: 'PH', texto: 'Propiedad' },
      // { id: 'SALON', texto: 'Salón' },
      // { id: 'SECTOR', texto: 'Sector' },
      // { id: 'SEMISOTANO', texto: 'Semisótano' },
      // { id: 'SOLAR', texto: 'Solar' },
      // { id: 'SOTANO', texto: 'Sótano' },
      // { id: 'SUPERMZ', texto: 'Super' },
      // { id: 'TORRE', texto: 'Torre' },
      // { id: 'UN', texto: 'Unidad' },
      // { id: 'VEREDA', texto: 'Vereda' },
      // { id: 'VIA', texto: 'Vía' },
      // { id: 'ZN', texto: 'Zona' },
      // { id: 'Otros', texto: 'Otros' },
    ];
  }
  get getListComplementos() {
    return [
      { id: 'AGRUPACIÓN', texto: 'Agrupación' },
      { id: 'APTO', texto: 'Apartamento' },
      { id: 'BL', texto: 'Bloque' },
      { id: 'BÓDEGA', texto: 'Bódega' },
      { id: 'AU', texto: 'Autopista' },
      { id: 'CARRETERA', texto: 'Carretera' },
      { id: 'CASA', texto: 'Casa' },
      { id: 'COMUNAL', texto: 'Comunal' },
      { id: 'CONJ', texto: 'Conjunto' },
      { id: 'CONSULTORIO', texto: 'Consultorio' },
      { id: 'DEPO', texto: 'Déposito' },
      { id: 'EDIF', texto: 'Edificio' },
      { id: 'ENTRADA', texto: 'Entrada' },
      { id: 'ESQUINA', texto: 'Esquina' },
      { id: 'ETAPA', texto: 'Etapa' },
      { id: 'GJ', texto: 'Garaje' },
      { id: 'INT', texto: 'Interior' },
      { id: 'KM', texto: 'Kilómetro' },
      { id: 'LOCAL', texto: 'Local' },
      { id: 'LOTE', texto: 'Lote' },
      { id: 'MZ', texto: 'Manzana' },
      { id: 'MEZZ', texto: 'Mezzanine' },
      { id: 'MÓDULO', texto: 'Módulo' },
      { id: 'OF', texto: 'Oficina' },
      { id: 'PARCELA', texto: 'Parcela' },
      { id: 'PASEO', texto: 'Paseo' },
      { id: 'PENTHOUSE', texto: 'Penthouse' },
      { id: 'PISO', texto: 'Piso' },
      { id: 'PH', texto: 'Propiedad' },
      { id: 'SALON', texto: 'Salón' },
      { id: 'SECTOR', texto: 'Sector' },
      { id: 'SEMISOTANO', texto: 'Semisótano' },
      { id: 'SOLAR', texto: 'Solar' },
      { id: 'SOTANO', texto: 'Sótano' },
      { id: 'SUPERMZ', texto: 'Super' },
      { id: 'TORRE', texto: 'Torre' },
      { id: 'UN', texto: 'Unidad' },
      { id: 'VEREDA', texto: 'Vereda' },
      { id: 'VIA', texto: 'Vía' },
      { id: 'ZN', texto: 'Zona' },
    ];
  }

  /**
   * Servicios para lógica de la pestaña Idiomas
   */
  public addIdioma(data: Idioma): Observable<Idioma> {
    const url = `${environment.urlCiudadano}/Idioma`;
    return this.http.post<Idioma>(url, data);
  }
  public editIdioma(data: Idioma): Observable<Idioma> {
    const url = `${environment.urlCiudadano}/Idioma`;
    return this.http.put<Idioma>(url, data);
  }
  public deleteIdioma(id: string | undefined): Observable<any> {
    const url = `${environment.urlCiudadano}/Idioma/${id}`;
    return this.http.delete<any>(url);
  }
  public getListIdioma(ciudadanoId: string | undefined): Observable<Idioma[]> {
    const url = `${environment.urlCiudadano}/Idioma/lista/${ciudadanoId}`;
    return this.http.get<Idioma[]>(url);
  }

  /**
   * Servicios para lógica de la pestaña Experiencia previa
   */
  public addPreviousExperience(data: ExperienciaPrevia): Observable<ExperienciaPrevia> {
    const url = `${environment.urlCiudadano}/Experiencia`;
    return this.http.post<ExperienciaPrevia>(url, data);
  }
  public editPreviousExperience(data: ExperienciaPrevia): Observable<ExperienciaPrevia> {
    const url = `${environment.urlCiudadano}/Experiencia`;
    return this.http.put<ExperienciaPrevia>(url, data);
  }
  public deletePreviousExperience(id: string | undefined): Observable<any> {
    const url = `${environment.urlCiudadano}/Experiencia/${id}`;
    return this.http.delete<any>(url);
  }
  public putTieneExperienciaPrevia(ciudadanoId: string | undefined, tieneExperienciaLaboral: boolean): Observable<TieneExperienciaPrevia> {
    const url = `${environment.urlCiudadano}/Ciudadano/CambioTieneExperienciaPrevia`;
    return this.http.put<TieneExperienciaPrevia>(url, { ciudadanoId, tieneExperienciaLaboral });
  }
  public getListPreviousExperience(ciudadanoId: string | undefined): Observable<ExperienciaPrevia[]> {
    const url = `${environment.urlCiudadano}/Experiencia/lista/${ciudadanoId}`;
    return this.http.get<ExperienciaPrevia[]>(url);
  }

  /**
   * Servicios para lógica de la pestaña Conocimientos y destrezas
   */
  public addConocimientos(data: ConocimientoModel): Observable<ConocimientoModel> {
    const url = `${environment.urlCiudadano}/ConocimientoCompetencia`;
    return this.http.post<ConocimientoModel>(url, data);
  }
  public editConocimientos(data: ConocimientoModel): Observable<ConocimientoModel> {
    const url = `${environment.urlCiudadano}/ConocimientoCompetencia`;
    return this.http.put<ConocimientoModel>(url, data);
  }
  public deleteConocimientos(id: string | undefined): Observable<any> {
    const url = `${environment.urlCiudadano}/ConocimientoCompetencia/${id}`;
    return this.http.delete<any>(url);
  }
  public getConocimientos(ciudadanoId: string | undefined): Observable<ConocimientoModel[]> {
    const url = `${environment.urlCiudadano}/ConocimientoCompetencia/lista/${ciudadanoId}`;
    return this.http.get<ConocimientoModel[]>(url);
  }
  public addDestrezas(data: DestrezaModel): Observable<DestrezaModel> {
    const url = `${environment.urlCiudadano}/HabilidadDestreza`;
    return this.http.post<DestrezaModel>(url, data);
  }
  public editDestrezas(data: DestrezaModel): Observable<DestrezaModel> {
    const url = `${environment.urlCiudadano}/HabilidadDestreza`;
    return this.http.put<DestrezaModel>(url, data);
  }
  public deleteDestrezas(id: string | undefined): Observable<any> {
    const url = `${environment.urlCiudadano}/HabilidadDestreza/${id}`;
    return this.http.delete<any>(url);
  }
  public getDestrezas(ciudadanoId: string | undefined): Observable<DestrezaModel[]> {
    const url = `${environment.urlCiudadano}/HabilidadDestreza/lista/${ciudadanoId}`;
    return this.http.get<DestrezaModel[]>(url);
  }

  /**
   * Servicios para lógica del CRUD de resdes sociales hacia el API
   */
  public addRedSocial(data: RedSocial): Observable<RedSocial> {
    const url = `${environment.urlCiudadano}/RedesSociales`;
    return this.http.post<RedSocial>(url, data);
  }
  public editRedSocial(data: RedSocial): Observable<RedSocial> {
    const url = `${environment.urlCiudadano}/RedesSociales`;
    return this.http.put<RedSocial>(url, data);
  }
  public deleteRedSocial(id: string | undefined): Observable<any> {
    const url = `${environment.urlCiudadano}/RedesSociales/${id}`;
    return this.http.delete<any>(url);
  }
  public getListRedSocial(ciudadanoId: string | undefined): Observable<RedSocial[]> {
    const url = `${environment.urlCiudadano}/RedesSociales/lista/${ciudadanoId}`;
    return this.http.get<RedSocial[]>(url);
  }

  /**
   * Función que proporciona el cambio de pestaña sobre la hoja de vida
   */
  public changeTabActive(tab: number) {
    this.tabActive.emit(tab);
  }

  /**
   * Función que con el id del ciudadano consulta los porcentajes actualizados de la hoja de vida al API
   */
  public getPorcentajesAvance(ciudadanoId: string | undefined): Observable<PorcentajesCv> {
    const url = `${environment.urlCiudadano}/PorcentajesAvance/${ciudadanoId}`;
    return this.http.get<PorcentajesCv>(url);
  }

  /**
   * Función que recibe los porcentajes y actualiza la data en storage y emite cambio en vivo
   */
  public updatePorcentajes(porcentajes: PorcentajesCv) {
    if (porcentajes) {
      let ciudadanotmp = this.getCiudadano;
      ciudadanotmp.porcentajeHv = porcentajes.porcentajeHv;
      ciudadanotmp.porcentajeRegistro = porcentajes.porcentajeRegistro;
      ciudadanotmp.porcentajeInfoPersonal = porcentajes.porcentajeInfoPersonal;
      ciudadanotmp.porcentajeEduFormal = porcentajes.porcentajeEduFormal;
      ciudadanotmp.porcentajeInfoLaboral = porcentajes.porcentajeInfoLaboral;
      ciudadanotmp.porcentajeEduNoFormal = porcentajes.porcentajeEduNoFormal;
      this.setCiudadano(ciudadanotmp);
    }
  }
  /**
   * Funcion que se encarga de actualizar los nombres y apellidos del ciudadano en la hoja de vida
   */
  public updateFullName(pNombre: string, sNombre: string, pApellido: string, sApellido: string) {
    let ciudadanotmp = this.getCiudadano;
    ciudadanotmp.primerNombre = pNombre;
    ciudadanotmp.segundoNombre = sNombre;
    ciudadanotmp.primerApellido = pApellido;
    ciudadanotmp.sApellido = sApellido;
    this.setCiudadano(ciudadanotmp);
  }

  /**
   * Funcion que se encarga de convertir un objeto fecha a strind de acuerdo al formato de guardado del API
   */
  public convertSringDate(date: any): string | any {
    if (date !== '' && date !== undefined && date !== null) {
      const month = date.month < 10 ? '0' + date.month : date.month;
      const day = date.day < 10 ? '0' + date.day : date.day;
      return date.year + '-' + month + '-' + day;
    } else {
      return null;
    }
  }
  /**
   * Función que se encarga de convertir una fecha string a objeto para ser mostado en los campos de fecha
   */
  public convertStringToDate(dateStrFull: string | null | undefined) {
    if (dateStrFull !== '' && dateStrFull !== null && dateStrFull !== undefined) {
      // Format 2014-12-25T00:00:00
      const date = new Date(dateStrFull);
      return { year: date.getFullYear(), month: date.getMonth() + 1, day: date.getDate() };
    }
    return undefined;
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
}
