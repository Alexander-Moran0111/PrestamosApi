using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using prestamosApi.Models;

namespace prestamosApi.Controllers
{
    [ApiController]
    public class tipo_equiposControllers : ControllerBase
    {
         private readonly prestamosContext _contexto;
        public tipo_equiposControllers(prestamosContext miContexto) {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/tipo_equipos")]
        public IActionResult Get(){
            List<Models.tipo_equipos> tipos_equiposListList = _contexto.tipo_Equipos.ToList<tipo_equipos>();
            if(tipos_equiposListList.Count>0){
                return Ok(tipos_equiposListList);
            }
            return NotFound();
        }
    }
}