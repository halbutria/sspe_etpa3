using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoDireccionModel:EntidadBase
    {
        public Guid CiudadanoId { get; set; }
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
        public int? ViaGeneradora { get; set; }
        public string? ViaGeneradoraLetraId { get; set; }
        public string? ViaGeneralLetraNombre { get; set;}
        public int? ViaGeneradoraPlaca { get; set; }
        public string? ViaGeneradoraCuadranteId { get; set; }
        public string? ViaGeneradoraCuadranteNombre { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
        public ICollection<CiudadanoDireccionComplementoModel>? DireccionComplemento { get; set; }
    }
}
