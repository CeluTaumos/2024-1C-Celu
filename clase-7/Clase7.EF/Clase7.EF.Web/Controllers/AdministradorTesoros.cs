using Clase7.EF.Data.Entidades;
using Clase7.EF.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase7.EF.Web.Controllers
{
    public class AdministradorTesoros : Controller
    {
        [ApiController]
        [Route("[controller]")]
        public class TesorosController : ControllerBase
        {
            private ITesoroServicio _tesoroServicio;
           // private readonly IUbicacionServicio _ubicacionServicio;

            public TesorosController(ITesoroServicio tesoroServicio)
            {
                this._tesoroServicio = tesoroServicio;
                
            }


            [HttpGet]
            public List<Tesoro> Get()
            {
                return _tesoroServicio.ObtenerTodos();
            }



}
    }
}
