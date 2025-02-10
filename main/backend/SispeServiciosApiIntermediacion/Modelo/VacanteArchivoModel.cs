using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class VacanteArchivoModel : EntidadBase
    {

        //public enum TiposArchivo
        //{
        //    SolicitudAutorizacionExcepcionalidad
        //}

        public Guid VacanteId { get; set; }
        public string TipoArchivo { get; set; }
        public string NombreArchivo { get; set; }
        public string NombreArchivoRepositorio { get; set; }

        public VacanteModel Vacante { get; set; }
    }
}
