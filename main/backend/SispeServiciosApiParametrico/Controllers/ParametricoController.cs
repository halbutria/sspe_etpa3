using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Parametrico.Aplicacion;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServiciosApiParametrico.DTOs;
using System.Text.RegularExpressions;

namespace SispeServicios.Api.Parametrico.Controllers
{

    public class ParametricoController : Controller
    {
        private readonly IMediator _mediator;


        public ParametricoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/[controller]/lista/{tipo}")]
        public async Task<ActionResult<List<ParametricoDTO>>> listaParametrico(Lista.ListaParametrico data)
        {
            return await _mediator.Send(data);
        }

        #region ServiciosAsociados
        [HttpGet("/[controller]/ServiciosAsociados/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetServiciosAsociados(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudServiciosAsociados.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/ServiciosAsociados")]
        public async Task<ActionResult<ParametricoDTO>> postServiciosAsociados([FromBody] Aplicacion.CrudServiciosAsociados.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/ServiciosAsociados")]
        public async Task<ActionResult<ParametricoDTO>> putServiciosAsociados([FromBody] Aplicacion.CrudServiciosAsociados.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/ServiciosAsociados/{Id}")]
        public async Task<ActionResult<Unit>> deleteServiciosAsociados(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudServiciosAsociados.Borrado.Ejecuta() { Id = Id });
        }

        #endregion

        #region ServiciosBasicos
        [HttpGet("/[controller]/ServiciosBasicos/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetServiciosBasicos(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudServiciosBasicos.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/ServiciosBasicos")]
        public async Task<ActionResult<ParametricoDTO>> postServiciosBasicos([FromBody] Aplicacion.CrudServiciosBasicos.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/ServiciosBasicos")]
        public async Task<ActionResult<ParametricoDTO>> putServiciosBasicos([FromBody] Aplicacion.CrudServiciosBasicos.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/ServiciosBasicos/{Id}")]
        public async Task<ActionResult<Unit>> deleteServiciosBasicos(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudServiciosBasicos.Borrado.Ejecuta() { Id = Id });
        }

        #endregion

        #region ServiciosOferta
        [HttpGet("/[controller]/ServiciosOferta/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetServiciosOferta(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudServiciosOferta.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/ServiciosOferta")]
        public async Task<ActionResult<ParametricoDTO>> postServiciosOferta([FromBody] Aplicacion.CrudServiciosOferta.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/ServiciosOferta")]
        public async Task<ActionResult<ParametricoDTO>> putServiciosOferta([FromBody] Aplicacion.CrudServiciosOferta.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/ServiciosOferta/{Id}")]
        public async Task<ActionResult<Unit>> deleteServiciosOferta(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudServiciosOferta.Borrado.Ejecuta() { Id = Id });
        }

        #endregion

        #region BrechaServiciosAsociados
        [HttpGet("/[controller]/BrechaServiciosAsociados/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetBrechaServiciosAsociados(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudBrechaServiciosAsociados.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/BrechaServiciosAsociados")]
        public async Task<ActionResult<ParametricoDTO>> postBrechaServiciosAsociados([FromBody] Aplicacion.CrudBrechaServiciosAsociados.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/BrechaServiciosAsociados")]
        public async Task<ActionResult<ParametricoDTO>> putBrechaServiciosAsociados([FromBody] Aplicacion.CrudBrechaServiciosAsociados.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/BrechaServiciosAsociados/{Id}")]
        public async Task<ActionResult<Unit>> deleteBrechaServiciosAsociados(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudBrechaServiciosAsociados.Borrado.Ejecuta() { Id = Id });
        }

        #endregion

        #region BrechaServiciosBasicos
        [HttpGet("/[controller]/BrechaServiciosBasicos/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetBrechaServiciosBasicos(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudBrechaServiciosBasicos.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/BrechaServiciosBasicos")]
        public async Task<ActionResult<ParametricoDTO>> postBrechaServiciosBasicos([FromBody] Aplicacion.CrudBrechaServiciosBasicos.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/BrechaServiciosBasicos")]
        public async Task<ActionResult<ParametricoDTO>> putBrechaServiciosBasicos([FromBody] Aplicacion.CrudBrechaServiciosBasicos.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/BrechaServiciosBasicos/{Id}")]
        public async Task<ActionResult<Unit>> deleteBrechaServiciosBasicos(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudBrechaServiciosBasicos.Borrado.Ejecuta() { Id = Id });
        }

        #endregion

        #region BrechaServiciosOferta
        [HttpGet("/[controller]/BrechaServiciosOferta/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetBrechaServiciosOferta(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudBrechaServiciosOferta.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/BrechaServiciosOferta")]
        public async Task<ActionResult<ParametricoDTO>> postBrechaServiciosOferta([FromBody] Aplicacion.CrudBrechaServiciosOferta.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/BrechaServiciosOferta")]
        public async Task<ActionResult<ParametricoDTO>> putBrechaServiciosOferta([FromBody] Aplicacion.CrudBrechaServiciosOferta.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/BrechaServiciosOferta/{Id}")]
        public async Task<ActionResult<Unit>> deleteBrechaServiciosOferta(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudBrechaServiciosOferta.Borrado.Ejecuta() { Id = Id });
        }

        #endregion

        #region ServiciosAsociadosBrecha
        [HttpGet("/[controller]/ServiciosAsociadosBrecha/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetServiciosAsociadosBrecha(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudServiciosAsociadosBrecha.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/ServiciosAsociadosBrecha")]
        public async Task<ActionResult<ParametricoDTO>> postServiciosAsociadosBrecha([FromBody] Aplicacion.CrudServiciosAsociadosBrecha.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/ServiciosAsociadosBrecha")]
        public async Task<ActionResult<ParametricoDTO>> putServiciosAsociadosBrecha([FromBody] Aplicacion.CrudServiciosAsociadosBrecha.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/ServiciosAsociadosBrecha/{Id}")]
        public async Task<ActionResult<Unit>> deleteServiciosAsociadosBrecha(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudServiciosAsociadosBrecha.Borrado.Ejecuta() { Id = Id });
        }

        #endregion

        #region ServiciosBasicosBrecha
        [HttpGet("/[controller]/ServiciosBasicosBrecha/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetServiciosBasicosBrecha(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudServiciosBasicosBrecha.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/ServiciosBasicosBrecha")]
        public async Task<ActionResult<ParametricoDTO>> postServiciosBasicosBrecha([FromBody] Aplicacion.CrudServiciosBasicosBrecha.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/ServiciosBasicosBrecha")]
        public async Task<ActionResult<ParametricoDTO>> putServiciosBasicosBrecha([FromBody] Aplicacion.CrudServiciosBasicosBrecha.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/ServiciosBasicosBrecha/{Id}")]
        public async Task<ActionResult<Unit>> deleteServiciosBasicosBrecha(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudServiciosBasicosBrecha.Borrado.Ejecuta() { Id = Id });
        }

        #endregion

        #region ServiciosOfertaBrecha
        [HttpGet("/[controller]/ServiciosOfertaBrecha/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetServiciosOfertaBrecha(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudServiciosOfertaBrecha.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/ServiciosOfertaBrecha")]
        public async Task<ActionResult<ParametricoDTO>> postServiciosOfertaBrecha([FromBody] Aplicacion.CrudServiciosOfertaBrecha.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/ServiciosOfertaBrecha")]
        public async Task<ActionResult<ParametricoDTO>> putServiciosOfertaBrecha([FromBody] Aplicacion.CrudServiciosOfertaBrecha.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/ServiciosOfertaBrecha/{Id}")]
        public async Task<ActionResult<Unit>> deleteServiciosOfertaBrecha(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudServiciosOfertaBrecha.Borrado.Ejecuta() { Id = Id });
        }

        #endregion

        [HttpGet("/[controller]/TipoDocumento/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> Get(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoDocumento.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoDocumento")]
        public async Task<ActionResult<ParametricoDTO>> nuevo([FromBody] Aplicacion.CrudTipoDocumento.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoDocumento")]
        public async Task<ActionResult<ParametricoDTO>> editar([FromBody] Aplicacion.CrudTipoDocumento.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoDocumento/{Id}")]
        public async Task<ActionResult<Unit>> Delete(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoDocumento.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoDireccion/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoDireccion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoDireccion.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoDireccion")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoDireccion([FromBody] Aplicacion.CrudTipoDireccion.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoDireccion")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoDireccion([FromBody] Aplicacion.CrudTipoDireccion.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoDireccion/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoDireccion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoDireccion.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoContrato/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoContrato(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoContrato.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoContrato")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoContrato([FromBody] Aplicacion.CrudTipoContrato.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoContrato")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoContrato([FromBody] Aplicacion.CrudTipoContrato.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoContrato/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoContrato(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoContrato.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoCapacitacion/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoCapacitacion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoCapacitacion.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoCapacitacion")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoCapacitacion([FromBody] Aplicacion.CrudTipoCapacitacion.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoCapacitacion")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoCapacitacion([FromBody] Aplicacion.CrudTipoCapacitacion.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoCapacitacion/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoCapacitacion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoCapacitacion.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoExperiencia/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoExperiencia(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoExperiencia.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoExperiencia")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoExperiencia([FromBody] Aplicacion.CrudTipoExperiencia.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoExperiencia")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoExperiencia([FromBody] Aplicacion.CrudTipoExperiencia.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoExperiencia/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoExperiencia(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoExperiencia.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoExperienciaPrevia/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoExperienciaPrevia(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoExperienciaPrevia.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoExperienciaPrevia")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoExperienciaPrevia([FromBody] Aplicacion.CrudTipoExperienciaPrevia.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoExperienciaPrevia")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoExperienciaPrevia([FromBody] Aplicacion.CrudTipoExperienciaPrevia.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoExperienciaPrevia/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoExperienciaPrevia(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoExperienciaPrevia.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoLibretaMilitar/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoLibretaMilitar(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoLibretaMilitar.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoLibretaMilitar")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoLibretaMilitar([FromBody] Aplicacion.CrudTipoLibretaMilitar.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoLibretaMilitar")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoLibretaMilitar([FromBody] Aplicacion.CrudTipoLibretaMilitar.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoLibretaMilitar/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoLibretaMilitar(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoLibretaMilitar.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoNotificacion/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoNotificacion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoNotificacion.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoNotificacion")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoNotificacion([FromBody] Aplicacion.CrudTipoNotificacion.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoNotificacion")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoNotificacion([FromBody] Aplicacion.CrudTipoNotificacion.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoNotificacion/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoNotificacion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoNotificacion.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoZonaGeografica/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoZonaGeografica(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoZonaGeografica.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoZonaGeografica")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoZonaGeografica([FromBody] Aplicacion.CrudTipoZonaGeografica.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoZonaGeografica")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoZonaGeografica([FromBody] Aplicacion.CrudTipoZonaGeografica.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoZonaGeografica/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoZonaGeografica(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoZonaGeografica.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoPoblacion/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoPoblacion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoPoblacion.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoPoblacion")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoPoblacion([FromBody] Aplicacion.CrudTipoPoblacion.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoPoblacion")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoPoblacion([FromBody] Aplicacion.CrudTipoPoblacion.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoPoblacion/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoPoblacion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoPoblacion.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoPoblacionVulnerable/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoPoblacionVulnerable(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoPoblacionVulnerable.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoPoblacionVulnerable")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoPoblacionVulnerable([FromBody] Aplicacion.CrudTipoPoblacionVulnerable.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoPoblacionVulnerable")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoPoblacionVulnerable([FromBody] Aplicacion.CrudTipoPoblacionVulnerable.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoPoblacionVulnerable/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoPoblacionVulnerable(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoPoblacionVulnerable.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoProyecto/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoProyecto(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoProyecto.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoProyecto")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoProyecto([FromBody] Aplicacion.CrudTipoProyecto.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoProyecto")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoProyecto([FromBody] Aplicacion.CrudTipoProyecto.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoProyecto/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoProyecto(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoProyecto.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoSalario/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoSalario(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoSalario.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoSalario")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoSalario([FromBody] Aplicacion.CrudTipoSalario.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoSalario")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoSalario([FromBody] Aplicacion.CrudTipoSalario.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoSalario/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoSalario(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoSalario.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoSituacionLaboral/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoSituacionLaboral(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoSituacionLaboral.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoSituacionLaboral")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoSituacionLaboral([FromBody] Aplicacion.CrudTipoSituacionLaboral.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoSituacionLaboral")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoSituacionLaboral([FromBody] Aplicacion.CrudTipoSituacionLaboral.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoSituacionLaboral/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoSituacionLaboral(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoSituacionLaboral.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoUbicacion/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoUbicacion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoUbicacion.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoUbicacion")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoUbicacion([FromBody] Aplicacion.CrudTipoUbicacion.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoUbicacion")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoUbicacion([FromBody] Aplicacion.CrudTipoUbicacion.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoUbicacion/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoUbicacion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoUbicacion.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TituloNivelEducativo/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTituloNivelEducativo(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTituloNivelEducativo.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TituloNivelEducativo")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTituloNivelEducativo([FromBody] Aplicacion.CrudTituloNivelEducativo.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TituloNivelEducativo")]
        public async Task<ActionResult<ParametricoDTO>> editarTituloNivelEducativo([FromBody] Aplicacion.CrudTituloNivelEducativo.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TituloNivelEducativo/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTituloNivelEducativo(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTituloNivelEducativo.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/NivelCompetencia/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetNivelCompetencia(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudNivelCompetencia.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/NivelCompetencia")]
        public async Task<ActionResult<ParametricoDTO>> nuevoNivelCompetencia([FromBody] Aplicacion.CrudNivelCompetencia.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/NivelCompetencia")]
        public async Task<ActionResult<ParametricoDTO>> editarNivelCompetencia([FromBody] Aplicacion.CrudNivelCompetencia.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/NivelCompetencia/{Id}")]
        public async Task<ActionResult<Unit>> DeleteNivelCompetencia(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudNivelCompetencia.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/NivelDominioIdioma/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetNivelDominioIdioma(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudNivelDominioIdioma.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/NivelDominioIdioma")]
        public async Task<ActionResult<ParametricoDTO>> nuevoNivelDominioIdioma([FromBody] Aplicacion.CrudNivelDominioIdioma.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/NivelDominioIdioma")]
        public async Task<ActionResult<ParametricoDTO>> editarNivelDominioIdioma([FromBody] Aplicacion.CrudNivelDominioIdioma.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/NivelDominioIdioma/{Id}")]
        public async Task<ActionResult<Unit>> DeleteNivelDominioIdioma(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudNivelDominioIdioma.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/Genero/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetGenero(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudGenero.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/Genero")]
        public async Task<ActionResult<ParametricoDTO>> nuevoGenero([FromBody] Aplicacion.CrudGenero.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/Genero")]
        public async Task<ActionResult<ParametricoDTO>> editarGenero([FromBody] Aplicacion.CrudGenero.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/Genero/{Id}")]
        public async Task<ActionResult<Unit>> DeleteGenero(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudGenero.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/JornadaLaboral/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetJornadaLaboral(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudJornadaLaboral.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/JornadaLaboral")]
        public async Task<ActionResult<ParametricoDTO>> nuevoJornadaLaboral([FromBody] Aplicacion.CrudJornadaLaboral.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/JornadaLaboral")]
        public async Task<ActionResult<ParametricoDTO>> editarJornadaLaboral([FromBody] Aplicacion.CrudJornadaLaboral.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/JornadaLaboral/{Id}")]
        public async Task<ActionResult<Unit>> DeleteJornadaLaboral(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudJornadaLaboral.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/PreguntaSeguridad/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetPreguntaSeguridad(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudPreguntaSeguridad.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/PreguntaSeguridad")]
        public async Task<ActionResult<ParametricoDTO>> nuevoPreguntaSeguridad([FromBody] Aplicacion.CrudPreguntaSeguridad.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/PreguntaSeguridad")]
        public async Task<ActionResult<ParametricoDTO>> editarPreguntaSeguridad([FromBody] Aplicacion.CrudPreguntaSeguridad.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/PreguntaSeguridad/{Id}")]
        public async Task<ActionResult<Unit>> DeletePreguntaSeguridad(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudPreguntaSeguridad.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/CategoriaLicencia/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetCategoriaLicencia(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCategoriaLicencia.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/CategoriaLicencia")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCategoriaLicencia([FromBody] Aplicacion.CrudCategoriaLicencia.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/CategoriaLicencia")]
        public async Task<ActionResult<ParametricoDTO>> editarCategoriaLicencia([FromBody] Aplicacion.CrudCategoriaLicencia.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/CategoriaLicencia/{Id}")]
        public async Task<ActionResult<Unit>> DeleteCategoriaLicencia(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCategoriaLicencia.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/MotivoExcepcionalidad/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetMotivoExcepcionalidad(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudMotivoExcepcionalidad.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/MotivoExcepcionalidad")]
        public async Task<ActionResult<ParametricoDTO>> nuevoMotivoExcepcionalidad([FromBody] Aplicacion.CrudMotivoExcepcionalidad.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/MotivoExcepcionalidad")]
        public async Task<ActionResult<ParametricoDTO>> editarMotivoExcepcionalidad([FromBody] Aplicacion.CrudMotivoExcepcionalidad.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/MotivoExcepcionalidad/{Id}")]
        public async Task<ActionResult<Unit>> DeleteMotivoExcepcionalidad(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudMotivoExcepcionalidad.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/Idioma/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetIdioma(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudIdioma.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/Idioma")]
        public async Task<ActionResult<ParametricoDTO>> nuevoIdioma([FromBody] Aplicacion.CrudIdioma.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/Idioma")]
        public async Task<ActionResult<ParametricoDTO>> editarIdioma([FromBody] Aplicacion.CrudIdioma.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/Idioma/{Id}")]
        public async Task<ActionResult<Unit>> DeleteIdioma(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudIdioma.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/ModalidadTrabajo/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetModalidadTrabajo(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudModalidadTrabajo.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/ModalidadTrabajo")]
        public async Task<ActionResult<ParametricoDTO>> nuevoModalidadTrabajo([FromBody] Aplicacion.CrudModalidadTrabajo.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/ModalidadTrabajo")]
        public async Task<ActionResult<ParametricoDTO>> editarModalidadTrabajo([FromBody] Aplicacion.CrudModalidadTrabajo.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/ModalidadTrabajo/{Id}")]
        public async Task<ActionResult<Unit>> DeleteModalidadTrabajo(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudModalidadTrabajo.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/Discapacidad/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetDiscapacidad(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudDiscapacidad.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/Discapacidad")]
        public async Task<ActionResult<ParametricoDTO>> nuevoDiscapacidad([FromBody] Aplicacion.CrudDiscapacidad.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/Discapacidad")]
        public async Task<ActionResult<ParametricoDTO>> editarDiscapacidad([FromBody] Aplicacion.CrudDiscapacidad.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/Discapacidad/{Id}")]
        public async Task<ActionResult<Unit>> DeleteDiscapacidad(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudDiscapacidad.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/SectorEconomico/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetSectorEconomico(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudSectorEconomico.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/SectorEconomico")]
        public async Task<ActionResult<ParametricoDTO>> nuevoSectorEconomico([FromBody] Aplicacion.CrudSectorEconomico.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/SectorEconomico")]
        public async Task<ActionResult<ParametricoDTO>> editarSectorEconomico([FromBody] Aplicacion.CrudSectorEconomico.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/SectorEconomico/{Id}")]
        public async Task<ActionResult<Unit>> DeleteSectorEconomico(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudSectorEconomico.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/SubsectorEconomico/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetSubsectorEconomico(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudSubsectorEconomico.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/SubsectorEconomico")]
        public async Task<ActionResult<ParametricoDTO>> nuevoSubsectorEconomico([FromBody] Aplicacion.CrudSubsectorEconomico.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/SubsectorEconomico")]
        public async Task<ActionResult<ParametricoDTO>> editarSubsectorEconomico([FromBody] Aplicacion.CrudSubsectorEconomico.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/SubsectorEconomico/{Id}")]
        public async Task<ActionResult<Unit>> DeleteSubsectorEconomico(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudSubsectorEconomico.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/NivelEducativo/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetNivelEducativo(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudNivelEducativo.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/NivelEducativo")]
        public async Task<ActionResult<ParametricoDTO>> nuevoNivelEducativo([FromBody] Aplicacion.CrudNivelEducativo.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/NivelEducativo")]
        public async Task<ActionResult<ParametricoDTO>> editarNivelEducativo([FromBody] Aplicacion.CrudNivelEducativo.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/NivelEducativo/{Id}")]
        public async Task<ActionResult<Unit>> DeleteNivelEducativo(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudNivelEducativo.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/FluidezIdioma/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetFluidezIdioma(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudFluidezIdioma.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/FluidezIdioma")]
        public async Task<ActionResult<ParametricoDTO>> nuevoFluidezIdioma([FromBody] Aplicacion.CrudFluidezIdioma.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/FluidezIdioma")]
        public async Task<ActionResult<ParametricoDTO>> editarFluidezIdioma([FromBody] Aplicacion.CrudFluidezIdioma.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/FluidezIdioma/{Id}")]
        public async Task<ActionResult<Unit>> DeleteFluidezIdioma(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudFluidezIdioma.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/MensajePreseleccion/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetMensajePreseleccion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudMensajePreseleccion.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/MensajePreseleccion")]
        public async Task<ActionResult<ParametricoDTO>> nuevoMensajePreseleccion([FromBody] Aplicacion.CrudMensajePreseleccion.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/MensajePreseleccion")]
        public async Task<ActionResult<ParametricoDTO>> editarMensajePreseleccion([FromBody] Aplicacion.CrudMensajePreseleccion.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/MensajePreseleccion/{Id}")]
        public async Task<ActionResult<Unit>> DeleteMensajePreseleccion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudMensajePreseleccion.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/InformacionLaboral/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetInformacionLaboral(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudInformacionLaboral.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/InformacionLaboral")]
        public async Task<ActionResult<ParametricoDTO>> nuevoInformacionLaboral([FromBody] Aplicacion.CrudInformacionLaboral.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/InformacionLaboral")]
        public async Task<ActionResult<ParametricoDTO>> editarInformacionLaboral([FromBody] Aplicacion.CrudInformacionLaboral.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/InformacionLaboral/{Id}")]
        public async Task<ActionResult<Unit>> DeleteInformacionLaboral(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudInformacionLaboral.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/Terminos/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTerminos(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTerminos.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/Terminos")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTerminos([FromBody] Aplicacion.CrudTerminos.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/Terminos")]
        public async Task<ActionResult<ParametricoDTO>> editarTerminos([FromBody] Aplicacion.CrudTerminos.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/Terminos/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTerminos(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTerminos.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/MotivoRechazo/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetMotivoRechazo(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudMotivoRechazo.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/MotivoRechazo")]
        public async Task<ActionResult<ParametricoDTO>> nuevoMotivoRechazo([FromBody] Aplicacion.CrudMotivoRechazo.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/MotivoRechazo")]
        public async Task<ActionResult<ParametricoDTO>> editarMotivoRechazo([FromBody] Aplicacion.CrudMotivoRechazo.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/MotivoRechazo/{Id}")]
        public async Task<ActionResult<Unit>> DeleteMotivoRechazo(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudMotivoRechazo.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoPrestador/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoPrestador(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoPrestador.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoPrestador")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoPrestador([FromBody] Aplicacion.CrudTipoPrestador.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoPrestador")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoPrestador([FromBody] Aplicacion.CrudTipoPrestador.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoPrestador/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoPrestador(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoPrestador.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/EstadoVacante/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetEstadoVacante(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudEstadoVacante.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/EstadoVacante")]
        public async Task<ActionResult<ParametricoDTO>> nuevoEstadoVacante([FromBody] Aplicacion.CrudEstadoVacante.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/EstadoVacante")]
        public async Task<ActionResult<ParametricoDTO>> editarEstadoVacante([FromBody] Aplicacion.CrudEstadoVacante.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/EstadoVacante/{Id}")]
        public async Task<ActionResult<Unit>> DeleteEstadoVacante(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudEstadoVacante.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/CriterioMatch/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetCriterioMatch(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCriterioMatch.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/CriterioMatch")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCriterioMatch([FromBody] Aplicacion.CrudCriterioMatch.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/CriterioMatch")]
        public async Task<ActionResult<ParametricoDTO>> editarCriterioMatch([FromBody] Aplicacion.CrudCriterioMatch.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/CriterioMatch/{Id}")]
        public async Task<ActionResult<Unit>> DeleteCriterioMatch(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCriterioMatch.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/PlantillaDescripcionVacante/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetPlantillaDescripcionVacante(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudPlantillaDescripcionVacante.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/PlantillaDescripcionVacante")]
        public async Task<ActionResult<ParametricoDTO>> nuevoPlantillaDescripcionVacante([FromBody] Aplicacion.CrudPlantillaDescripcionVacante.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/PlantillaDescripcionVacante")]
        public async Task<ActionResult<ParametricoDTO>> editarPlantillaDescripcionVacante([FromBody] Aplicacion.CrudPlantillaDescripcionVacante.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/PlantillaDescripcionVacante/{Id}")]
        public async Task<ActionResult<Unit>> DeletePlantillaDescripcionVacante(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudPlantillaDescripcionVacante.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/MotivoAmpliarZona/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetMotivoAmpliarZona(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudMotivoAmpliarZona.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/MotivoAmpliarZona")]
        public async Task<ActionResult<ParametricoDTO>> nuevoMotivoAmpliarZona([FromBody] Aplicacion.CrudMotivoAmpliarZona.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/MotivoAmpliarZona")]
        public async Task<ActionResult<ParametricoDTO>> editarMotivoAmpliarZona([FromBody] Aplicacion.CrudMotivoAmpliarZona.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/MotivoAmpliarZona/{Id}")]
        public async Task<ActionResult<Unit>> DeleteMotivoAmpliarZona(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudMotivoAmpliarZona.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/MotivoCambioPrestador/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetMotivoCambioPrestador(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudMotivoCambioPrestador.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/MotivoCambioPrestador")]
        public async Task<ActionResult<ParametricoDTO>> nuevoMotivoCambioPrestador([FromBody] Aplicacion.CrudMotivoCambioPrestador.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/MotivoCambioPrestador")]
        public async Task<ActionResult<ParametricoDTO>> editarMotivoCambioPrestador([FromBody] Aplicacion.CrudMotivoCambioPrestador.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/MotivoCambioPrestador/{Id}")]
        public async Task<ActionResult<Unit>> DeleteMotivoCambioPrestador(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudMotivoCambioPrestador.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/PlantillaMensaje/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetPlantillaMensaje(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudPlantillaMensaje.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/PlantillaMensaje")]
        public async Task<ActionResult<ParametricoDTO>> nuevoPlantillaMensaje([FromBody] Aplicacion.CrudPlantillaMensaje.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/PlantillaMensaje")]
        public async Task<ActionResult<ParametricoDTO>> editarPlantillaMensaje([FromBody] Aplicacion.CrudPlantillaMensaje.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/PlantillaMensaje/{Id}")]
        public async Task<ActionResult<Unit>> DeletePlantillaMensaje(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudPlantillaMensaje.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/Institucion/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetInstitucion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudInstitucion.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/Institucion")]
        public async Task<ActionResult<ParametricoDTO>> nuevoInstitucion([FromBody] Aplicacion.CrudInstitucion.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/Institucion")]
        public async Task<ActionResult<ParametricoDTO>> editarInstitucion([FromBody] Aplicacion.CrudInstitucion.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/Institucion/{Id}")]
        public async Task<ActionResult<Unit>> DeleteInstitucion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudInstitucion.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/DireccionTipoVia/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetDireccionTipoVia(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudDireccionTipoVia.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/DireccionTipoVia")]
        public async Task<ActionResult<ParametricoDTO>> nuevoDireccionTipoVia([FromBody] Aplicacion.CrudDireccionTipoVia.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/DireccionTipoVia")]
        public async Task<ActionResult<ParametricoDTO>> editarDireccionTipoVia([FromBody] Aplicacion.CrudDireccionTipoVia.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/DireccionTipoVia/{Id}")]
        public async Task<ActionResult<Unit>> DeleteDireccionTipoVia(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudDireccionTipoVia.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/DireccionLetra/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetDireccionLetra(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudDireccionLetra.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/DireccionLetra")]
        public async Task<ActionResult<ParametricoDTO>> nuevoDireccionLetra([FromBody] Aplicacion.CrudDireccionLetra.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/DireccionLetra")]
        public async Task<ActionResult<ParametricoDTO>> editarDireccionLetra([FromBody] Aplicacion.CrudDireccionLetra.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/DireccionLetra/{Id}")]
        public async Task<ActionResult<Unit>> DeleteDireccionLetra(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudDireccionLetra.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/DireccionCuadrante/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetDireccionCuadrante(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudDireccionCuadrante.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/DireccionCuadrante")]
        public async Task<ActionResult<ParametricoDTO>> nuevoDireccionCuadrante([FromBody] Aplicacion.CrudDireccionCuadrante.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/DireccionCuadrante")]
        public async Task<ActionResult<ParametricoDTO>> editarDireccionCuadrante([FromBody] Aplicacion.CrudDireccionCuadrante.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/DireccionCuadrante/{Id}")]
        public async Task<ActionResult<Unit>> DeleteDireccionCuadrante(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudDireccionCuadrante.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/DireccionComplemento/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetDireccionComplemento(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudDireccionComplemento.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/DireccionComplemento")]
        public async Task<ActionResult<ParametricoDTO>> nuevoDireccionComplemento([FromBody] Aplicacion.CrudDireccionComplemento.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/DireccionComplemento")]
        public async Task<ActionResult<ParametricoDTO>> editarDireccionComplemento([FromBody] Aplicacion.CrudDireccionComplemento.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/DireccionComplemento/{Id}")]
        public async Task<ActionResult<Unit>> DeleteDireccionComplemento(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudDireccionComplemento.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/Profesion/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetProfesion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudProfesion.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/Profesion")]
        public async Task<ActionResult<ParametricoDTO>> nuevoProfesion([FromBody] Aplicacion.CrudProfesion.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/Profesion")]
        public async Task<ActionResult<ParametricoDTO>> editarProfesion([FromBody] Aplicacion.CrudProfesion.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/Profesion/{Id}")]
        public async Task<ActionResult<Unit>> DeleteProfesion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudProfesion.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/RangoSalarial/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetRangoSalarial(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudRangoSalarial.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/RangoSalarial")]
        public async Task<ActionResult<ParametricoDTO>> nuevoRangoSalarial([FromBody] Aplicacion.CrudRangoSalarial.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/RangoSalarial")]
        public async Task<ActionResult<ParametricoDTO>> editarRangoSalarial([FromBody] Aplicacion.CrudRangoSalarial.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/RangoSalarial/{Id}")]
        public async Task<ActionResult<Unit>> DeleteRangoSalarial(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudRangoSalarial.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/AreaInfluencia/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetAreaInfluencia(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAreaInfluencia.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/AreaInfluencia")]
        public async Task<ActionResult<ParametricoDTO>> nuevoAreaInfluencia([FromBody] Aplicacion.CrudAreaInfluencia.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/AreaInfluencia")]
        public async Task<ActionResult<ParametricoDTO>> editarAreaInfluencia([FromBody] Aplicacion.CrudAreaInfluencia.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/AreaInfluencia/{Id}")]
        public async Task<ActionResult<Unit>> DeleteAreaInfluencia(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAreaInfluencia.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/DivisionTerritorial/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetDivisionTerritorial(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudDivisionTerritorial.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/DivisionTerritorial")]
        public async Task<ActionResult<ParametricoDTO>> nuevoDivisionTerritorial([FromBody] Aplicacion.CrudDivisionTerritorial.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/DivisionTerritorial")]
        public async Task<ActionResult<ParametricoDTO>> editarDivisionTerritorial([FromBody] Aplicacion.CrudDivisionTerritorial.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/DivisionTerritorial/{Id}")]
        public async Task<ActionResult<Unit>> DeleteDivisionTerritorial(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudDivisionTerritorial.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/NucleoConocimientoHidrocarburos/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetNucleoConocimientoHidrocarburos(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudNucleoConocimientoHidrocarburos.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/NucleoConocimientoHidrocarburos")]
        public async Task<ActionResult<ParametricoDTO>> nuevoNucleoConocimientoHidrocarburos([FromBody] Aplicacion.CrudNucleoConocimientoHidrocarburos.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/NucleoConocimientoHidrocarburos")]
        public async Task<ActionResult<ParametricoDTO>> editarNucleoConocimientoHidrocarburos([FromBody] Aplicacion.CrudNucleoConocimientoHidrocarburos.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/NucleoConocimientoHidrocarburos/{Id}")]
        public async Task<ActionResult<Unit>> DeleteNucleoConocimientoHidrocarburos(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudNucleoConocimientoHidrocarburos.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/ConfiguracionAvanceHojaVida/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetConfiguracionAvanceHojaVida(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudConfiguracionAvanceHojaVida.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/ConfiguracionAvanceHojaVida")]
        public async Task<ActionResult<ParametricoDTO>> nuevoConfiguracionAvanceHojaVida([FromBody] Aplicacion.CrudConfiguracionAvanceHojaVida.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/ConfiguracionAvanceHojaVida")]
        public async Task<ActionResult<ParametricoDTO>> editarConfiguracionAvanceHojaVida([FromBody] Aplicacion.CrudConfiguracionAvanceHojaVida.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/ConfiguracionAvanceHojaVida/{Id}")]
        public async Task<ActionResult<Unit>> DeleteConfiguracionAvanceHojaVida(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudConfiguracionAvanceHojaVida.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/AreaConocimiento/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetAreaConocimiento(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAreaConocimiento.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/AreaConocimiento")]
        public async Task<ActionResult<ParametricoDTO>> nuevoAreaConocimiento([FromBody] Aplicacion.CrudAreaConocimiento.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/AreaConocimiento")]
        public async Task<ActionResult<ParametricoDTO>> editarAreaConocimiento([FromBody] Aplicacion.CrudAreaConocimiento.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/AreaConocimiento/{Id}")]
        public async Task<ActionResult<Unit>> DeleteAreaConocimiento(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAreaConocimiento.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/TipoVacante/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetTipoVacante(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoVacante.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/TipoVacante")]
        public async Task<ActionResult<ParametricoDTO>> nuevoTipoVacante([FromBody] Aplicacion.CrudTipoVacante.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/TipoVacante")]
        public async Task<ActionResult<ParametricoDTO>> editarTipoVacante([FromBody] Aplicacion.CrudTipoVacante.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/TipoVacante/{Id}")]
        public async Task<ActionResult<Unit>> DeleteTipoVacante(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudTipoVacante.Borrado.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/AsociarInstitucionNivelEducativo")]
        public async Task<ActionResult<ParametricoDTO>> AsociarInstitucionNivelEducativo([FromBody] Aplicacion.CrudInstitucionNivelEducativo.AsociarInstitucionNivelEducativo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpGet("/[controller]/ObtenerInstitucionesPorNivelEducativo/{NivelEducativoId}")]
        public async Task<ActionResult<List<ParametricoDTO>>> ObtenerInstitucionesPorNivelEducativo(string NivelEducativoId)
        {
            return await _mediator.Send(new Aplicacion.CrudInstitucionNivelEducativo.ObtenerInstitucionesPorNivelEducativo.Ejecuta() { NivelEducativoId = NivelEducativoId });
        }

        [HttpGet("/[controller]/ObtenerNivelesEducativosPorInstitucion/{InstitucionId}")]
        public async Task<ActionResult<List<ParametricoDTO>>> ObtenerNivelesEducativosPorInstitucion(string InstitucionId)
        {
            return await _mediator.Send(new Aplicacion.CrudInstitucionNivelEducativo.ObtenerNivelesEducativosPorInstitucion.Ejecuta() { InstitucionId = InstitucionId });
        }

        [HttpDelete("/[controller]/EliminarAsociacionInstitucionNivelEducativo/{NivelEducativoId}/{InstitucionId}")]
        public async Task<ActionResult<Unit>> EliminarAsociacionInstitucionNivelEducativo(string NivelEducativoId, string InstitucionId)
        {
            return await _mediator.Send(new Aplicacion.CrudInstitucionNivelEducativo.EliminarAsociacionInstitucionNivelEducativo.Ejecuta() { NivelEducativoId = NivelEducativoId, InstitucionId = InstitucionId });
        }


        [HttpGet("/[controller]/EstadoCivil/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetEstadoCivil(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudEstadoCivil.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/EstadoCivil")]
        public async Task<ActionResult<ParametricoDTO>> nuevoEstadoCivil([FromBody] Aplicacion.CrudEstadoCivil.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/EstadoCivil")]
        public async Task<ActionResult<ParametricoDTO>> editarEstadoCivil([FromBody] Aplicacion.CrudEstadoCivil.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/EstadoCivil/{Id}")]
        public async Task<ActionResult<Unit>> DeleteEstadoCivil(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudEstadoCivil.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/NumeroIntentosIngreso/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetIntentosIngreso(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudNumeroIntentosIngreso.Consulta.Ejecuta() { Id = Id });
        }


        [HttpPut("/[controller]/NumeroIntentosIngreso")]
        public async Task<ActionResult<ParametricoDTO>> editarIntentosIngreso([FromBody] Aplicacion.CrudNumeroIntentosIngreso.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/CierreSesion")]
        public async Task<ActionResult<ParametricoDTO>> editarCierreSesion([FromBody] Aplicacion.CrudCierreSesion.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpGet("/[controller]/CierreSesion/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetIntentosCierreSesion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCierreSesion.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPut("/[controller]/ControlPesoNumeroArchivosCargar")]
        public async Task<ActionResult<ParametricoDTO>> editarControlPesoNumeroArchivosCargar([FromBody] Aplicacion.CrudControlPesoNumeroArchivosCargar.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpGet("/[controller]/ControlPesoNumeroArchivosCargar/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> GetControlPesoNumeroArchivosCargar(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudControlPesoNumeroArchivosCargar.Consulta.Ejecuta() { Id = Id });
        }


        [HttpGet("/[controller]/EstadoFasesProcesoSeleccion/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getEstadoFaseProcesoSelec(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudEstadoFasesProcesoSeleccion.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/EstadoFasesProcesoSeleccion")]
        public async Task<ActionResult<ParametricoDTO>> nuevoEstadoFaseProcesoSelec([FromBody] Aplicacion.CrudEstadoFasesProcesoSeleccion.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/EstadoFasesProcesoSeleccion")]
        public async Task<ActionResult<ParametricoDTO>> editarEstadoFaseProcesoSelec([FromBody] Aplicacion.CrudEstadoFasesProcesoSeleccion.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/EstadoFasesProcesoSeleccion/{Id}")]
        public async Task<ActionResult<Unit>> deleteEstadoFaseProcesoSelec(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudEstadoFasesProcesoSeleccion.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/CondicionSaludMental/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCondicionSaludMental(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCondicionSaludMental.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/CondicionSaludMental")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCondicionSaludMental([FromBody] Aplicacion.CrudCondicionSaludMental.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/CondicionSaludMental")]
        public async Task<ActionResult<ParametricoDTO>> editarCondicionSaludMental([FromBody] Aplicacion.CrudCondicionSaludMental.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/CondicionSaludMental/{Id}")]
        public async Task<ActionResult<Unit>> deleteCondicionSaludMental(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCondicionSaludMental.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/InactivarCuentaEmpresarial/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCrudInactivarCuentaEmpresarial(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudInactivarCuentaEmpresarial.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/InactivarCuentaEmpresarial")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCrudInactivarCuentaEmpresarial([FromBody] Aplicacion.CrudInactivarCuentaEmpresarial.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/InactivarCuentaEmpresarial")]
        public async Task<ActionResult<ParametricoDTO>> editarCrudInactivarCuentaEmpresarial([FromBody] Aplicacion.CrudInactivarCuentaEmpresarial.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/InactivarCuentaEmpresarial/{Id}")]
        public async Task<ActionResult<Unit>> deleteCrudInactivarCuentaEmpresarial(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudInactivarCuentaEmpresarial.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/FlujoEncuestaSatisfaccionAsistenciaIngreso/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getFlujoEncuestaSatisfaccionAsistenciaIngreso(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudFlujoEncuestaSatisfaccionAsistIngreso.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/FlujoEncuestaSatisfaccionAsistenciaIngreso")]
        public async Task<ActionResult<ParametricoDTO>> nuevoFlujoEncuestaSatisfaccionAsistenciaIngreso([FromBody] Aplicacion.CrudFlujoEncuestaSatisfaccionAsistIngreso.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/FlujoEncuestaSatisfaccionAsistenciaIngreso")]
        public async Task<ActionResult<ParametricoDTO>> editarFlujoEncuestaSatisfaccionAsistenciaIngreso([FromBody] Aplicacion.CrudFlujoEncuestaSatisfaccionAsistIngreso.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/FlujoEncuestaSatisfaccionAsistenciaIngreso/{Id}")]
        public async Task<ActionResult<Unit>> deleteFlujoEncuestaSatisfaccionAsistenciaIngreso(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudFlujoEncuestaSatisfaccionAsistIngreso.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/PreguntasFrecuentes/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getPreguntasFrecuentes(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudPreguntasFrecuentes.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/PreguntasFrecuentes")]
        public async Task<ActionResult<ParametricoDTO>> nuevoPreguntasFrecuentes([FromBody] Aplicacion.CrudPreguntasFrecuentes.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/PreguntasFrecuentes")]
        public async Task<ActionResult<ParametricoDTO>> editarPreguntasFrecuentes([FromBody] Aplicacion.CrudPreguntasFrecuentes.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/PreguntasFrecuentes/{Id}")]
        public async Task<ActionResult<Unit>> deletePreguntasFrecuentes(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudPreguntasFrecuentes.Borrado.Ejecuta() { Id = Id });
        }


        [HttpGet("/[controller]/RecepcionNotificaciones/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getRecepcionNotificaciones(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudRecepcionNotificaciones.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/RecepcionNotificaciones")]
        public async Task<ActionResult<ParametricoDTO>> nuevoRecepcionNotificaciones([FromBody] Aplicacion.CrudRecepcionNotificaciones.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/RecepcionNotificaciones")]
        public async Task<ActionResult<ParametricoDTO>> editarRecepcionNotificaciones([FromBody] Aplicacion.CrudRecepcionNotificaciones.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/RecepcionNotificaciones/{Id}")]
        public async Task<ActionResult<Unit>> deleteRecepcionNotificaciones(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudRecepcionNotificaciones.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/CanalesNotificacion/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCanalesNotificacion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCanalesNotificacion.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/CanalesNotificacion")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCanalesNotificacion([FromBody] Aplicacion.CrudCanalesNotificacion.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/CanalesNotificacion")]
        public async Task<ActionResult<ParametricoDTO>> editarCanalesNotificacion([FromBody] Aplicacion.CrudCanalesNotificacion.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/CanalesNotificacion/{Id}")]
        public async Task<ActionResult<Unit>> deleteCanalesNotificacion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCanalesNotificacion.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/GrupoEtnico/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getGrupoEtnico(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudGrupoEtnico.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/GrupoEtnico")]
        public async Task<ActionResult<ParametricoDTO>> nuevoGrupoEtnico([FromBody] Aplicacion.CrudGrupoEtnico.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/GrupoEtnico")]
        public async Task<ActionResult<ParametricoDTO>> editarGrupoEtnico([FromBody] Aplicacion.CrudGrupoEtnico.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/GrupoEtnico/{Id}")]
        public async Task<ActionResult<Unit>> deleteGrupoEtnico(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudGrupoEtnico.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/EncuestaSistema/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getEncuestaSistema(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudEncuestaSistema.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/EncuestaSistema")]
        public async Task<ActionResult<ParametricoDTO>> nuevoEncuestaSistema([FromBody] Aplicacion.CrudEncuestaSistema.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/EncuestaSistema")]
        public async Task<ActionResult<ParametricoDTO>> editarEncuestaSistema([FromBody] Aplicacion.CrudEncuestaSistema.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/EncuestaSistema/{Id}")]
        public async Task<ActionResult<Unit>> deleteEncuestaSistema(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudEncuestaSistema.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/PasosRutaEmpleabilidad/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getPasosRutaEmpleabilidad(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudPasosRutaEmpleabilidad.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/PasosRutaEmpleabilidad")]
        public async Task<ActionResult<ParametricoDTO>> nuevoPasosRutaEmpleabilidad([FromBody] Aplicacion.CrudPasosRutaEmpleabilidad.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/PasosRutaEmpleabilidad")]
        public async Task<ActionResult<ParametricoDTO>> editarPasosRutaEmpleabilidad([FromBody] Aplicacion.CrudPasosRutaEmpleabilidad.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/PasosRutaEmpleabilidad/{Id}")]
        public async Task<ActionResult<Unit>> deletePasosRutaEmpleabilidad(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudPasosRutaEmpleabilidad.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/InactivacionCuenta/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getInactivacionCuenta(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudInactivacionCuenta.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/InactivacionCuenta")]
        public async Task<ActionResult<ParametricoDTO>> nuevoInactivacionCuenta([FromBody] Aplicacion.CrudInactivacionCuenta.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/InactivacionCuenta")]
        public async Task<ActionResult<ParametricoDTO>> editarInactivacionCuenta([FromBody] Aplicacion.CrudInactivacionCuenta.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/InactivacionCuenta/{Id}")]
        public async Task<ActionResult<Unit>> deleteInactivacionCuenta(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudInactivacionCuenta.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/EstadoCandidato/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getEstadoCandidato(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudEstadoCandidato.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/EstadoCandidato")]
        public async Task<ActionResult<ParametricoDTO>> nuevoEstadoCandidato([FromBody] Aplicacion.CrudEstadoCandidato.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/EstadoCandidato")]
        public async Task<ActionResult<ParametricoDTO>> editarEstadoCandidato([FromBody] Aplicacion.CrudEstadoCandidato.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/EstadoCandidato/{Id}")]
        public async Task<ActionResult<Unit>> deleteEstadoCandidato(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudEstadoCandidato.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/CampoCertificadoEstadoVacante/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCampoCertificadoEstadoVacante(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCampoCertificadoEstadoVacante.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/CampoCertificadoEstadoVacante")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCampoCertificadoEstadoVacante([FromBody] Aplicacion.CrudCampoCertificadoEstadoVacante.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/CampoCertificadoEstadoVacante")]
        public async Task<ActionResult<ParametricoDTO>> editarCampoCertificadoEstadoVacante([FromBody] Aplicacion.CrudCampoCertificadoEstadoVacante.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/CampoCertificadoEstadoVacante/{Id}")]
        public async Task<ActionResult<Unit>> deleteCampoCertificadoEstadoVacante(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCampoCertificadoEstadoVacante.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/AdministrarNaturaleza/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getAdministrarNaturaleza(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministrarNaturaleza.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/AdministrarNaturaleza")]
        public async Task<ActionResult<ParametricoDTO>> nuevoAdministrarNaturaleza([FromBody] Aplicacion.CrudAdministrarNaturaleza.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/AdministrarNaturaleza")]
        public async Task<ActionResult<ParametricoDTO>> editarAdministrarNaturaleza([FromBody] Aplicacion.CrudAdministrarNaturaleza.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/AdministrarNaturaleza/{Id}")]
        public async Task<ActionResult<Unit>> deleteAdministrarNaturaleza(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministrarNaturaleza.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/AdministrarTipo/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getAdministrarTipo(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministrarTipo.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/AdministrarTipo")]
        public async Task<ActionResult<ParametricoDTO>> nuevoAdministrarTipo([FromBody] Aplicacion.CrudAdministrarTipo.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/AdministrarTipo")]
        public async Task<ActionResult<ParametricoDTO>> editarAdministrarTipo([FromBody] Aplicacion.CrudAdministrarTipo.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/AdministrarTipo/{Id}")]
        public async Task<ActionResult<Unit>> deleteAdministrarTipo(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministrarTipo.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/AdministrarTamano/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getAdministrarTamano(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministrarTamano.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/AdministrarTamano")]
        public async Task<ActionResult<ParametricoDTO>> nuevoAdministrarTamano([FromBody] Aplicacion.CrudAdministrarTamano.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/AdministrarTamano")]
        public async Task<ActionResult<ParametricoDTO>> editarAdministrarTamano([FromBody] Aplicacion.CrudAdministrarTamano.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/AdministrarTamano/{Id}")]
        public async Task<ActionResult<Unit>> deleteAdministrarTamano(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministrarTamano.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/AdministraProgramaEmpleo/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getAdministraProgramaEmpleo(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministraProgramaEmpleo.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/AdministraProgramaEmpleo")]
        public async Task<ActionResult<ParametricoDTO>> nuevoAdministraProgramaEmpleo([FromBody] Aplicacion.CrudAdministraProgramaEmpleo.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/AdministraProgramaEmpleo")]
        public async Task<ActionResult<ParametricoDTO>> editarAdministraProgramaEmpleo([FromBody] Aplicacion.CrudAdministraProgramaEmpleo.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/AdministraProgramaEmpleo/{Id}")]
        public async Task<ActionResult<Unit>> deleteAdministraProgramaEmpleo(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministraProgramaEmpleo.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/AdministraGrupoEspeciales/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getAdministraGrupoEspeciales(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministraGrupoEspeciales.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/AdministraGrupoEspeciales")]
        public async Task<ActionResult<ParametricoDTO>> nuevoAdministraGrupoEspeciales([FromBody] Aplicacion.CrudAdministraGrupoEspeciales.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/AdministraGrupoEspeciales")]
        public async Task<ActionResult<ParametricoDTO>> editarAdministraGrupoEspeciales([FromBody] Aplicacion.CrudAdministraGrupoEspeciales.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/AdministraGrupoEspeciales/{Id}")]
        public async Task<ActionResult<Unit>> deleteAdministraGrupoEspeciales(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministraGrupoEspeciales.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/AdministraMotivoProcesoSeleccionCandidato/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getAdministraMotivoProcesoSeleccionCandidato(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministraMotivoProcesoSeleccionCandidato.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/AdministraMotivoProcesoSeleccionCandidato")]
        public async Task<ActionResult<ParametricoDTO>> nuevoAdministraMotivoProcesoSeleccionCandidato([FromBody] Aplicacion.CrudAdministraMotivoProcesoSeleccionCandidato.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/AdministraMotivoProcesoSeleccionCandidato")]
        public async Task<ActionResult<ParametricoDTO>> editarAdministraMotivoProcesoSeleccionCandidato([FromBody] Aplicacion.CrudAdministraMotivoProcesoSeleccionCandidato.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/AdministraMotivoProcesoSeleccionCandidato/{Id}")]
        public async Task<ActionResult<Unit>> deleteAdministraMotivoProcesoSeleccionCandidato(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministraMotivoProcesoSeleccionCandidato.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/AdministraPortafolioServicioOrientacionBuscador/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getAdministraPortafolioServicioOrientacionBuscador(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministraPortafolioServicioOrientacionBuscador.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/AdministraPortafolioServicioOrientacionBuscador")]
        public async Task<ActionResult<ParametricoDTO>> nuevoAdministraPortafolioServicioOrientacionBuscador([FromBody] Aplicacion.CrudAdministraPortafolioServicioOrientacionBuscador.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/AdministraPortafolioServicioOrientacionBuscador")]
        public async Task<ActionResult<ParametricoDTO>> editarAdministraPortafolioServicioOrientacionBuscador([FromBody] Aplicacion.CrudAdministraPortafolioServicioOrientacionBuscador.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/AdministraPortafolioServicioOrientacionBuscador/{Id}")]
        public async Task<ActionResult<Unit>> deleteAdministraPortafolioServicioOrientacionBuscador(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministraPortafolioServicioOrientacionBuscador.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/AdministraPortafolioServicioOrientacionEmpleador/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getAdministraPortafolioServicioOrientacionEmpleador(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministraPortafolioServicioOrientacionEmpleador.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/AdministraPortafolioServicioOrientacionEmpleador")]
        public async Task<ActionResult<ParametricoDTO>> nuevoAdministraPortafolioServicioOrientacionEmpleador([FromBody] Aplicacion.CrudAdministraPortafolioServicioOrientacionEmpleador.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/AdministraPortafolioServicioOrientacionEmpleador")]
        public async Task<ActionResult<ParametricoDTO>> editarAdministraPortafolioServicioOrientacionEmpleador([FromBody] Aplicacion.CrudAdministraPortafolioServicioOrientacionEmpleador.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/AdministraPortafolioServicioOrientacionEmpleador/{Id}")]
        public async Task<ActionResult<Unit>> deleteAdministraPortafolioServicioOrientacionEmpleador(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudAdministraPortafolioServicioOrientacionEmpleador.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/ParametrizaOfertaModalidad/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getParametrizaOfertaModalidad(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudParametrizaOfertaModalidad.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/ParametrizaOfertaModalidad")]
        public async Task<ActionResult<ParametricoDTO>> nuevoParametrizaOfertaModalidad([FromBody] Aplicacion.CrudParametrizaOfertaModalidad.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/ParametrizaOfertaModalidad")]
        public async Task<ActionResult<ParametricoDTO>> editarParametrizaOfertaModalidad([FromBody] Aplicacion.CrudParametrizaOfertaModalidad.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/ParametrizaOfertaModalidad/{Id}")]
        public async Task<ActionResult<Unit>> deleteParametrizaOfertaModalidad(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudParametrizaOfertaModalidad.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/ParametrizaOfertaModoAsistencia/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getParametrizaOfertaModoAsistencia(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudParametrizaOfertaModoAsistencia.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/ParametrizaOfertaModoAsistencia")]
        public async Task<ActionResult<ParametricoDTO>> nuevoParametrizaOfertaModoAsistencia([FromBody] Aplicacion.CrudParametrizaOfertaModoAsistencia.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/ParametrizaOfertaModoAsistencia")]
        public async Task<ActionResult<ParametricoDTO>> editarParametrizaOfertaModoAsistencia([FromBody] Aplicacion.CrudParametrizaOfertaModoAsistencia.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/ParametrizaOfertaModoAsistencia/{Id}")]
        public async Task<ActionResult<Unit>> deleteParametrizaOfertaModoAsistencia(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudParametrizaOfertaModoAsistencia.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/ParametrizaOfertaTipoOferta/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getParametrizaOfertaTipoOferta(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudParametrizaOfertaTipoOferta.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/ParametrizaOfertaTipoOferta")]
        public async Task<ActionResult<ParametricoDTO>> nuevoParametrizaOfertaTipoOferta([FromBody] Aplicacion.CrudParametrizaOfertaTipoOferta.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/ParametrizaOfertaTipoOferta")]
        public async Task<ActionResult<ParametricoDTO>> editarParametrizaOfertaTipoOferta([FromBody] Aplicacion.CrudParametrizaOfertaTipoOferta.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/ParametrizaOfertaTipoOferta/{Id}")]
        public async Task<ActionResult<Unit>> deleteParametrizaOfertaTipoOferta(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudParametrizaOfertaTipoOferta.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/SemanaCotizar/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getSemanaCotizar(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudSemanaCotizar.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/SemanaCotizar")]
        public async Task<ActionResult<ParametricoDTO>> nuevoSemanaCotizar([FromBody] Aplicacion.CrudSemanaCotizar.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/SemanaCotizar")]
        public async Task<ActionResult<ParametricoDTO>> editarSemanaCotizar([FromBody] Aplicacion.CrudSemanaCotizar.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/SemanaCotizar/{Id}")]
        public async Task<ActionResult<Unit>> deleteSemanaCotizar(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudSemanaCotizar.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/ControlSemanasCotizacion/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getControlSemanasCotizacion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudControlSemanaCotizacion.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/ControlSemanasCotizacion")]
        public async Task<ActionResult<ParametricoDTO>> nuevoControlSemanasCotizacion([FromBody] Aplicacion.CrudControlSemanaCotizacion.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/ControlSemanasCotizacion")]
        public async Task<ActionResult<ParametricoDTO>> editarControlSemanasCotizacion([FromBody] Aplicacion.CrudControlSemanaCotizacion.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/ControlSemanasCotizacion/{Id}")]
        public async Task<ActionResult<Unit>> deleteControlSemanasCotizacion(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudControlSemanaCotizacion.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/CatalogoEstadoCursos/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCatalogoEstadoCursos(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCatalogoEstadoCurso.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/CatalogoEstadoCursos")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCatalogoEstadoCursos([FromBody] Aplicacion.CrudCatalogoEstadoCurso.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/CatalogoEstadoCursos")]
        public async Task<ActionResult<ParametricoDTO>> editarCatalogoEstadoCursos([FromBody] Aplicacion.CrudCatalogoEstadoCurso.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/CatalogoEstadoCursos/{Id}")]
        public async Task<ActionResult<Unit>> deleteCatalogoEstadoCursos(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCatalogoEstadoCurso.Borrado.Ejecuta() { Id = Id });
        }


        [HttpGet("/[controller]/CriteriosVideos/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCriteriosVideos(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCriterioVideo.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/CriteriosVideos")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCriteriosVideos([FromBody] Aplicacion.CrudCriterioVideo.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/CriteriosVideos")]
        public async Task<ActionResult<ParametricoDTO>> editarCriteriosVideos([FromBody] Aplicacion.CrudCriterioVideo.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/CriteriosVideos/{Id}")]
        public async Task<ActionResult<Unit>> deleteCriteriosVideos(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCriterioVideo.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/IndicadorSatisfaccionDiligenciamiento/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCrudIndicadorSatisfaccionDiligenciamiento(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudIndicadorSatisfaccionDiligenciamiento.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/IndicadorSatisfaccionDiligenciamiento")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCrudIndicadorSatisfaccionDiligenciamiento([FromBody] Aplicacion.CrudIndicadorSatisfaccionDiligenciamiento.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/IndicadorSatisfaccionDiligenciamiento")]
        public async Task<ActionResult<ParametricoDTO>> editarCrudIndicadorSatisfaccionDiligenciamiento([FromBody] Aplicacion.CrudIndicadorSatisfaccionDiligenciamiento.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/IndicadorSatisfaccionDiligenciamiento/{Id}")]
        public async Task<ActionResult<Unit>> deleteCrudIndicadorSatisfaccionDiligenciamiento(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudIndicadorSatisfaccionDiligenciamiento.Borrado.Ejecuta() { Id = Id });
        }


        [HttpGet("/[controller]/IndicadorSatisfaccionManejoHerramienta/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCrudIndicadorSatisfaccionManejoHerramienta(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudIndicadorSatisfaccionManejoHerramienta.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/IndicadorSatisfaccionManejoHerramienta")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCrudIndicadorSatisfaccionManejoHerramienta([FromBody] Aplicacion.CrudIndicadorSatisfaccionManejoHerramienta.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/IndicadorSatisfaccionManejoHerramienta")]
        public async Task<ActionResult<ParametricoDTO>> editarCrudIndicadorSatisfaccionManejoHerramienta([FromBody] Aplicacion.CrudIndicadorSatisfaccionManejoHerramienta.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/IndicadorSatisfaccionManejoHerramienta/{Id}")]
        public async Task<ActionResult<Unit>> deleteCrudIndicadorSatisfaccionManejoHerramienta(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudIndicadorSatisfaccionManejoHerramienta.Borrado.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/RecoleccionIndicadorSatisfaccionDiligenciamiento")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCrudRecoleccionIndicSatisDiligenciamiento([FromBody] Aplicacion.CrudRecoleccionIndicSatisDiligenciamiento.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }


        [HttpPost("/[controller]/RecoleccionIndicadorSatisfaccionManejoHerramienta")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCrudRecoleccionIndicSatisHerramienta([FromBody] Aplicacion.CrudRecoleccionIndicSatisHerramienta.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpGet("/[controller]/ConfiguraPlantillaMensaje/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCrudConfiguraPlantillaMensaje(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudConfiguraPlantillaMensaje.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/ConfiguraPlantillaMensaje")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCrudConfiguraPlantillaMensaje([FromBody] Aplicacion.CrudConfiguraPlantillaMensaje.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/ConfiguraPlantillaMensaje")]
        public async Task<ActionResult<ParametricoDTO>> editarCrudConfiguraPlantillaMensaje([FromBody] Aplicacion.CrudConfiguraPlantillaMensaje.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/ConfiguraPlantillaMensaje/{Id}")]
        public async Task<ActionResult<Unit>> deleteCrudConfiguraPlantillaMensaje(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudConfiguraPlantillaMensaje.Borrado.Ejecuta() { Id = Id });
        }


        [HttpGet("/[controller]/NotificacionesAlarmas/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCrudNotificacionesAlarmas(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudNotificacionesAlarmas.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/NotificacionesAlarmas")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCrudNotificacionesAlarmas([FromBody] Aplicacion.CrudNotificacionesAlarmas.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/NotificacionesAlarmas")]
        public async Task<ActionResult<ParametricoDTO>> editarCrudNotificacionesAlarmas([FromBody] Aplicacion.CrudNotificacionesAlarmas.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/NotificacionesAlarmas/{Id}")]
        public async Task<ActionResult<Unit>> deleteCrudNotificacionesAlarmas(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudNotificacionesAlarmas.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/SalidaPlanMejoramiento/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCrudCampoSalidaPlanMejoramiento(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCampoSalidaPlanMejoramiento.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/SalidaPlanMejoramiento")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCrudCampoSalidaPlanMejoramiento([FromBody] Aplicacion.CrudCampoSalidaPlanMejoramiento.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/SalidaPlanMejoramiento")]
        public async Task<ActionResult<ParametricoDTO>> editarCrudCampoSalidaPlanMejoramiento([FromBody] Aplicacion.CrudCampoSalidaPlanMejoramiento.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/SalidaPlanMejoramiento/{Id}")]
        public async Task<ActionResult<Unit>> deleteCrudCampoSalidaPlanMejoramiento(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCampoSalidaPlanMejoramiento.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/CursoFortalecimiento/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCrudCrudCursoFortalecimiento(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCursoFortalecimiento.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/CursoFortalecimiento")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCrudCursoFortalecimiento([FromBody] Aplicacion.CrudCursoFortalecimiento.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/CursoFortalecimiento")]
        public async Task<ActionResult<ParametricoDTO>> editarCrudCursoFortalecimiento([FromBody] Aplicacion.CrudCursoFortalecimiento.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/CursoFortalecimiento/{Id}")]
        public async Task<ActionResult<Unit>> deleteCrudCursoFortalecimiento(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCursoFortalecimiento.Borrado.Ejecuta() { Id = Id });
        }


        [HttpGet("/[controller]/PaisInternacional/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCrudPaisInternacional(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudPaisInternacional.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/PaisInternacional")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCrudPaisInternacional([FromBody] Aplicacion.CrudPaisInternacional.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/PaisInternacional")]
        public async Task<ActionResult<ParametricoDTO>> editarCrudPaisInternacional([FromBody] Aplicacion.CrudPaisInternacional.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/PaisInternacional/{Id}")]
        public async Task<ActionResult<Unit>> deleteCrudPaisInternacional(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudPaisInternacional.Borrado.Ejecuta() { Id = Id });
        }


        [HttpGet("/[controller]/DepartamentoInternacional/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCrudDepartamentoInternacional(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudDepartamentoInternacional.Consulta.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/DepartamentoInternacional/Lista/{PaisInternacionalId}")]
        public async Task<ActionResult<List<ParametricoDTO>>> getListCrudDepartamentoInternacional(string PaisInternacionalId)
        {
            return await _mediator.Send(new Aplicacion.CrudDepartamentoInternacional.Lista.Ejecuta() { PaisInternacionalId = Convert.ToInt16(PaisInternacionalId) });
        }

        [HttpPost("/[controller]/DepartamentoInternacional")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCrudDepartamentoInternacional([FromBody] Aplicacion.CrudDepartamentoInternacional.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/DepartamentoInternacional")]
        public async Task<ActionResult<ParametricoDTO>> editarCrudDepartamentoInternacional([FromBody] Aplicacion.CrudDepartamentoInternacional.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/DepartamentoInternacional/{Id}")]
        public async Task<ActionResult<Unit>> deleteCrudDepartamentoInternacional(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudDepartamentoInternacional.Borrado.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/MunicipioInternacional/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCrudMunicipioInternacional(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudMunicipioInternacional.Consulta.Ejecuta() { Id = Id });
        }

        [HttpGet("/[controller]/MunicipioInternacional/Lista/{DepartamentoInternacionalId}")]
        public async Task<ActionResult<List<ParametricoDTO>>> getListCrudMunicipioInternacional(string DepartamentoInternacionalId)
        {
            return await _mediator.Send(new Aplicacion.CrudMunicipioInternacional.Lista.Ejecuta() { DepartamentoInternacionalId = Convert.ToInt16(DepartamentoInternacionalId) });
        }

        [HttpPost("/[controller]/MunicipioInternacional")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCrudMunicipioInternacional([FromBody] Aplicacion.CrudMunicipioInternacional.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/MunicipioInternacional")]
        public async Task<ActionResult<ParametricoDTO>> editarCrudMunicipioInternacional([FromBody] Aplicacion.CrudMunicipioInternacional.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/MunicipioInternacional/{Id}")]
        public async Task<ActionResult<Unit>> deleteCrudMunicipioInternacional(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudMunicipioInternacional.Borrado.Ejecuta() { Id = Id });
        }




        [HttpGet("/[controller]/validar")]
        public async Task<ActionResult<bool>> validarParametrico(Validar.ValidarParametrico data)
        {
            return await _mediator.Send(data);
        }

        [HttpGet("/[controller]/consulta")]
        public async Task<ActionResult<ConsultaDTO>> consultaParametrico(Consulta.ConsultaParametrico data)
        {
            return await _mediator.Send(data);

        }
        [HttpGet("/[controller]/filtro/{Tipo}")]
        public async Task<ActionResult<List<ParametricoDTO>>> filtroParametrico(Filtro.FiltroParametrico data)
        {
            string filter = Request.Query["$filter"];
            if (filter is not null)
            {
                var regex = @"([^""]*)""|'([^']*)'";
                data.BusquedaId = new List<String>();
                foreach (Match match in Regex.Matches(filter, regex))
                {
                    data.BusquedaId.Add(match.Value.Replace("'", ""));
                }
            }
            var respuesta = await _mediator.Send(data);
            Response.Headers.Add("X-Paginacion", respuesta.encabezado);
            return respuesta.parametricos;
        }

        [HttpGet("/[controller]/salario")]
        public async Task<ActionResult<SalarioMinimoDTO>> salarioMinimo(ConsultaMinimo.ConsultaMinimoParametrico data)
        {
            return await _mediator.Send(data);
        }

        [HttpGet("/[controller]/CamposCreacionEmpresaExtrangera/{Id}")]
        public async Task<ActionResult<ParametricoDTO>> getCrudCamposCreacionEmpresaExtrangera(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCamposCreacionEmpresaExtrangera.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("/[controller]/CamposCreacionEmpresaExtrangera")]
        public async Task<ActionResult<ParametricoDTO>> nuevoCamposCreacionEmpresaExtrangera([FromBody] Aplicacion.CrudCamposCreacionEmpresaExtrangera.Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/[controller]/CamposCreacionEmpresaExtrangera")]
        public async Task<ActionResult<ParametricoDTO>> editarCamposCreacionEmpresaExtrangera([FromBody] Aplicacion.CrudCamposCreacionEmpresaExtrangera.Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("/[controller]/CamposCreacionEmpresaExtrangera/{Id}")]
        public async Task<ActionResult<Unit>> deleteCrudCamposCreacionEmpresaExtrangera(string Id)
        {
            return await _mediator.Send(new Aplicacion.CrudCamposCreacionEmpresaExtrangera.Borrado.Ejecuta() { Id = Id });
        }
    }
}
