import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, map, throwError } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable()
export class ListadoVacantesService {

  public paginacion: Paginacion = {
    "TotalRegistros": 0,
    "RegistrosPorPagina": 10,
    "PaginaActual": 1,
    "CandidadPagina": 0,
    "Siguiente": false,
    "Anterior": false
  };


  public size=10000;
  public page=3;

  constructor(public http: HttpClient) {

  }

public consultarVacante(vacanteId:string){
  return this.http.get<VacanteDetalle>(`${environment.urlAPI}/vacante/${vacanteId}`)
}
  
  public consultarListadoVacantes(pagina: number = 1, RegistrosPorPagina: number = 10, SedeId:number = 4, EstadoId?:number) {
    const estado = (EstadoId !== undefined)?`&EstadoId=${EstadoId}`:"";
    return this.http.get<VacanteRequest[]>(`${environment.urlAPI}/vacante?Pagina=${pagina}&RegistrosPorPagina=${RegistrosPorPagina}&SedeId=${SedeId}${estado}`, { observe: 'response' })
      .pipe(
        map((vacantes) => {
          return {            
            body: vacantes.body?.map((vacante) => (
              <VacanteLista>{
                id: vacante.Id,
                nombre: vacante.Nombre ?? "",
                fechaVencimientoVacante: vacante.FechaVencimientoVacante ?? "",
                fechaLimiteEnvioHv: vacante.FechaLimiteEnvioHv ?? "",
                Departamentos: vacante.Ubicaciones?.map((u => u?.Departamento)).join(" - "),
                Municipios: vacante.Ubicaciones?.map((u => u.Municipio)).join(" - "),
                puestosRequeridos: vacante.PuestosRequeridos ?? "",
                estado: vacante.Estado?.Nombre ?? "",
                Empresa:vacante.Empresa?.RazonSocial,
                correo: vacante.Empresa?.Sede?.Responsable?.Correo,
                EsHidrocarburos:(vacante.EsHidrocarburos==true)?"Si":"No"
              })),
            headers: vacantes.headers
          }
        }), catchError(error => {
          console.log(error);
          return throwError('vacantes no Encontrada....');
        })
      )
  }

  

}

export interface Idioma {
  idiomaId: number;
  conversacional: number;
  lectura: number;
  escritura: number;
  escucha: number;
}



export interface VacanteDetalle {
  id: string;
  identificador: string;
  nombre: string;
  puestosRequeridos: number;
  modalidadTrabajoId: string;
  sectorEconomicoId: number;
  subsectorEconomicoId: number;
  requiereViajarPorTrabajo: boolean;
  tendraPersonasCargo: boolean;
  requiereLicenciaConduccion: boolean;
  requiereLicenciaConduccionCarro: boolean;
  categoriaLicenciaCarroId: number;
  requiereLicenciaConduccionMoto: boolean;
  categoriaLicenciaMotoId: number;
  areaEmpresaId: number;
  responsableId: string;
  fechaEstimadaOcupacionCargo: Date;
  fechaVencimientoVacante: Date;
  fechaLimiteEnvioHv: Date;
  confidencial: boolean;
  solicitudExcepcionalidad: boolean;
  aptaParaPersonasConDiscapacidad: boolean;
  gestionadaPorPrestador: boolean;
  gestionadaPorPrestadorAlterno: boolean;
  formacionTitulo: string;
  graduado: boolean;
  nivelMinimoEstudioId: number;
  requiereExperienciaGeneral: boolean;
  tiempoExperiencia: number;
  requiereExperienciaEspecifica: boolean;
  descripcionExperienciaEspecifica: string;
  requiereCapacitacionEspecifica: boolean;
  descripcionCapacitacionEspecifica: string;
  requiereCertificacionEspecifica: boolean;
  descripcionCertificacionEspecifica: string;
  informacionAdicional: string;
  descripcion: string;
  tipoContratoId: string;
  jornadaLaboralId: string;
  tipoSalarioId: number;
  rangoSalarialInicial: number;
  rangoSalarialFinal: number;
  periodicidadSalarialId: number;
  visibilidadSalario: boolean;
  compensacionAdicional: boolean;
  descripcionCompensacionAdicional: string;
  videoUrl: string;
  videoDescripcion: string;
  solicitudAutorizacionExcepcionalidadFilePath: string;
  sedeId: number;
  tieneVideoAdjunto: boolean;
  tipoProyectoId: number;
  codigoInternoVacante: string;
  manoObraCalificada: boolean;
  rangoRemitirCandidatoInicial: number;
  rangoRemitirCandidatoFinal: number;
  priorizarZonaRural: boolean;
  priorizarPoblacionVulnerable: boolean;
  perteneceARural: boolean;
  registroVacanteDemasPrestadores: boolean;
  esHidrocarburos: boolean;
  estado: Estado;
  prestadoresAlternos: string[];
  motivosExcepcionalidad: number[];
  discapacidades: number[];
  idiomas: Idioma[];
  denominacionesRelacionadas: string[];
  conocimientosCompetencias: string[];
  habilidadesDestrezas: string[];
  poblacionesVulnerables: number[];
  gruposEtnicos: number[];
  condicionesSaludMental: number[];
  tiposPoblacion: number[];
  ubicaciones: Ubicacion[];
  zonasGeograficas: number[];
  esHidrocarburo:boolean
}



export interface Ubicacion {
  Departamento?: string;
  Municipio?: string;
  LocalidadComuna?: string;
  NumeroPuestos?: number;
}

export interface Estado {
  Id?: number;
  Nombre?: string;
}

export interface Responsable {
  Correo?: string;
  Nombre?: string;
}

export interface Sede {
  SedeId: string;
  Nombre?: any;
  Responsable?: Responsable;
}

export interface Empresa {
  RazonSocial?: string;
  Sede?: Sede;
}

export interface VacanteRequest {
  Id?: string;
  Nombre?: string;
  FechaVencimientoVacante?: Date;
  FechaLimiteEnvioHv?: Date;
  Ubicaciones?: Ubicacion[];
  PuestosRequeridos?: number;
  Estado?: Estado;
  Empresa?: Empresa;
  EsHidrocarburos:boolean
}



export interface VacanteLista {
  id?: string;
  nombre?: string;
  fechaVencimientoVacante?: Date;
  fechaLimiteEnvioHv?: Date;
  Departamentos?: string;
  Municipios?: string;
  puestosRequeridos?: number;
  estado?: string;
  ResponsableId?: string;
  correo?: string;
  Empresa?:string;
  EsHidrocarburos?:string;
}

export interface Paginacion {
  TotalRegistros: number;
  RegistrosPorPagina: number;
  PaginaActual: number;
  CandidadPagina: number;
  Siguiente: boolean;
  Anterior: boolean;
}