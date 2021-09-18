using System;
using System.ComponentModel.DataAnnotations;

namespace prestamosApi.Models
{
    public class tipo_equipos
    {
        [Key]
        public int id_tipo_equipo { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}