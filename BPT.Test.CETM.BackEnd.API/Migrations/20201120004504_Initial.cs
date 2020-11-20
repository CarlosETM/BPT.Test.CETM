using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BPT.Test.CETM.BackEnd.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asignaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsignaturasEstudiantes",
                columns: table => new
                {
                    IdAsignatura = table.Column<int>(nullable: false),
                    IdEstudiante = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    AsignacionId = table.Column<int>(nullable: true),
                    EstudianteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignaturasEstudiantes", x => new { x.IdAsignatura, x.IdEstudiante });
                    table.ForeignKey(
                        name: "FK_AsignaturasEstudiantes_Asignaciones_AsignacionId",
                        column: x => x.AsignacionId,
                        principalTable: "Asignaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AsignaturasEstudiantes_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsignaturasEstudiantes_AsignacionId",
                table: "AsignaturasEstudiantes",
                column: "AsignacionId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignaturasEstudiantes_EstudianteId",
                table: "AsignaturasEstudiantes",
                column: "EstudianteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsignaturasEstudiantes");

            migrationBuilder.DropTable(
                name: "Asignaciones");

            migrationBuilder.DropTable(
                name: "Estudiantes");
        }
    }
}
