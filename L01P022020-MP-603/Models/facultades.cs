﻿using System.ComponentModel.DataAnnotations;

namespace L01P022020_MP_603.Models
{
    public class facultades
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
    }
}