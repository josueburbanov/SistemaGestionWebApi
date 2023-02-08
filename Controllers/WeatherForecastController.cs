using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Modelos;

namespace SistemaGestionWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //Si queremos cambiar la ruta
        [HttpGet("rutaNueva")]
        public string ObtenerSaludo()
        {

            return "Hola Mundo desde API";
        }

        [HttpGet("/rutaNueva")]
        public string ObtenerSaludo2()
        {
            return "Hola Mundo desde API";
        }


        //Si queremos tomar un parametro de la ruta
        [HttpGet("{parametro}")]
        public string ObtenerSaludo(string parametro)
        {
            return "PARAMETRO "+parametro;
        }







    }
}