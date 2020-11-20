using BPT.Test.CETM.BackEnd.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPT.Test.CETM.BackEnd.DataAccess
{
  public  class CursosContext: DbContext
    {
        public CursosContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AsignaturaEstudiante>().HasKey(ci => new { ci.IdAsignatura, ci.IdEstudiante });
        }
        public DbSet<Asignacion> Asignaciones { get; set; }

        public DbSet<AsignaturaEstudiante> AsignaturasEstudiantes { get; set; }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
