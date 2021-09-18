using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using prestamosApi.Models;

namespace  prestamosApi.Controllers
{
    [ApiController]
    public class equiposControllers : ControllerBase
    {
        private readonly prestamosContext _contexto;
        public equiposControllers(prestamosContext miContexto) {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/equipos")]
        public IActionResult Get(){
            List<Models.equipos> equiposList = _contexto.equipos.ToList<equipos>();
            if(equiposList.Count>0){
                return Ok(equiposList);
            }
            return NotFound();
        }
    }

}