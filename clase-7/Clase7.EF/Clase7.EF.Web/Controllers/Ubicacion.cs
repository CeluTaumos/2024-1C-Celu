using Clase7.EF.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase7.EF.Web.Controllers
{
    public class Ubicacion : Controller
    {
        [ApiController]
        [Route("[controller]")]
        public class UbicacionController : Controller
        {
            private readonly IUbicacionServicio _ubicacionServicio;

            public UbicacionController(IUbicacionServicio ubicacionServicio)
            {
                this._ubicacionServicio = ubicacionServicio;
            }

            [HttpGet]
            public IActionResult Get()
            {
                return Ok(_ubicacionServicio.ObtenerTodos());
            }

           
        }
    }
}

