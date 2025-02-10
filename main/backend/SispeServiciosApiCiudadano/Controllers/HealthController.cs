using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServiciosApiCiudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthControllerC : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Content("{\"servicio\":\"Ciudadano\"}", "application/json");
        }
    }
}
