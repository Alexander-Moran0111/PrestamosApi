using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using prestamosApi.Models;

namespace prestamosApi.Controllers
{
    [ApiController]
    public class marcasControllers : ControllerBase
    {
        private readonly prestamosContext _contexto;
        public marcasControllers(prestamosContext miContexto) {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/maracas")]
        public IActionResult Get() {
            List<Models.marcas> marcasList = _contexto.marcas.ToList<marcas>();
            if(marcasList.Count>0){
                return Ok(marcasList);
            }
            return NotFound();
        }
    }
}