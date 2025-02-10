using SispeServicios.Api.Ciudadano.RemoteModel;
using System.Text.Json.Serialization;

namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class CiudadanoInfoBasicaDTO
    {
        public Guid CiudadanoId { get; set; }       
        public Guid UsuarioId { get; set; }  
        public string NumeroDocumento { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int TipoDocumentoId { get; set; }
        public string TipoDocumentoNombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string DepartamentoId { get; set; }
        public string DepartamentoNombre { get; set; }
        public string MunicipioId { get; set; }
        public string MunicipioNombre { get; set; }
        public int GeneroId { get; set; }
        public string GeneroNombre { get; set; }
        public string Telefono { get; set; }
        public string DireccionResidencia { get; set; }
        public string PaisResidenciaId { get; set; }
        public string PaisResidenciaNombre { get; set; }
        public string PrestadorPreferenciaId { get; set; }
        public string PrestadorPreferenciaNombre { get; set; }
        public string PuntoAtencionId { get; set; }
        public string PuntoAtencionNombre { get; set; }

        //opcionales
        public int? EstadoCivilId { get; set; }
        public string? PaisNacimientoId { get; set; }
        public string? LibretaMiltar { get; set; }
        public string? DepartamentoNacimientoId { get; set; }
        public string? MunicipioNacimientoId { get; set; }
        public string? NacionalidadId { get; set; }
        public bool? JefeHogar { get; set; }
        public bool? PoblacionFocalizada { get; set; }
        public bool? Sisben { get; set; }
        public string? EpsId { get; set; }
        public string? BarrioResidencia { get; set; }
        public int? PerteneceA { get; set; }
        public string? OtroTelefono { get; set; }
        public string? Observacion { get; set; }

        public int? RangoSalarialId { get; set; }
        public int? GrupoEtnicoId { get; set; }
        public int? TipoPoblacionId { get; set; }
        public int? CondicionDiscapacidadId { get; set; }
        public int? CondicionSaludMentalId { get; set; }
        public int? Estrato { get; set; }
        public string? CertificadoResidencia { get; set; }

        public string? PerfilLaboral { get; set; }
        public bool? PosibilidadViajar { get; set; }
        public bool? PosibilidadTrasladarse { get; set; }
        public bool? InteresOfertasTeletrabajo { get; set; }
        public int? SituacionLaboralActual { get; set; }
        public bool? PropiedadMedioTransporte { get; set; }
        public bool? LicenciaConduccionCarroId { get; set; }
        public int? CategoriaLicenciaCarroId { get; set; }
        public bool? LicenciaConduccionMoto { get; set; }
        public int? CategoriaLicenciaMotoId { get; set; }

    }
}
