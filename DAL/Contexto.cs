using Microsoft.EntityFrameworkCore;
using P2_AP1_Reny20190003.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_Reny20190003.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<TiposTareas> TiposTareas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@" Data Source = DATA\Project.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas
            {
                TipoTareaId = 1,
                Descripcion = "Análisis",
                Tiempo = 0
            });
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas
            {
                TipoTareaId = 2,
                Descripcion = "Diseño",
                Tiempo = 0
            });
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas
            {
                TipoTareaId = 3,
                Descripcion = "Programación",
                Tiempo= 0
            });
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas
            {
                TipoTareaId = 4,
                Descripcion = "Prueba",
                Tiempo = 0
            });
        }
    }
}
