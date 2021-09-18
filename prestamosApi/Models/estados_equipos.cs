using System;
using System.ComponentModel.DataAnnotations;

namespace prestamosApi.Models
{
    public class estado_equipo
    {
        [Key]
        public int id_estados_equipos { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}

