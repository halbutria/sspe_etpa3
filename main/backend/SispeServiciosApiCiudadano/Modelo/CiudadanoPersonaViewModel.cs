using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    [Table("CiudadanoPersona")]
    public class CiudadanoPersonaViewModel
    {
        public string Id { get; set; }
        public int? TipoDocumentoId { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? PrimerNombre { get; set; }
        
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public string? RazonSocial { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? SexoId { get; set; } = 0;
        public string? Telefono { get; set; }
        public string? DireccionResidencia { get; set; }
        public int? PaisResidenciaId { get; set; }
        public string? DepartamentoResidenciaId { get; set; }
        public string? MunicipioResidenciaId { get; set; }
        public string? PrestadorPreferenciaId { get; set; }
        public string? PuntoAtencionId { get; set; }
        public int? PreguntaSeguridadId { get; set; }
        public string? PreguntaSeguridadRespuesta { get; set; }
        public bool TerminosCondiciones { get; set; }
        //public bool TratamientoDatosPersonales { get; set; }
        public int? LocalidadComunaId { get; set; }
        public string? PreguntaLibre { get; set; }
        public bool? Activo { get; set; } = true;
        public string? BarrioResidencia { get; set; }
        public bool PerteneceARural { get; set; }
        public string? OtroTelefono { get; set; }

        public DateTime? FechaExpedicionDocumento { get; set; }

        public string? DireccionId { get; set; }


        public string? Estado { get; set; }
       
        
        public string? Ciudad { get; set; }
  
        
        public string? ViaPrincipalId { get; set; }
        
        
        public string? ViaPrincipalNombre { get; set; }
        
        
        public string? ViaPrincipal { get; set; }
      
        
        public string? ViaPrincipalLetraId { get; set; }
       
        
        public string? ViaPrincipalLetraNombre { get; set; }
       
        
        public string? ViaPrincipalBisId { get; set; }
       
        
        public string? ViaPrincipalBisNombre { get; set; }
       
        
        public string? ViaPrincipalSegundaLetraId { get; set; }
       
        
        public string? ViaPrincipalSegundaLetraNombre { get; set; }
        
        
        public string? ViaPrincipalCuadranteId { get; set; }
      
        
        public string? ViaPrincipalCuadranteNombre { get; set; }
      
        
        public string? SignoNumero { get; set; }
     
        
        public string? ViaGeneradora { get; set; }
       
        
        public string? ViaGeneradoraLetraId { get; set; }
     
        
        public string? ViaGeneralLetraNombre { get; set; }
       
        
        public string? ViaGeneradoraPlaca { get; set; }
       
        
        public string? ViaGeneradoraCuadranteId { get; set; }
        

        public string? ViaGeneradoraCuadranteNombre { get; set; }
        

        public string? CodigoPostal { get; set; }


        //public ICollection<CiudadanoDireccionModel>? Direcciones { get; set; }


    }
}
