namespace SispeServicios.Api.Parametrico.DTOs
{
    public class ConsultaDTO
    {
        //HU0099
        public ParametricoDTO? ServiciosAsociados { get; set; }
        public ParametricoDTO? ServiciosBasicos { get; set; }
        public ParametricoDTO? ServiciosOferta { get; set; }

        public ParametricoDTO? BrechaServiciosAsociados { get; set; }
        public ParametricoDTO? BrechaServiciosBasicos { get; set; }
        public ParametricoDTO? BrechaServiciosOferta { get; set; }

        public ParametricoDTO? ServiciosAsociadosBrecha { get; set; }
        public ParametricoDTO? ServiciosBasicosBrecha { get; set; }
        public ParametricoDTO? ServiciosOfertaBrecha { get; set; }
        //HU0099
        public ParametricoDTO? TipoDocumento { get; set; }
        public ParametricoDTO? Departamento { get; set; }
        public ParametricoDTO? Municipio { get; set; }
        public ParametricoDTO? Genero { get; set; }
        public ParametricoDTO? Pais { get; set; }
        public ParametricoDTO? ZonaGeografica { get; set; }
        public ParametricoDTO? LocalidadComuna { get; set; }
    }
}
