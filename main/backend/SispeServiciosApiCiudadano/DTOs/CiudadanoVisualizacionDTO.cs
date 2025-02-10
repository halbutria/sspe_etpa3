using SispeServicios.Api.Ciudadano.Modelo;
using SispeServiciosApiCiudadano.Modelo.Parametricos;

namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class CiudadanoVisualizacionDTO: CiudadanoInfoDTO
    {
        //public Guid Id { get; set; }   
        //public string? NumeroDocumento { get; set; }
        //public string? PrimerNombre { get; set; }
        //public string? SegundoNombre { get; set; }
        //public string? PrimerApellido { get; set; }
        //public string? SegundoApellido { get; set; }
        //public DateTime FechaNacimiento { get; set; }
        //public int TipoDocumentoId { get; set; }
        public string? TipoDocumento { get; set; }


        //204f39af-065e-4da0-b945-8a578d31b5e3
        //public int? TipoDocumentoAdicionalId { get; set; }
        public string? TipoDocumentoAdicional { get; set; }
        //public string? NumeroDocumentoAdicional { get; set; }

        //public string? CorreoElectronico { get; set; }
        //public string DepartamentoResidenciaId { get; set; }
        public string? DepartamentoResidencia { get; set; }
        //public string MunicipioResidenciaId { get; set; }
        public string? MunicipioResidencia { get; set; }
        //public int SexoId { get; set; }
        //public string? Telefono { get; set; }
        //public string? DireccionResidencia { get; set; }
        //public int PaisResidenciaId { get; set; }
        //public string? PrestadorPreferenciaId { get; set; }
        //public string? PrestadorPreferenciaNombre { get; set; }
        //public string? PuntoAtencionId { get; set; }
        //public string? PuntoAtencionNombre { get; set; }
        //public bool? TieneLibretaMilitar { get; set; }
        //public int? TipoLibretaMilitarId { get; set; }
        //public string? NumeroLibretaMiltar { get; set; }
        //public int? NacionalidadId { get; set; }
        //public bool? JefeHogar { get; set; }
        //public bool? PoblacionFocalizada { get; set; }
        //public bool? Sisben { get; set; }
        //public string? BarrioResidencia { get; set; }
        //public string? OtroTelefono { get; set; }
        //public string? Observacion { get; set; }
        //public int? Estrato { get; set; }
        //public string? CertificadoResidencia { get; set; }
        //public bool? CertificadoResidencia { get; set; }
        //public string? PerfilLaboral { get; set; }
        //public bool? PosibilidadViajar { get; set; }
        //public bool? PosibilidadTrasladarse { get; set; }
        //public bool? InteresOfertasTeletrabajo { get; set; }

        //public bool? PropiedadMedioTransporte { get; set; }
        //public bool? TieneLicenciaConduccionCarro { get; set; }
        //public bool? TieneLicenciaConduccionMoto { get; set; }
        //public bool? TieneInformacionLaboral { get; set; }
        //public bool? TieneEducacionFormal { get; set; }
        //public bool? TieneEducacionNoFormal { get; set; }
        //public bool? InteresPracticaEmpresarial { get; set; }
        //public bool? TieneExperienciaLaboral { get; set; }
        //public int? EstadoCivilId { get; set; }
        //public int? PaisNacimientoId { get; set; }
        //public string? DepartamentoNacimientoId { get; set; }
        //public string? MunicipioNacimientoId { get; set; }
        //public int? EpsId { get; set; }
        //public int? RangoSalarialId { get; set; }
        //public int? CondicionDiscapacidadId { get; set; }
        //public int? CondicionSaludMentalId { get; set; }
        //public int? CategoriaLicenciaCarroId { get; set; }
        //public int? CategoriaLicenciaMotoId { get; set; }
        //public bool? PerteneceARural { get; set; }
        //public int? SituacionLaboralActualId { get; set; }
        //public int? TipoPoblacionId { get; set; }
        //public float PorcentajeHv { get; set; }
        //public float PorcentajeRegistro { get; set; }
        //public float PorcentajeInfoPersonal { get; set; }
        //public float PorcentajeEduFormal { get; set; }
        //public float PorcentajeInfoLaboral { get; set; }
        //public float PorcentajeEduNoFormal { get; set; }
        //public bool? Autorregistro { get; set; }
        //public bool? HojaVidaCompleta { get; set; }
        //public int? EstadoCiudadanoId { get; set; }
        //public string? CodigoPostal { get; set; }
        //public bool? DispuestoDesplazarseDiariamente { get; set; }
        //public bool? DispuestoCambiarMunicipio { get; set; }

        //public int? LocalidadComunaId { get; set; }
        //public int? GeneroId { get; set; }
        //public string? CualGenero { get; set; }
        //public int? OrientacionSexualId { get; set; }
        //public string? CualOrientacionSexual { get; set; }
        //public string? PreguntaLibre { get; set; }

        //public DateTime? FechaExpedicionDocumento { get; set; }
        //public string? Estado { get; set; }
        //public string? Ciudad { get; set; }
        //public string? EstadoNacimiento { get; set; }
        //public string? CiudadNacimiento { get; set; }

        //public List<string>? CargoIneteres { get; set; }
        new public List<string>? CondicionDiscapacidad { get; set; }
        //public List<int>? CondicionSaludMental { get; set; }
        //public List<int>? TipoPoblacion { get; set; }
        //public List<int>? GrupoEtnico { get; set; }
        public Pais? Nacionalidad { get; set; }
        public Genero? GeneroCiudadano { get; set; }
        public Pais? PaisResidencia { get; set; }

        //public ICollection<DireccionDTO>? Direcciones { get; set; }
        public ICollection<InformacionLaboralDTO>? InformacionLaboral { get; set; }
        public ICollection<CiudadanoEducacionFormalModel>? EducacionFormal { get; set; }
        public ICollection<CiudadanoHabilidadDestrezaModel>? Destrezas { get; set; }
        public ICollection<EducacionNoFormalDTO>? EducacionNoFormal { get; set; }
        public ICollection<IdiomaDTO>? Idiomas { get; set; }


    }
}
