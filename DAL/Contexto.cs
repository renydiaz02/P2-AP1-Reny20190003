﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<Proyectos> Proyectos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@" Data Source = DATA\Project.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas
            {
                TipoTareaId = 1,
                DescripcionTipoTarea = "Análisis",
                TiempoAcumulado = 0
            });
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas
            {
                TipoTareaId = 2,
                DescripcionTipoTarea = "Diseño",
                TiempoAcumulado = 0
            });
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas
            {
                TipoTareaId = 3,
                DescripcionTipoTarea = "Programación",
                TiempoAcumulado = 0
            });
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas
            {
                TipoTareaId = 4,
                DescripcionTipoTarea = "Prueba",
                TiempoAcumulado = 0
            });
        }
    }
}
