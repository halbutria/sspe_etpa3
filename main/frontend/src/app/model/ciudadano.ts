export interface CreateRequest {
  tipoDocumentoId:            number;
  numeroDocumento:            string;
  correoElectronico:          string;
  primerNombre:               string;
  segundoNombre:              string;
  primerApellido:             string;
  segundoApellido:            string;
  fechaNacimiento:            string;
  sexoId:                   number;
  telefono:                   string;
  direccionResidencia:        string;
  paisResidenciaId:           string;
  departamentoId:             string;
  municipioId:                string;
  prestadorPreferenciaId:     string;
  puntoAtencionId:            string;
  perteneceARural:            boolean;
  preguntaSeguridadId:        number;
  preguntaSeguridadRespuesta: string;
  terminosCondiciones:        boolean;
  tratamientoDatosPersonales: boolean;
  password:                   string;
  tipoNotificacion:           number[];
  direcciones:                Direccion[] | any;
  fechaExpedicionDocumento:   string;
  estado:                     string;
  ciudad:                     string;
  estadoNacimiento:           string;
  ciudadNacimiento:           string;
}

export interface Ciudadano {
  ciudadanoId:                string;
  usuarioId:                  string;
  numeroDocumento:            string;
  primerNombre:               string;
  segundoNombre:              string;
  primerApellido:             string;
  segundoApellido:            string;
  fechaNacimiento:            string;
  tipoDocumentoId:            number;
  tipoDocumentoNombre:        string;
  correoElectronico:          string;
  departamentoId:             string;
  departamentoNombre:         string;
  municipioId:                string;
  municipioNombre:            string;
  generoId:                   number;
  generoNombre:               string;
  telefono:                   string;
  direccionResidencia:        string;
  paisResidenciaId:           string;
  paisResidenciaNombre:       string;
  prestadorPreferenciaId:     string;
  prestadorPreferenciaNombre: string;
  puntoAtencionId:            string;
  puntoAtencionNombre:        string;
}

export interface CiudadanoCv {
  id:                         string;
  usuarioId:                  string;
  tipoDocumentoId:            number;
  numeroDocumento:            string;
  correoElectronico:          string;
  primerNombre:               string;
  segundoNombre:              string;
  primerApellido:             string;
  segundoApellido:            string;
  fechaNacimiento:            string;
  generoId:                   number;
  telefono:                   string;
  direccionResidencia:        string;
  paisResidenciaId:           number;
  departamentoId:             string;
  municipioId:                string;
  prestadorPreferenciaId:     string;
  puntoAtencionId:            string;
  preguntaSeguridadId:        number;
  preguntaSeguridadRespuesta: string;
  estadoCivilId:              number;
  paisNacimientoId:           number;
  tieneLibretaMilitar:        boolean;
  tipoLibretaMilitar:         number;
  numeroLibretaMiltar:        string;
  departamentoNacimientoId:   string;
  municipioNacimientoId:      string;
  nacionalidad:               string;
  jefeHogar:                  boolean;
  poblacionFocalizada:        boolean;
  sisben:                     boolean;
  epsId:                      number;
  barrioResidencia:           string;
  perteneceARural:            number;
  otroTelefono:               string;
  fechaExpedicionDocumento:   string;
  estado:                     string;
  ciudad:                     string;
  estadoNacimiento:           string;
  ciudadNacimiento:           string;
  certificadoResidencia:      boolean;
  observacion:                string;
  rangoSalarialId:            number;
  grupoEtnico:              number[];
  tipoPoblacion:            number[];
  condicionDiscapacidad:    number[];
  condicionSaludMental:     number[];
  estrato:                    number;
  perfilLaboral:              string;
  posibilidadViajar:          boolean;
  posibilidadTrasladarse:     boolean;
  interesOfertasTeletrabajo:  boolean;
  situacionLaboralActual:     number;
  propiedadMedioTransporte:   boolean;
  tieneLicenciaConduccionCarro:  boolean;
  categoriaLicenciaCarroId:   number;
  tieneLicenciaConduccionMoto:     boolean;
  categoriaLicenciaMotoId:    number;
  tipoNotificacion:           number[];
  cargoIneteres:              string[];
}

export interface CiudadanoGet {
  id:                         string;
  numeroDocumento:            string;
  primerNombre:               string;
  segundoNombre:              string;
  primerApellido:             string;
  segundoApellido:            string;
  fechaNacimiento:            string;
  tipoDocumento:              ObjIdNombre;
  correoElectronico:          string;
  departamento:               ObjIdNombre;
  municipio:                  ObjIdNombre;
  genero:                     ObjIdNombre;
  telefono:                   string;
  direccionResidencia:        string;
  paisResidencia:             ObjIdNombre;
  prestadorPreferenciaId:     string;
  prestadorPreferenciaNombre: string;
  puntoAtencionId:            string;
  puntoAtencionNombre:        string;
  tieneLibretaMilitar:        boolean;
  tipoLibretaMilitar:         number;
  numeroLibretaMiltar:        string;
  nacionalidadId:             string;
  jefeHogar:                  boolean;
  dispuestoDesplazarseDiariamente:  boolean;
  dispuestoCambiarMunicipio:        boolean;
  poblacionFocalizada:        boolean;
  sisben:                     boolean;
  barrioResidencia:           string;
  otroTelefono:               string;
  fechaExpedicionDocumento:   string;
  estado:                     string;
  ciudad:                     string;
  estadoNacimiento:           string;
  ciudadNacimiento:           string;
  certificadoResidencia:      boolean;
  observacion:                string;
  estrato:                    number;
  perfilLaboral:              string;
  posibilidadViajar:          boolean;
  posibilidadTrasladarse:     boolean;
  interesOfertasTeletrabajo:  boolean;
  propiedadMedioTransporte:   boolean;
  tieneLicenciaConduccionCarro:  boolean;
  tieneLicenciaConduccionMoto:     boolean;
  tieneEducacionFormal:       boolean;
  interesPracticaEmpresarial: boolean;
  tieneEducacionNoFormal:     boolean;
  tieneInformacionLaboral:     boolean;
  tieneExperienciaLaboral:     boolean;
  estadoCivil:                ObjIdNombre;
  paisNacimiento:             ObjIdNombre;
  departamentoNacimiento:     ObjIdNombre;
  municipioNacimiento:        ObjIdNombre;
  eps:                        ObjIdNombre;
  rangoSalarial:              ObjIdNombre;
  grupoEtnico:                number[];
  condicionDiscapacidad:      number[];
  condicionSaludMental:       number[];
  categoriaLicenciaCarro:     ObjIdNombre;
  categoriaLicenciaMoto:      ObjIdNombre;
  perteneceARural:              boolean;
  situacionLaboralActual:     ObjIdNombre;
  situacionLaboralActualId:   number;
  tipoPoblacion:              number[];
  porcentajeHv:               number;
  porcentajeInfoPersonal:     number;
  porcentajeEduFormal:        number;
  porcentajeInfoLaboral:      number;
  porcentajeEduNoFormal:      number;
  porcentajeRegistro:         number;
  autorregistro:              boolean;
  hojaVidaCompleta:           boolean;
  estadoCiudadanoId:          number;
  direcciones:                Direccion[];
  cargoIneteres:              string[];
}

export interface Direccion {
  id:                             string;
  ciudadanoId?:                   string;
  viaPrincipalId:                 string;
  viaPrincipalNombre:             string;
  viaPrincipal:                   string;
  viaPrincipalLetraId:            string;
  viaPrincipalLetraNombre:        string;
  viaPrincipalBisId:              string;
  viaPrincipalBisNombre:          string;
  viaPrincipalSegundaLetraId:     string;
  viaPrincipalSegundaLetraNombre: string;
  viaPrincipalCuadranteId:        string;
  viaPrincipalCuadranteNombre:    string;
  viaGeneradora:                  number;
  viaGeneradoraLetraId:           string;
  viaGeneralLetraNombre:          string;
  viaGeneradoraPlaca:             number;
  viaGeneradoraCuadranteId:       string;
  viaGeneradoraCuadranteNombre:   string;
  direccionComplemento:     Complemento[];
}

export interface Complemento {
  direccionId:       string;
  complementoId:     string;
  complementoNombre: string;
  complemento:       string;
}

export interface ObjIdNombre {
  map(arg0: (t: any) => import("@angular/forms").FormControl<any>): any;
  id:     number;
  nombre: string;
}

/**
 * Modelo Educación Formal de la hoja de vida
 */
export interface EducacionFormal {
  id?:                                string;
  ciudadanoId?:                       string;
  nucleoConocimientoId:               number | null;
  nivelEducativoId:                   number;
  areaConocimientoId:                 number | null;
  tituloObtenido?:                    string;
  tituloHomologadoId:                 number | any;
  institucion?:                       string;
  institucionId?:                     number | null;
  paisId:                             number | null;
  estadoId:                           number;
  fechaFinalizacion:                  string | any;
  tarjetaProfesional:                boolean;
  numeroTarjetaProfesional:           string;
  fechaExpedicionTarjetaProfesional:  string | any;
  observacion?:                       string;
  practicaEmpresarial:               boolean;
}
export interface TieneEducacionFormal {
  ciudadanoId:          string;
  tieneEducacionFormal: boolean;
}

/**
 * Modelos Información Laboral de la hoja de vida
 */
export interface InformacionLaboral {
  id?:                                       string;
  ciudadanoId:                               string;
  tipoExperienciaId:                         number;
  nombreEmpresa:                             string;
  fechaIngreso:                              string;
  fechaRetiro:                               string;
  trabajoActual:                             boolean;
  sectorId:                                  number;
  telefonoEmpresa:                           string;
  paisId:                                    number;
  cargo:                                     string;
  ocupacionEquivalenteId:                    number;
  conocimientoId:                            number;
  habilidadId:                               string;
  productoServicioProduceComercializa:       string;
  cuantasPresonasTrabajanConUsted:           number;
  conocimientoCompetenciaInformacionLaboral: string[];
  habilidadDestrezaInformacionLaboral:       string[];
}
export interface TieneInformacionLaboral {
  ciudadanoId:             string;
  tieneInformacionLaboral: boolean;
}
export interface Conocimiento {
  informacionLaboralId: string;
  conocimientoId?:      number;
  nombre:               string;
  rutaCertificado:      string;
}
export interface Habilidad {
  informacionLaboralId: string;
  habilidadId?:         number;
  nombre:               string;
  rutaCertificado:      string;
}

/**
 * Modelos Educación No Formal de la hoja de vida
 */
export interface EducacionNoFormal {
  id?:                           string;
  ciudadanoId:                   string;
  tipoCertificadoCapacitacionId: number;
  nombrePrograma:                string;
  institucion:                   string;
  paisId:                        number;
  estadoId:                      number;
  duracion:                      number | null;
  fechaCertificacion:            string;
}
export interface TieneEducacionNoFormal {
  ciudadanoId:          string;
  tieneEducacionNoFormal: boolean;
}

/**
 * Modelos Idiomas de la hoja de vida
 */
export interface Idioma {
  id?:          string;
  ciudadanoId:  string;
  idiomaId:     number;
  nivelEscrito: string;
  nivelHablado: string;
  nivelEscucha: string;
  nivelLectura: string;
}

/**
 * Modelos Experiencias Previas de la hoja de vida
 */
export interface ExperienciaPrevia {
  id?:                                      string;
  ciudadanoId:                              string;
  nombre:                                   string;
  telefono:                                 number;
  tipoExperienciaId:                        number;
  ciudadanoEducacionFormalId:               number;
  ocupacionId:                              number;
  lugarExperiencia:                         string;
  fechaIngreso:                             string;
  fechaRetiro:                              string;
  conocimientoCompetenciaExperienciaPrevia: string[];
  habilidadDestrezaExperienciaPrevia:       string[];
}
export interface TieneExperienciaPrevia {
  ciudadanoId:            string;
  tieneExperienciaLaboral: boolean;
}

/**
 * Modelos Conocimientos y destrezas de la hoja de vida
 */
export interface ConocimientoModel {
  id?:                    string;
  ciudadanoId:            string;
  conocimientoId:         string;
  nombre?:                string;
}
export interface DestrezaModel {
  id?:                    string;
  ciudadanoId:            string;
  habilidadId:            string;
  nombre?:                string;
}

export interface PorcentajesCv {
  porcentajeHv:           number;
  porcentajeRegistro:     number;
  porcentajeInfoPersonal: number;
  porcentajeEduFormal:    number;
  porcentajeInfoLaboral:  number;
  porcentajeEduNoFormal:  number;
}

/**
 * Modelo para redes sociales del perfil de hoja de vida
 */
export interface RedSocial {
  id:                     string;
  ciudadanoId:            string;
  redSocialId?:           number;
  nombreRedSocial?:       string | any;
  nombreUsuarioRedSocial: string;
}
