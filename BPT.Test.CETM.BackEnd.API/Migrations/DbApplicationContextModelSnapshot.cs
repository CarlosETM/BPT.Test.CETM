﻿// <auto-generated />
using System;
using BPT.Test.CETM.BackEnd.API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BPT.Test.CETM.BackEnd.API.Migrations
{
    [DbContext(typeof(DbApplicationContext))]
    partial class DbApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BPT.Test.CETM.BackEnd.Dominio.Asignacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Asignaciones");
                });

            modelBuilder.Entity("BPT.Test.CETM.BackEnd.Dominio.AsignaturaEstudiante", b =>
                {
                    b.Property<int>("IdAsignatura")
                        .HasColumnType("int");

                    b.Property<int>("IdEstudiante")
                        .HasColumnType("int");

                    b.Property<int?>("AsignacionId")
                        .HasColumnType("int");

                    b.Property<int?>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("IdAsignatura", "IdEstudiante");

                    b.HasIndex("AsignacionId");

                    b.HasIndex("EstudianteId");

                    b.ToTable("AsignaturasEstudiantes");
                });

            modelBuilder.Entity("BPT.Test.CETM.BackEnd.Dominio.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("BPT.Test.CETM.BackEnd.Dominio.AsignaturaEstudiante", b =>
                {
                    b.HasOne("BPT.Test.CETM.BackEnd.Dominio.Asignacion", "Asignacion")
                        .WithMany()
                        .HasForeignKey("AsignacionId");

                    b.HasOne("BPT.Test.CETM.BackEnd.Dominio.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteId");
                });
#pragma warning restore 612, 618
        }
    }
}
