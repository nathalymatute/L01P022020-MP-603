using System;
using System.ComponentModel.DataAnnotations;

namespace L01P022020_MP_603.Models
{
    public class departamentos
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
    }
}