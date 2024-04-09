using System;
using System.ComponentModel.DataAnnotations;

namespace L01P022020_MP_603.Models
{
    public class alumnos
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        public int Dui { get; set; }

        public int Estado { get; set; }
    }
}