namespace SispeServicios.Api.Gateway.RemoteModel
{
    public class CiudadanoInputRemote
    {
        public Guid Id { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public ParametricoIntRemote? TipoDocumento { get; set; }
        public string? CorreoElectronico { get; set; }
        public ParametricoStrRemote? Departamento { get; set; }
        public ParametricoStrRemote? Municipio { get; set; }
        public ParametricoIntRemote? Genero { get; set; }
        public string? Telefono { get; set; }
        public string? DireccionResidencia { get; set; }
        public ParametricoIntRemote? PaisResidencia { get; set; }
        public string? PrestadorPreferenciaId { get; set; }
        public string? PrestadorPreferenciaNombre { get; set; }
        public string? PuntoAtencionId { get; set; }
        public string? PuntoAtencionNombre { get; set; }

        public string? LibretaMiltar { get; set; }
        public string? NacionalidadId { get; set; }
        public bool? JefeHogar { get; set; }
        public bool? PoblacionFocalizada { get; set; }
        public bool? Sisben { get; set; }
        public string? BarrioResidencia { get; set; }
        public string? OtroTelefono { get; set; }
        public string? Observacion { get; set; }
        public int? Estrato { get; set; }
        public string? CertificadoResidencia { get; set; }
        public string? PerfilLaboral { get; set; }
        public bool? PosibilidadViajar { get; set; }
        public bool? PosibilidadTrasladarse { get; set; }
        public bool? InteresOfertasTeletrabajo { get; set; }
        public bool? PropiedadMedioTransporte { get; set; }
        public bool? LicenciaConduccionCarroId { get; set; }
        public bool? LicenciaConduccionMoto { get; set; }
        public bool? TieneEducacionFormal { get; set; }
        public bool? InteresPracticaEmpresarial { get; set; }
        public bool? TieneExperiaciaLaboral { get; set; }
        public ParametricoIntRemote? EstadoCivil { get; set; }
        public ParametricoIntRemote? PaisNacimiento { get; set; }
        public ParametricoStrRemote? DepartamentoNacimiento { get; set; }
        public ParametricoStrRemote? MunicipioNacimiento { get; set; }
        public ParametricoIntRemote? Eps { get; set; }
        public ParametricoIntRemote? RangoSalarial { get; set; }
        public ParametricoIntRemote? GrupoEtnico { get; set; }
        public ParametricoIntRemote? CondicionDiscapacidad { get; set; }
        public ParametricoIntRemote? CondicionSaludMental { get; set; }
        public ParametricoIntRemote? CategoriaLicenciaCarro { get; set; }
        public ParametricoIntRemote? CategoriaLicenciaMoto { get; set; }
        public ParametricoIntRemote? PerteneceA { get; set; }
        public ParametricoIntRemote? SituacionLaboralActual { get; set; }
        public ParametricoIntRemote? TipoPoblacion { get; set; }
    }
}
