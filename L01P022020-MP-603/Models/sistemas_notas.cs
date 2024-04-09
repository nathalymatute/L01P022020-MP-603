using L01P022020_MP_603.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace L01P022020_MP_603.Models
{
    public class sistemas_notas : DbContext
    {
        public sistemas_notas (DbContextOptions<sistemas_notas> options) : base(options)
        {
        }

        public DbSet<facultades> Facultades { get; set; }
        public DbSet<materias> Materias { get; set; }
        public DbSet<departamentos> Departamentos { get; set; }
        public DbSet<alumnos> Alumnos { get; set; }
    }
}