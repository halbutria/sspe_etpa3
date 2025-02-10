using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class ControlPesoNumeroArchivosCargar : EntidadBase
    {
        public int Id { get; set; }
        public int cantidadAdjuntosHv { get; set; }
        public int pesoMaximoArchivoAdjuntoHv { get; set; }
        public int cantidadAdjuntosInformacionAcademica { get; set; }
        public int pesoMaximoArchivoAdjuntoInformacionAcademica { get; set; }
        public int cantidadAdjuntosInformacionLaboral { get; set; }
        public int pesoMaximoArchivoAdjuntoInformacionLaboral { get; set; }
        public int cantidadAdjuntosEducacionInformal { get; set; }
        public int pesoMaximoArchivoAdjuntoEducacionInformal { get; set; }
        public int cantidadAdjuntosIdiomas { get; set; }
        public int pesoMaximoArchivoAdjuntoIdiomas { get; set; }
        public int pesoMaximoArchivoAdjuntoFoto { get; set; }
        public int cantidadEnlacesPermitidos { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
    }
}
