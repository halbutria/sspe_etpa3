using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServiciosApiCiudadano.Aplicacion.Utils
{
    public  class ConvertirCiudadanoAPersona
    {
        private readonly Contexto _contexto;
        public ConvertirCiudadanoAPersona(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task ComplementarInfoAsync(CiudadanoInfoDTO buscador)
        {
            var persona = await _contexto.CiudadanoPersona.Where(x => x.Id == buscador.Id.ToString()).FirstOrDefaultAsync();
            if(persona == null)
                return ;

            var prestador = await _contexto.CiudadanoPersona.Where(x => x.Id == persona.PrestadorPreferenciaId.ToString()).FirstOrDefaultAsync();

            buscador.NumeroDocumento = persona.NumeroDocumento;
            buscador.CorreoElectronico = persona.CorreoElectronico;
            buscador.PrimerNombre = persona.PrimerNombre;
            buscador.SegundoNombre = persona.SegundoNombre;
            buscador.PrimerApellido = persona.PrimerApellido;
            buscador.SegundoApellido = persona.SegundoApellido;
            buscador.FechaNacimiento = persona.FechaNacimiento.Value;
            buscador.SexoId = persona.SexoId.Value;
            buscador.Telefono = persona.Telefono;
            buscador.DireccionResidencia = persona.DireccionResidencia;
            buscador.PaisResidenciaId = persona.PaisResidenciaId;
            buscador.DepartamentoResidenciaId = persona.DepartamentoResidenciaId;
            buscador.MunicipioResidenciaId = persona.MunicipioResidenciaId;
            buscador.PrestadorPreferenciaId = persona.PrestadorPreferenciaId;
            buscador.PuntoAtencionId = persona.PuntoAtencionId;
            buscador.PrestadorPreferenciaNombre = prestador?.RazonSocial;
            //buscador.PreguntaSeguridadId = persona.PreguntaSeguridadId;
            //buscador.PreguntaSeguridadRespuesta = persona.PreguntaSeguridadRespuesta;
            buscador.LocalidadComunaId = persona.LocalidadComunaId;
            buscador.PreguntaLibre = persona.PreguntaLibre;
            //buscador.Activo = persona.Activo;
            buscador.BarrioResidencia = persona.BarrioResidencia;
            buscador.PerteneceARural = persona.PerteneceARural;
            buscador.OtroTelefono = persona.OtroTelefono;
            var direcciones = buscador.Direcciones?.FirstOrDefault()??new DireccionDTO();

            int ViaGeneradoraPlaca = int.TryParse(persona.ViaGeneradoraPlaca, out int result) ? result : 0;
            int ViaGeneradora = int.TryParse(persona.ViaGeneradora, out int result1) ? result1 : 0;

            direcciones.CiudadanoId = Guid.Parse(persona.Id);
            direcciones.ViaPrincipalId = persona.ViaPrincipalId;
            direcciones.ViaPrincipalNombre = persona.ViaPrincipalNombre;
            direcciones.ViaPrincipal = persona.ViaPrincipal;
            direcciones.ViaPrincipalLetraId = persona.ViaPrincipalLetraId;
            direcciones.ViaPrincipalLetraNombre = persona.ViaPrincipalLetraNombre;
            direcciones.ViaPrincipalBisId = persona.ViaPrincipalBisId;
            direcciones.ViaPrincipalBisNombre = persona.ViaPrincipalBisNombre;
            direcciones.ViaPrincipalSegundaLetraId = persona.ViaPrincipalSegundaLetraId;
            direcciones.ViaPrincipalSegundaLetraNombre = persona.ViaPrincipalSegundaLetraNombre;
            direcciones.ViaPrincipalCuadranteId = persona.ViaPrincipalCuadranteId;
            direcciones.ViaPrincipalCuadranteNombre = persona.ViaPrincipalCuadranteNombre;
            direcciones.ViaGeneradora = ViaGeneradora;
            direcciones.ViaGeneradoraLetraId = persona.ViaGeneradoraLetraId;
            direcciones.ViaGeneralLetraNombre = persona.ViaGeneralLetraNombre;
            direcciones.ViaGeneradoraPlaca = ViaGeneradoraPlaca;
            direcciones.ViaGeneradoraCuadranteId = persona.ViaGeneradoraCuadranteId;
            direcciones.ViaGeneradoraCuadranteNombre = persona.ViaGeneradoraCuadranteNombre;
            direcciones.Id =  (persona.DireccionId != null )?Guid.Parse(persona.DireccionId): null;


            var complemento = _contexto.CiudadanoPersonaDireccionComplemento.Where(x => x.IdDireccion == persona.DireccionId).ToList();
            var direccionComplementos = new List<DireccionComplementoDTO>();

            foreach (var item in complemento)
            {
                var direccionComplemento = new DireccionComplementoDTO();
                direccionComplemento.DireccionId = direcciones.Id;
                direccionComplemento.ComplementoId = item.IdComplemento;
                direccionComplemento.ComplementoNombre = item.NombreComplemento;
                direccionComplemento.Complemento = item.Complemento;
                direccionComplementos.Add(direccionComplemento);
            }

            direcciones.DireccionComplemento = direccionComplementos;

            buscador.Direcciones = new List<DireccionDTO>() { direcciones };

        }
    }
}
