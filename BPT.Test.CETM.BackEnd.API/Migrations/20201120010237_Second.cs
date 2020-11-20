using Microsoft.EntityFrameworkCore.Migrations;

namespace BPT.Test.CETM.BackEnd.API.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "AsignaturasEstudiantes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AsignaturasEstudiantes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
