import { Prestador } from "./prestador";

export interface Parametrico {
  id: string;
  nombre: string;
  sigla?: string;
  coberturaNacional?: string;
  idDepartamento?: string;
  PrestadorId?: string;
  departamentoId?: string;
  valorInicial?: number;
  valorFinal?: number;
  tipo?: string;
  orden?: number;
  equivalencias?: number;
  principal?: boolean;
  nacionalidad?: string;
  descripcion?: string;
  grupoPrimario?: string;
  ocupacionNueva?: string;
  cuocOcupacionId?: string;
  fuenteDenominacion?: string;
  codigoCNO?: string;
  codigoCIUO?: string;
  rural?:boolean;
  tipoZonaGeograficaId?: string;
  detalle?: string;
  codigo?: string;
  nivelEducativoId?: number;
  nucleoConocimientoId?: number;
  contenido?: string;
  sectorEconomicoId?: number;
  texto?: string;
  institucionId?: number;
  areaConocimientoId?: number;
  cuocConocimientoId?: string;
  avance?: number;
  tipoVacanteId?: number;
  peso?: number;
  estado?: boolean;
  fechaCreacion?: string;
  fechaModificacion?: string;
}

export interface ParametricoListado {
  id: string;
  nombre: string;
}

export interface ParametricosStorage {
  TipoDocumento?: Parametrico[];
  Genero?: Parametrico[];
  Pais?: Parametrico[];
  Departamento?: Parametrico[];
  PreguntaSeguridad?: Parametrico[];
  Eps?: Parametrico[];
  EstadoCivil?: Parametrico[];
  Municipio?: Parametrico[];
  RangoSalarial?: Parametrico[];
  SituacionActualTrabajo?: Parametrico[];
}

export interface ParametricoSalario {
  nombre:           string;
  valorInicial:     number;
}
