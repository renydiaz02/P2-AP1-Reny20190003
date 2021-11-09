﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P2_AP1_Reny20190003.DAL;

namespace P2_AP1_Reny20190003.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("P2_AP1_Reny20190003.Entidades.Proyectos", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionProyecto")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("Total")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProyectoId");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("P2_AP1_Reny20190003.Entidades.ProyectosDetalles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Requerimiento")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tiempo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoTareaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoId");

                    b.HasIndex("TipoTareaId");

                    b.ToTable("ProyectosDetalles");
                });

            modelBuilder.Entity("P2_AP1_Reny20190003.Entidades.TiposTareas", b =>
                {
                    b.Property<int>("TipoTareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionTipoTarea")
                        .HasColumnType("TEXT");

                    b.Property<int>("TiempoAcumulado")
                        .HasColumnType("INTEGER");

                    b.HasKey("TipoTareaId");

                    b.ToTable("TiposTareas");

                    b.HasData(
                        new
                        {
                            TipoTareaId = 1,
                            DescripcionTipoTarea = "Análisis",
                            TiempoAcumulado = 0
                        },
                        new
                        {
                            TipoTareaId = 2,
                            DescripcionTipoTarea = "Diseño",
                            TiempoAcumulado = 0
                        },
                        new
                        {
                            TipoTareaId = 3,
                            DescripcionTipoTarea = "Programación",
                            TiempoAcumulado = 0
                        },
                        new
                        {
                            TipoTareaId = 4,
                            DescripcionTipoTarea = "Prueba",
                            TiempoAcumulado = 0
                        });
                });

            modelBuilder.Entity("P2_AP1_Reny20190003.Entidades.ProyectosDetalles", b =>
                {
                    b.HasOne("P2_AP1_Reny20190003.Entidades.Proyectos", "Proyecto")
                        .WithMany("Detalle")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P2_AP1_Reny20190003.Entidades.TiposTareas", "TiposTarea")
                        .WithMany()
                        .HasForeignKey("TipoTareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");

                    b.Navigation("TiposTarea");
                });

            modelBuilder.Entity("P2_AP1_Reny20190003.Entidades.Proyectos", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
