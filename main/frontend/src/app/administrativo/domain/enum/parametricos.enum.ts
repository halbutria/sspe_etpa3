// parametricos.enum.ts
import { ParametricosAdmin } from "../dto/parametricos-admin";

export const ParametricosList: ParametricosAdmin[] = [
  {
    "id": 75,
    "hu": "HU286",
    "name": "Plantillas de Mensajes",
    "category": "Administración",
    "parametrico": "PlantillaMensaje",
    "fields": [
      {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
        "col": 12
      }, {
        "name": "contenido",
        "label": "Contenido",
        "type": "text",
        "required": true,
        "col": 12
      }
    ]
  },
  {
    "id": 76,
    "hu": "HU288",
    "name": "Usuarios",
    "category": "Administración",
    "parametrico": "", // Falta HU
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true
      }
    ]
  },
  {
    "id": 77,
    "hu": "HU289",
    "name": "Rol/Funcionalidad",
    "category": "Administración",
    "parametrico": "", // Falta HU
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true
      }
    ]
  },
  {
    "id": 65,
    "hu": "HU267",
    "name": "Preguntas de Seguridad",
    "category": "Buscador",
    "parametrico": "PreguntaSeguridad",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "col": 12,
        "required": true,
        "msgValidation": "* Pregunta requerida"
      }
    ]
  },
  {
    "id": 71,
    "hu": "HU278A",
    "name": "Niveles Académicos",
    "category": "Parametrización Información Educativa",
    "parametrico": "NivelEducativo",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "col": 12,
        "required": true,
        "msgValidation": "* Nivel educativo requerido"
      }, {
        "name": "sigla",
        "label": "Sigla",
        "type": "text",
        "required": true,
        "col": 2
      }, {
        "name": "orden",
        "label": "Orden",
        "type": "number",
        "required": true,
        "col": 2
      }
    ]
  },
  {
    "id": 68,
    "hu": "HU273",
    "name": "Instituciones",
    "category": "Parametrización Información Educativa",
    "parametrico": "Institucion",
    "component": "InstitucionesComponent",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
        "col": 6
      }, {
        "name": "nivelEducativoId",
        "label": "Nivel Educativo",
        "type": "select",
        "hide_list": true,
        "hide_edit": true,
        "required": true,
        "association": "NivelEducativo",
        "col": 6
      }
    ]
  },
  {
    "id": 71,
    "hu": "HU278B",
    "name": "Áreas de Conocimiento",
    "category": "Parametrización Información Educativa",
    "parametrico": "AreaConocimiento",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "col": 12,
        "required": true,
        "msgValidation": "* Área de conocimiento es requerido"
      }
    ]
  },
  {
    "id": 71,
    "hu": "HU278B",
    "name": "Profesiones",
    "category": "Parametrización Información Educativa",
    "parametrico": "Profesion",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "col": 12,
        "required": true
      }, {
        "name": "institucionId",
        "label": "Institución",
        "type": "select",
        "required": true,
        "hide_list": true,
        "association": "Institucion",
        "col": 6
      }, {
        "name": "areaConocimientoId",
        "label": "Área Conocimiento",
        "type": "select",
        "required": true,
        "hide_list": true,
        "association": "AreaConocimiento",
        "col": 6
      }
    ]
  },
  {
    "id": 69,
    "hu": "HU274",
    "name": "Información Laboral",
    "category": "Buscador",
    "parametrico": "InformacionLaboral",
    "fields": [
      {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 70,
    "hu": "HU276",
    "name": "Indicadores Avance HV",
    "category": "Buscador",
    "parametrico": "ConfiguracionAvanceHojaVida",
    "fields": [
      {
        "name": "tipo",
        "label": "Tipo",
        "type": "text",
        "required": true,
        "col": 8
      }, {
        "name": "avance",
        "label": "Avance",
        "type": "number",
        "required": true,
        "col": 4
      }
    ]
  },
  {
    "id": 72,
    "hu": "HU280",
    "name": "Licencias de Conducción",
    "category": "Buscador",
    "parametrico": "CategoriaLicencia",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
        "col": 6
      }, {
        "name": "tipo",
        "label": "Tipo",
        "type": "select",
        "required": true,
        "col": 6,
        "options": [
          {value: "Moto", label: "Moto"},
          {value: "Carro", label: "Carro"},
        ]
      }
    ]
  },
  {
    "id": 73,
    "hu": "HU281",
    "name": "Mensajes y Alertas de Vacante",
    "category": "Buscador",
    "parametrico": "MensajePreseleccion",
    "fields": [
      {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
      }, {
        "name": "contenido",
        "label": "Contenido",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 74,
    "hu": "HU282",
    "name": "Tipo de Idioma",
    "category": "Buscador",
    "parametrico": "Idioma",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "col": 12,
        "required": true,
        "msgValidation": "* Idioma requerido"
      }
    ]
  },
  {
    "id": 80,
    "hu": "HU297A",
    "name": "Nivel de Idioma",
    "category": "Buscador",
    "parametrico": "NivelDominioIdioma",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "col": 12,
        "required": true,
        "msgValidation": "* Nivel de idioma requerido"
      }
    ]
  },
  {
    "id": 80,
    "hu": "HU297B",
    "name": "Fluidez de Idioma",
    "category": "Buscador",
    "parametrico": "FluidezIdioma",
    "fields": [
      {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 82,
    "hu": "HU300",
    "name": "Sexo",
    "category": "Buscador",
    "parametrico": "Genero",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
        "col": 8
      }, {
        "name": "sigla",
        "label": "Sigla",
        "type": "text",
        "required": true,
        "col": 4
      }
    ]
  },
  {
    "id": 83,
    "hu": "HU301",
    "name": "Tipo de Documento",
    "category": "Buscador",
    "parametrico": "TipoDocumento",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "col": 12,
        "required": true,
        "msgValidation": "* Nombre de tipo de documento requerido"
      }, {
        "name": "sigla",
        "label": "Sigla",
        "type": "text",
        "required": true,
        "col": 4
      }, {
        "name": "principal",
        "label": "Principal",
        "type": "select",
        "col": 4,
        "required": true,
        "options": [
          {value: true, label:'SI'},
          {value: false, label:'NO'},
        ]
      }
    ]
  },
  {
    "id": 84,
    "hu": "HU302",
    "name": "Dirección Estándar",
    "category": "Buscador",
    "parametrico": "TipoDireccion",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 85,
    "hu": "HU304",
    "name": "Términos y Tratamiento de Datos",
    "category": "Buscador",
    "parametrico": "Terminos",
    "fields": [
      {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
      }, {
        "name": "contenido",
        "label": "Contenido",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 87,
    "hu": "HU307",
    "name": "Modalidad de Trabajo",
    "category": "Buscador",
    "parametrico": "ModalidadTrabajo",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
        "col": 12
      }, {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
        "col": 12
      }
    ]
  },
  {
    "id": 88,
    "hu": "HU308A",
    "name": "Sector Económico",
    "category": "Buscador",
    "parametrico": "SectorEconomico",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
        "col": 12
      }
    ]
  },
  {
    "id": 88,
    "hu": "HU308B",
    "name": "Subsector Económico",
    "category": "Buscador",
    "parametrico": "SubsectorEconomico",
    "parametrico_list": "SubsectorEconomico2",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
      }, {
        "name": "sectorEconomicoId",
        "label": "Sector Económico",
        "type": "select",
        "required": true,
        "association": "SectorEconomico"
      }
    ]
  },
  {
    "id": 90,
    "hu": "HU311",
    "name": "Discapacidad",
    "category": "Buscador",
    "parametrico": "Discapacidad",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 91,
    "hu": "HU314A",
    "name": "Tipo de Contrato",
    "category": "Buscador",
    "parametrico": "TipoContrato",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
        "col": 8
      }, {
        "name": "sigla",
        "label": "Sigla",
        "type": "text",
        "required": true,
        "col": 4
      }
    ]
  },
  {
    "id": 91,
    "hu": "HU314B",
    "name": "Jornada Laboral",
    "category": "Buscador",
    "parametrico": "JornadaLaboral",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 91,
    "hu": "HU314C",
    "name": "Rango Salarial",
    "category": "Buscador",
    "parametrico": "RangoSalarial",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
        "col": 8
      }, {
        "name": "valorInicial",
        "label": "Valor Inicial",
        "type": "number",
        "required": true,
        "col": 4
      }
    ]
  },
  {
    "id": 78,
    "hu": "HU290",
    "name": "Rechazo de Empresa",
    "category": "Empleador",
    "parametrico": "MotivoRechazo",
    "fields": [
      {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 79,
    "hu": "HU295",
    "name": "Cambio de Prestador",
    "category": "Prestador",
    "parametrico": "MotivoCambioPrestador",
    "fields": [
      {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 81,
    "hu": "HU299",
    "name": "Tipo de Prestador",
    "category": "Prestador",
    "parametrico": "TipoPrestador",
    "fields": [
      {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 64,
    "hu": "HU264A",
    "name": "Priorización Zona Rural",
    "category": "Vacantes Hidrocarburos",
    "parametrico": "TipoZonaGeografica",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
        "col": 8
      }, {
        "name": "rural",
        "label": "Rural",
        "type": "select",
        "col": 4,
        "required": true,
        "options": [
          {value: true, label:'SI'},
          {value: false, label:'NO'},
        ]
      }
    ]
  },
  {
    "id": 64,
    "hu": "HU264B",
    "name": "Priorización Población Vulnerable",
    "category": "Vacantes Hidrocarburos",
    "parametrico": "TipoPoblacionVulnerable",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 66,
    "hu": "HU270",
    "name": "Ampliar Zona de Influencia",
    "category": "Vacantes Hidrocarburos",
    "parametrico": "MotivoAmpliarZona",
    "fields": [
      {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 67,
    "hu": "HU271",
    "name": "Descripción Vacante",
    "category": "Vacantes",
    "parametrico": "PlantillaDescripcionVacante",
    "component": "DescripcionVacanteComponent",
    "fields": [
      {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
      }, {
        "name": "texto",
        "label": "Texto",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 86,
    "hu": "HU306",
    "name": "Estados de Vacante",
    "category": "Vacantes",
    "parametrico": "EstadoVacante",
    "fields": [
      {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 89,
    "hu": "HU310",
    "name": "Excepcionalidad de Vacante",
    "category": "Vacantes",
    "parametrico": "MotivoExcepcionalidad",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 92,
    "hu": "HU315A",
    "name": "Área de Influencia",
    "category": "Vacantes",
    "parametrico": "AreaInfluencia",
    "fields": [
      {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 92,
    "hu": "HU315B",
    "name": "División Territorial",
    "category": "Vacantes",
    "parametrico": "DivisionTerritorial",
    "fields": [
      {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 93,
    "hu": "HU316",
    "name": "Proyectos y Sector Hidrocarburos",
    "category": "Vacantes Hidrocarburos",
    "parametrico": "TipoProyecto",
    "fields": [
      {
        "name": "nombre",
        "label": "Nombre",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 94,
    "hu": "HU317",
    "name": "Núcleo de Conocimiento",
    "category": "Vacantes",
    "parametrico": "NucleoConocimientoHidrocarburos",
    "fields": [
      {
        "name": "descripcion",
        "label": "Descripción",
        "type": "text",
        "required": true,
      }
    ]
  },
  {
    "id": 95,
    "hu": "HU320",
    "name": "Criterios Emparejamiento Vacante",
    "category": "Vacantes",
    "parametrico": "CriterioMatch",
    "component": "CriteriosMatchComponent",
    "fields": []
  }
];
