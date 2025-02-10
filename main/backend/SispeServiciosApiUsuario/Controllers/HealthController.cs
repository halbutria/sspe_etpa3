using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServiciosApiUsuario.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        // GET: api/<HealthController>
        [HttpGet]
        public ActionResult Get()
        {
            return Content("{\"servicio\":\"Usuario\"}", "application/json");
        }
    }
}
