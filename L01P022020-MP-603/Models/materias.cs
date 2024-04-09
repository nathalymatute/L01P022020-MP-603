using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Drawing2D;

namespace L01P022020_MP_603.Models
{
    public class materias
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public int UnidadesValorativas { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }


    }
}

