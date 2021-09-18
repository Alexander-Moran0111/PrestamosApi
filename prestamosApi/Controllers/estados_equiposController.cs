using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using prestamosApi.Models;

namespace prestamosApi.Controllers
{
    [ApiController]
    public class estado_equipoController : ControllerBase
    {
        private readonly prestamosContext _contexto;
        public estado_equipoController(prestamosContext miContexto) {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/estado_equipo")]
        public IActionResult Get() {
            List<Models.estado_equipo> estado_EquiposList = _contexto.estado_Equipos.ToList<estado_equipo>();
            if(estado_EquiposList.Count>0){
                return Ok(estado_EquiposList);
            }
            return NotFound();
        }
    }
}
