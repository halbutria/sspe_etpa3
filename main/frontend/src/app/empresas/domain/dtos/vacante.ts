import { AbstractControl, FormArray, FormControl, FormGroup, MinLengthValidator, ValidationErrors, ValidatorFn, Validators } from "@angular/forms";
import { DateTime } from "luxon";
import { ESTADO_VACANTE } from "./estado-vacante";
import { Idioma } from "./idioma";
import { UbicacionVacante } from "./ubicacion-vacante";

  export interface Vacante {
      id: FormControl<string|null>;
      identificador: FormControl<string|null>;
      nombre: FormControl<string|null>;
      puestosRequeridos: FormControl<number|null>;
      modalidadTrabajoId: FormControl<number|null>;
      sectorEconomicoId: FormControl<number|null>;
      subsectorEconomicoId: FormControl<number|null>;
      requiereViajarPorTrabajo: FormControl<boolean|null>;
      tendraPersonasCargo: FormControl<boolean|null>;
      requiereLicenciaConduccion: FormControl<boolean|null>;
      requiereLicenciaConduccionCarro: FormControl<boolean|null>;
      categoriaLicenciaCarroId: FormControl<number|null>;
      requiereLicenciaConduccionMoto: FormControl<boolean|null>;
      categoriaLicenciaMotoId: FormControl<number|null>;
      areaEmpresaId: FormControl<number|null>;
      responsableId: FormControl<string|null>;
      fechaEstimadaOcupacionCargo:  FormControl<Date|null>;
      fechaVencimientoVacante: FormControl<Date|null>;
      fechaLimiteEnvioHv: FormControl<Date|null>;
      confidencial: FormControl<boolean|null>;
      solicitudExcepcionalidad: FormControl<boolean|null>;
      solicitudAutorizacionExcepcionalidadFile: FormControl<string|null>;
      solicitudAutorizacionExcepcionalidadFilePath: FormControl<string|null>;
      motivoId: FormControl<number|null>;
      aptaParaPersonasConDiscapacidad: FormControl<boolean|null>;
      gestionadaPorPrestador: FormControl<boolean|null>;
      gestionadaPorPrestadorAlterno: FormControl<boolean|null>;
      tipoProyectoId:FormControl<number|null>;
      codigoInternoVacante:FormControl<string|null>;
      manoObraCalificada:FormControl<boolean|null>;
      rangoRemitirCandidatoInicial:FormControl<boolean|null>;
      rangoRemitirCandidatoFinal:FormControl<boolean|null>;
      priorizarPoblacionVulnerable:FormControl<boolean|null>;
      priorizarZonaRural:FormControl<boolean|null>;
      formacionTitulo: FormControl<string|null>;
      graduado: FormControl<boolean|null>;
      nivelMinimoEstudioId: FormControl<number|null>;
      requiereExperienciaGeneral: FormControl<boolean|null>;
      tiempoExperiencia: FormControl<number|null>;
      requiereExperienciaEspecifica: FormControl<boolean|null>;
      descripcionExperienciaEspecifica: FormControl<string|null>;
      requiereCapacitacionEspecifica: FormControl<boolean|null>;
      descripcionCapacitacionEspecifica: FormControl<string|null>;
      requiereCertificacionEspecifica: FormControl<boolean|null>;
      descripcionCertificacionEspecifica: FormControl<string|null>;
      informacionAdicional: FormControl<string|null>;
      descripcion: FormControl<string|null>;
      tipoContratoId: FormControl<number|null>;
      jornadaLaboralId: FormControl<number|null>;
      tipoSalarioId: FormControl<number|null>;
      rangoSalarialInicial: FormControl<number|null>;
      rangoSalarialFinal: FormControl<number|null>;
      periodicidadSalarialId: FormControl<number|null>;
      visibilidadSalario: FormControl<boolean|null>;
      compensacionAdicional: FormControl<boolean|null>;
      descripcionCompensacionAdicional: FormControl<string|null>;
      tieneVideoAdjunto: FormControl<boolean|null>;
      videoUrl: FormControl<string|null>;
      videoDescripcion: FormControl<string|null>;
      sedeId: FormControl<number|null>;
      estadoId: FormControl<ESTADO_VACANTE|null>;
      prestadoresAlternos: FormArray<FormControl<number|null>>;
      poblacionesVulnerables: FormArray<FormControl<number|null>>;
      tiposPoblacion: FormArray<FormControl<number|null>>;
      gruposEtnicos: FormArray<FormControl<number|null>>;
      motivosExcepcionalidad: FormArray<FormControl<number|null>>;
      discapacidades:FormArray<FormControl<number|null>>;
      idiomas: FormArray<FormGroup<Idioma>>;
      denominacionesRelacionadas:FormArray<FormControl<number|null>>;
      conocimientosCompetencias: FormArray<FormControl<number|null>>;
      habilidadesDestrezas: FormArray<FormControl<number|null>>;
      ubicaciones: FormArray<FormGroup<UbicacionVacante>>;
      condicionesSaludMental: FormArray<FormControl<number|null>>;
      zonasGeograficas: FormArray<FormControl<number|null>>;
      nombreZonaGeografica: FormControl<string|null>;
      registroVacanteDemasPrestadores: FormControl<boolean|null>;

  }

export function newVacante(){
  return new FormGroup<Vacante>({
    // #############################################################
    // INFORMACION GENERAL
    // #############################################################
    id: new FormControl<string|null>(null),
    identificador: new FormControl<string|null>(null),
    nombre: new FormControl<string|null>(null,[Validators.required,Validators.maxLength(50), Validators.minLength(5)]),
    puestosRequeridos: new FormControl<number|null>(null,[Validators.required,Validators.pattern('[0-9]*'), Validators.min(1),Validators.max(9999)]),
    modalidadTrabajoId: new FormControl<number|null>(null,[Validators.required]),
    sectorEconomicoId: new FormControl<number|null>(null,[Validators.required]),
    subsectorEconomicoId: new FormControl<number|null>(null,[Validators.required]),
    requiereViajarPorTrabajo: new FormControl<boolean|null>(null,[Validators.required]),
    tendraPersonasCargo: new FormControl<boolean|null>(null,[Validators.required]),
    requiereLicenciaConduccion: new FormControl<boolean|null>(null,[Validators.required]),
    requiereLicenciaConduccionCarro: new FormControl<boolean|null>(null),
    categoriaLicenciaCarroId: new FormControl<number|null>(null),
    requiereLicenciaConduccionMoto: new FormControl<boolean|null>(null),
    categoriaLicenciaMotoId: new FormControl<number|null>(null),
    areaEmpresaId: new FormControl<number|null>(null,[Validators.required]),
    responsableId: new FormControl<string|null>(null,[Validators.required]),
    fechaEstimadaOcupacionCargo: new FormControl<Date|null>(null,[Validators.required]),
    fechaVencimientoVacante: new FormControl<Date|null>(null), // Por ahora no va
    fechaLimiteEnvioHv: new FormControl<Date|null>(null,[Validators.required,ValidatorsRegistroVacante.fechaMayorQueFechaActual(),ValidatorsRegistroVacante.fechaMenorQueFechaActualMasXMeses(6)]),
    confidencial: new FormControl<boolean|null>(null,[Validators.required]),
    solicitudExcepcionalidad: new FormControl<boolean|null>(null,[Validators.required]),
    solicitudAutorizacionExcepcionalidadFile: new FormControl(null),
    solicitudAutorizacionExcepcionalidadFilePath: new FormControl(null),
    motivoId: new FormControl<number|null>(null),
    aptaParaPersonasConDiscapacidad: new FormControl<boolean|null>(null,[Validators.required]),
    gestionadaPorPrestador: new FormControl<boolean|null>(null,[Validators.required]),
    gestionadaPorPrestadorAlterno: new FormControl<boolean|null>(null,[Validators.required]),
    /**
     * -----------------------------------------------------------------------------------------------
     * CAMPOS HIDROCARBUROS
     * -----------------------------------------------------------------------------------------------
     */
    tipoProyectoId: new FormControl<number|null>(null),
    codigoInternoVacante: new FormControl<string|null>(null),
    manoObraCalificada : new FormControl<boolean|null>(null),
    rangoRemitirCandidatoInicial : new FormControl<boolean|null>(null),
    rangoRemitirCandidatoFinal : new FormControl<boolean|null>(null),
    priorizarPoblacionVulnerable : new FormControl<boolean|null>(null),
    priorizarZonaRural : new FormControl<boolean|null>(null),
    poblacionesVulnerables : new FormArray<FormControl<number|null>>([]),
    gruposEtnicos : new FormArray<FormControl<number|null>>([]),
    tiposPoblacion: new FormArray<FormControl<number|null>>([]),
    condicionesSaludMental: new FormArray<FormControl<number|null>>([]),
    zonasGeograficas: new FormArray<FormControl<number|null>>([]),
    nombreZonaGeografica: new FormControl<string|null>(null),
    registroVacanteDemasPrestadores: new FormControl<boolean|null>(null),


    // #############################################################
    // DESCRIPCION DE LA VACANTE
    // #############################################################
    formacionTitulo: new FormControl(null,[Validators.required,Validators.pattern(/^[A-z ÑñáéíóúÁÉÍÓÚ]*$/),Validators.minLength(5),Validators.maxLength(100)]),
    graduado: new FormControl<boolean|null>(null),
    nivelMinimoEstudioId: new FormControl<number|null>(null, [Validators.required]),
    requiereExperienciaGeneral: new FormControl<boolean|null>(false,[Validators.required]),
    tiempoExperiencia: new FormControl<number|null>(null,[Validators.pattern(/^[0-9]*$/i)]),
    requiereExperienciaEspecifica: new FormControl<boolean|null>(false,[Validators.required]),
    descripcionExperienciaEspecifica: new FormControl(null,[Validators.minLength(5)]),
    requiereCapacitacionEspecifica: new FormControl<boolean|null>(false,[Validators.required]),
    descripcionCapacitacionEspecifica: new FormControl(null,[Validators.minLength(5)]),
    requiereCertificacionEspecifica: new FormControl<boolean|null>(false,[Validators.required]),
    descripcionCertificacionEspecifica: new FormControl(null,[Validators.minLength(5)]),
    informacionAdicional: new FormControl(null,[Validators.minLength(5)]),
    descripcion: new FormControl(null,[Validators.required, Validators.minLength(50)]),
    // #############################################################
    // DETALLE CONTRATACIÓN
    // #############################################################
    tipoContratoId: new FormControl<number|null>(null,[Validators.required]),
    jornadaLaboralId: new FormControl<number|null>(null,[Validators.required]),
    tipoSalarioId: new FormControl<number|null>(null,[Validators.required]),
    rangoSalarialInicial: new FormControl<number|null>(null,[Validators.min(1)]),
    rangoSalarialFinal: new FormControl<number|null>(null),
    periodicidadSalarialId: new FormControl<number|null>(null),
    visibilidadSalario: new FormControl<boolean|null>(false),
    compensacionAdicional: new FormControl<boolean|null>(false),
    descripcionCompensacionAdicional: new FormControl(null,[Validators.maxLength(500), Validators.minLength(10)]),
    tieneVideoAdjunto: new FormControl(false),
    videoUrl: new FormControl(null),
    videoDescripcion: new FormControl(null),
    sedeId: new FormControl<number|null>(null),
    // #############################################################
    // ESTADO DE LA VACANTE
    // #############################################################
    estadoId: new FormControl<ESTADO_VACANTE>(ESTADO_VACANTE.EN_PROCESO),
    // #############################################################
    // LISTADOS GENERALES
    // #############################################################
    prestadoresAlternos: new FormArray<FormControl<number|null>>([]),
    motivosExcepcionalidad: new FormArray<FormControl<number|null>>([]),
    discapacidades:  new FormArray<FormControl<number|null>>([]),
    idiomas:  new FormArray<FormGroup<Idioma>>([]),
    denominacionesRelacionadas:  new FormArray<FormControl<number|null>>([],[Validators.required]),
    conocimientosCompetencias:  new FormArray<FormControl<number|null>>([],[Validators.required]),
    habilidadesDestrezas:  new FormArray<FormControl<number|null>>([],[Validators.required]),
    ubicaciones: new FormArray<FormGroup<UbicacionVacante>>([],[Validators.required]),
  },
 // [ValidatorsRegistroVacante.validarUbiacionPuesto('puestosRequeridos', 'ubicaciones')]
  )
}

/**
 * Genera un Json con los campos FormContrl para utilizar en el template para las validaciones
 * @param form
 * @returns
 */
export function formControlsVacante(form:FormGroup<Vacante>):({[value:string]:FormControl}){
  return {
        "id": form.get("id") as FormControl,
        "indicador": form.get("identificador") as FormControl,
        "nombre": form.get("nombre") as FormControl,
        "puestosRequeridos": form.get("puestosRequeridos") as FormControl,
        "modalidadTrabajoId": form.get("modalidadTrabajoId") as FormControl,
        "sectorEconomicoId": form.get("sectorEconomicoId") as FormControl,
        "subsectorEconomicoId": form.get("subsectorEconomicoId") as FormControl,
        "requiereViajarPorTrabajo": form.get("requiereViajarPorTrabajo") as FormControl,
        "tendraPersonasCargo": form.get("tendraPersonasCargo") as FormControl,
        "requiereLicenciaConduccion": form.get("requiereLicenciaConduccion") as FormControl,
        "requiereLicenciaConduccionCarro": form.get("requiereLicenciaConduccionCarro") as FormControl,
        "categoriaLicenciaCarroId": form.get("categoriaLicenciaCarroId") as FormControl,
        "requiereLicenciaConduccionMoto": form.get("requiereLicenciaConduccionMoto") as FormControl,
        "categoriaLicenciaMotoId": form.get("categoriaLicenciaMotoId") as FormControl,
        "areaEmpresaId": form.get("areaEmpresaId") as FormControl,
        "fechaEstimadaOcupacionCargo":form.get("fechaEstimadaOcupacionCargo") as FormControl,
        "fechaVencimientoVacante":form.get("fechaVencimientoVacante") as FormControl,
        "fechaLimiteEnvioHv":form.get("fechaLimiteEnvioHv") as FormControl,
        "confidencial":form.get("confidencial") as FormControl,
        "solicitudExcepcionalidad":form.get("solicitudExcepcionalidad") as FormControl,
        "solicitudAutorizacionExcepcionalidadFile":form.get("solicitudAutorizacionExcepcionalidadFile") as FormControl,
        "motivoId":form.get("motivoId") as FormControl,
        "aptaParaPersonasConDiscapacidad":form.get("aptaParaPersonasConDiscapacidad") as FormControl,
        "gestionadaPorPrestador":form.get("gestionadaPorPrestador") as FormControl,
        "gestionadaPorPrestadorAlterno":form.get("gestionadaPorPrestadorAlterno") as FormControl,
        "estadoId":form.get("estadoId") as FormControl,

  }
}


export interface VacanteControlPro{
  "name":string,
  "nameNav":string
}

export interface VacanteControlInfo {
  puestosRequeridos:VacanteControlPro,
  nombre:VacanteControlPro,
  modalidadTrabajoId:VacanteControlPro,
  sectorEconomicoId:VacanteControlPro,
  subsectorEconomicoId:VacanteControlPro,
  tipoProyectoId:VacanteControlPro,
  codigoInternoVacante:VacanteControlPro,
  ubicaciones:VacanteControlPro,
  priorizarZonaRural:VacanteControlPro,
  zonasGeograficas:VacanteControlPro,
  nombreZonaGeografica:VacanteControlPro,
  priorizarPoblacionVulnerable:VacanteControlPro,
  poblacionesVulnerables:VacanteControlPro,
  discapacidades:VacanteControlPro,
  gruposEtnicos:VacanteControlPro,
  tiposPoblacion:VacanteControlPro,
  condicionesSaludMental:VacanteControlPro,
  requiereViajarPorTrabajo:VacanteControlPro,
  tendraPersonasCargo:VacanteControlPro,
  requiereLicenciaConduccion:VacanteControlPro,
  requiereLicenciaConduccionCarro:VacanteControlPro,
  categoriaLicenciaCarroId:VacanteControlPro,
  requiereLicenciaConduccionMoto:VacanteControlPro,
  categoriaLicenciaMotoId:VacanteControlPro,
  areaEmpresaId:VacanteControlPro,
  responsableId:VacanteControlPro,
  fechaVencimientoVacante:VacanteControlPro,
  fechaLimiteEnvioHv:VacanteControlPro,
  fechaEstimadaOcupacionCargo:VacanteControlPro,
  confidencial:VacanteControlPro,
  solicitudExcepcionalidad:VacanteControlPro,
  motivosExcepcionalidad:VacanteControlPro,
  solicitudAutorizacionExcepcionalidadFile:VacanteControlPro,
  aptaParaPersonasConDiscapacidad:VacanteControlPro,
  gestionadaPorPrestador:VacanteControlPro,
  gestionadaPorPrestadorAlterno:VacanteControlPro,
  prestadoresAlternos:VacanteControlPro,
  denominacionesRelacionadas:VacanteControlPro,
  conocimientosCompetencias:VacanteControlPro,
  habilidadesDestrezas:VacanteControlPro,
  nivelMinimoEstudioId:VacanteControlPro,
  graduado:VacanteControlPro,
  formacionTitulo:VacanteControlPro,
  manoObraCalificada:VacanteControlPro,
  rangoRemitirCandidatoInicial:VacanteControlPro,
  rangoRemitirCandidatoFinal:VacanteControlPro,
  requiereExperienciaGeneral:VacanteControlPro,
  tiempoExperiencia:VacanteControlPro,
  requiereExpecienciaEspecifica:VacanteControlPro,
  descripcionExperienciaEspecifica:VacanteControlPro,
  requiereCapacitacionEspecifica:VacanteControlPro,
  descripcionCapacitacionEspecifica:VacanteControlPro,
  requiereCertificacionEspecifica:VacanteControlPro,
  descripcionCertificacionEspecifica:VacanteControlPro,
  informacionAdicional:VacanteControlPro,
  idiomas:VacanteControlPro,
  descripcion:VacanteControlPro,
  tipoContratoId:VacanteControlPro,
  jornadaLaboralId:VacanteControlPro,
  tipoSalarioId:VacanteControlPro,
  periodicidadSalarialId:VacanteControlPro,
  rangoSalarialInicial:VacanteControlPro,
  rangoSalarialFinal:VacanteControlPro,
  compensacionAdicional:VacanteControlPro,
  descripcionCompensacionAdicional:VacanteControlPro,
  visibilidadSalario:VacanteControlPro,
  tieneVideoAdjunto:VacanteControlPro,
  videoDescripcion:VacanteControlPro,
  videoUrl:VacanteControlPro,
}
export function formControlVacanteInfo():VacanteControlInfo{
 return <VacanteControlInfo>{
  puestosRequeridos:{
    name:"Número de puestos requeridos",
    nameNav:"informacionGeneral"
  },
  nombre:{
    name:"Nombre de la vacante",
    nameNav:"informacionGeneral"
  },
  modalidadTrabajoId:{
    name:"Modalidad de trabajo",
    nameNav:"informacionGeneral"
  },
  sectorEconomicoId:{
    name:"Sector económico",
    nameNav:"informacionGeneral"
  },
  subsectorEconomicoId:{
    name:"Sub sector económico",
    nameNav:"informacionGeneral"
  },
  tipoProyectoId:{
    name:"Tipo de proyecto",
    nameNav:"informacionGeneral"
  },
  codigoInternoVacante:{
    name:"Código interno de la vacante",
    nameNav:"informacionGeneral"
  },
  ubicaciones:{
    name:"Ubicación de la vacante",
    nameNav:"informacionGeneral"
  },
  priorizarZonaRural:{
    name:"Priorizar zona rural",
    nameNav:"informacionGeneral"
  },
  zonasGeograficas:{
    name:"Priorizar zona rural",
    nameNav:"informacionGeneral"
  },
  nombreZonaGeografica:{
    name:"Nombre de la zona rural",
    nameNav:"informacionGeneral"
  },
  priorizarPoblacionVulnerable:{
    name:"Priorizar población vulnerable",
    nameNav:"informacionGeneral"
  },
  poblacionesVulnerables:{
    name:" Tipo población vulnerable",
    nameNav:"informacionGeneral"
  },
  discapacidades:{
    name:"Seleccione al menos un tipo de discapacidad",
    nameNav:"informacionGeneral"
  },
  gruposEtnicos:{
    name:"Seleccione al menos un grupos étnico",
    nameNav:"informacionGeneral"
  },
  tiposPoblacion:{
    name:"Seleccione al menos un tipo de población",
    nameNav:"informacionGeneral"
  },
  condicionesSaludMental:{
    name:"Seleccione al menos un tipo condición de salud mental",
    nameNav:"informacionGeneral"
  },
  requiereViajarPorTrabajo:{
    name:"¿Se requiere viajar por trabajo?",
    nameNav:"informacionGeneral"
  },
  tendraPersonasCargo:{
    name:"¿Tendrá personas a cargo?",
    nameNav:"informacionGeneral"
  },
  requiereLicenciaConduccion:{
    name:"¿Se requiere licencia de conducción?",
    nameNav:"informacionGeneral"
  },
  requiereLicenciaConduccionCarro:{
    name:"¿Se requiere licencia de conducción para carro?",
    nameNav:"informacionGeneral"
  },
  categoriaLicenciaCarroId:{
    name:"Categoría licencia de carro",
    nameNav:"informacionGeneral"
  },
  requiereLicenciaConduccionMoto:{
    name:"¿Se requiere licencia de conducción para moto?",
    nameNav:"informacionGeneral"
  },
  categoriaLicenciaMotoId:{
    name:"Categoría licencia de moto",
    nameNav:"informacionGeneral"
  },
  areaEmpresaId:{
    name:"Área de la empresa",
    nameNav:"informacionGeneral"
  },
  responsableId:{
    name:"Responsable de la vacante",
    nameNav:"informacionGeneral"
  },
  fechaVencimientoVacante:{
    name:"Fecha de vencimiento de la vacante",
    nameNav:"informacionGeneral"
  },
  fechaLimiteEnvioHv:{
    name:"Fecha límite de envío de hojas de vida",
    nameNav:"informacionGeneral"
  },
  fechaEstimadaOcupacionCargo:{
    name:"Fecha estimada ocupación cargo",
    nameNav:"informacionGeneral"
  },
  confidencial:{
    name:"¿Su vacante es confidencial?",
    nameNav:"informacionGeneral"
  },
  solicitudExcepcionalidad:{
    name:"¿Su vacante tiene excepcionalidad para la publicación?",
    nameNav:"informacionGeneral"
  },
  motivosExcepcionalidad:{
    name:"Motivo",
    nameNav:"informacionGeneral"
  },
  solicitudAutorizacionExcepcionalidadFile:{
    name:"Solicitud de autorización de excepcionalidad",
    nameNav:"informacionGeneral"
  },
  aptaParaPersonasConDiscapacidad:{
    name:"¿Vacante apta para personas con discapacidad?",
    nameNav:"informacionGeneral"
  },
  gestionadaPorPrestador:{
    name:"¿Desea que la vacante sea gestionada por su prestador?",
    nameNav:"informacionGeneral"
  },
  gestionadaPorPrestadorAlterno:{
    name:"¿Desea seleccionar un prestador alterno para la gestión de la vacante?",
    nameNav:"informacionGeneral"
  },
  prestadoresAlternos:{
    name:"Seleccione hasta 2 prestadores alternos para la gestión de la vacante",
    nameNav:"informacionGeneral"
  },

  nivelMinimoEstudioId:{
    name:"Nivel mínimo de estudios",
    nameNav:"informacionGeneral"
  },
  graduado:{
    name:"¿Graduado?",
    nameNav:"informacionGeneral"
  },
  formacionTitulo:{
    name:"Formación o título requerido",
    nameNav:"informacionGeneral"
  },
  manoObraCalificada:{
    name:"Mano de obra calificada",
    nameNav:"informacionGeneral"
  },
  rangoRemitirCandidatoInicial:{
    name:"Mano de obra calificada",
    nameNav:"informacionGeneral"
  },
  rangoRemitirCandidatoFinal:{
    name:"Rango remitir candidato final",
    nameNav:"informacionGeneral"
  },

  denominacionesRelacionadas:{
    name:"Seleccionar hasta 4 ocupaciones relacionadas",
    nameNav:"descripcionVacante"
  },
  conocimientosCompetencias:{
    name:"Seleccionar hasta 4 conocimientos o competencias de las ocupaciones",
    nameNav:"descripcionVacante"
  },
  habilidadesDestrezas:{
    name:"Seleccionar hasta 4 habilidades o destrezas de las ocupaciones",
    nameNav:"descripcionVacante"
  },

  requiereExperienciaGeneral:{
    name:"¿Requiere experiencia general?",
    nameNav:"descripcionVacante"
  },
  tiempoExperiencia:{
    name:"Tiempo de experiencia (En meses)",
    nameNav:"descripcionVacante"
  },
  requiereExpecienciaEspecifica:{
    name:"¿Requiere experiencia específica?",
    nameNav:"descripcionVacante"
  },
  descripcionExperienciaEspecifica:{
    name:"Descripción de la experiencia específica",
    nameNav:"descripcionVacante"
  },
  requiereCapacitacionEspecifica:{
    name:"¿Requiere capacitación específica?",
    nameNav:"descripcionVacante"
  },
  descripcionCapacitacionEspecifica:{
    name:"Descripción de la capacitación específica",
    nameNav:"descripcionVacante"
  },
  requiereCertificacionEspecifica:{
    name:"¿Requiere certificación específica?",
    nameNav:"descripcionVacante"
  },
  descripcionCertificacionEspecifica:{
    name:"Descripción de la certificación específica",
    nameNav:"descripcionVacante"
  },
  informacionAdicional:{
    name:"Información adicional de la vacante",
    nameNav:"descripcionVacante"
  },
  idiomas:{
    name:"Idiomas requeridos",
    nameNav:"descripcionVacante"
  },
  descripcion:{
    name:"Descripción de la vacante",
    nameNav:"descripcionVacante"
  },
  tipoContratoId:{
    name:"Seleccione un tipo de contrato",
    nameNav:"detalleContratacion"
  },
  jornadaLaboralId:{
    name:"Jornada laboral",
    nameNav:"detalleContratacion"
  },
  tipoSalarioId:{
    name:"Seleccione la opción salarial que más se ajuste a la vacante",
    nameNav:"detalleContratacion"
  },
  periodicidadSalarialId:{
    name:"Periodicidad Salarial",
    nameNav:"detalleContratacion"
  },
  rangoSalarialInicial:{
    name:"Salario definido",
    nameNav:"detalleContratacion"
  },
  rangoSalarialFinal:{
    name:"Salario final",
    nameNav:"detalleContratacion"
  },
  compensacionAdicional:{
    name:"Compensación adicional",
    nameNav:"detalleContratacion"
  },
  descripcionCompensacionAdicional:{
    name:"Descripción compensación adicional",
    nameNav:"detalleContratacion"
  },
  visibilidadSalario:{
    name:"Salario visible para los buscadores",
    nameNav:"detalleContratacion"
  },
  tieneVideoAdjunto:{
    name:"Adjuntar video para invitar a los buscadores a aplicar",
    nameNav:"detalleContratacion"
  },
  videoDescripcion:{
    name:"Descripción del video",
    nameNav:"detalleContratacion"
  },
  videoUrl:{
    name:"Url del video",
    nameNav:"detalleContratacion"
  },
 }
}


/***
 * **************************************************************
 * VALIDATORS PERSONALIZADOS REGISTRO VACANTE
 * **************************************************************
 */

 export const ValidatorsRegistroVacante = {

  /**
   * Valiida si la fecha la fecha seleccionada es mayor a la fecha actual y no mayor a 6 meses
   * @returns
   */
  fechaMayorQueFechaActual:function (): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null => {
      let dt = DateTime.local();
      let fechaSeleccionada = DateTime.fromObject(control.value);
      const forbidden = dt > fechaSeleccionada;
      return forbidden ? {fechaMayorQueFechaActual: {value: control.value, fechaActual:dt.toFormat("yyyy-MM-dd")}} : null;
    };
  },

/**
   * Valiida si la fecha la fecha seleccionada es mayor a la fecha actual y no mayor a 6 meses
   * @returns
   */
 fechaMenorQueFechaActualMasXMeses:function (meses:number): ValidatorFn {
  return (control: AbstractControl): ValidationErrors | null => {
    let dt = DateTime.local().plus({months: meses});
    let fechaSeleccionada = DateTime.fromObject(control.value);
    const forbidden = fechaSeleccionada > dt;
    return forbidden ? {fechaMenorQueFechaActualMasXMeses: {value: control.value,fechaMaxima:dt.toFormat("yyyy-MM-dd")}} : null;
  };
},


/**
   * Valiida que los puestos de trababajo sea ungula la distribucion por ubicacion
   * @returns
   */

validarUbiacionPuesto(puestosRequeridos: string, ubicaciones: string): ValidatorFn {
  return (control: AbstractControl): ValidationErrors | null => {
    const puesto = control.get(puestosRequeridos) as FormControl;
    const ubicacion = control.get(ubicaciones) as FormArray;
    puesto.value;
    const totalUbicacion = ubicacion.value.reduce(
      (accumulator:any, currentValue:any) => accumulator + currentValue?.numeroPuestos,
      0
    );

    return (puesto.value==totalUbicacion)?null:{ validarUbiacionPuesto: true };
  };
}
}





