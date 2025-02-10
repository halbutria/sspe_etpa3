using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class CamposCreacionEmpresaExtrangera : EntidadBase
    {
        public int Id { get; set; }
        public int TipoPersona { get; set; }
        public int TipoDocumento { get; set; }
        public int Naturaleza { get; set; }
        public int Tipo { get; set; }
        public int TamanioPorNumeroEmpleados { get; set; }
    }
}
