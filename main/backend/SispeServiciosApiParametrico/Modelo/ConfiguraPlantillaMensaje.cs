using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class ConfiguraPlantillaMensaje : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Plantilla { get; set; }
    }
}
