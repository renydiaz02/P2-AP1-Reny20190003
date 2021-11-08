using Microsoft.EntityFrameworkCore.Migrations;

namespace P2_AP1_Reny20190003.Migrations
{
    public partial class Migracion_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposTareas",
                columns: table => new
                {
                    TipoTareaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposTareas", x => x.TipoTareaId);
                });

            migrationBuilder.InsertData(
                table: "TiposTareas",
                columns: new[] { "TipoTareaId", "Descripcion", "Tiempo" },
                values: new object[] { 1, "Análisis", 0 });

            migrationBuilder.InsertData(
                table: "TiposTareas",
                columns: new[] { "TipoTareaId", "Descripcion", "Tiempo" },
                values: new object[] { 2, "Diseño", 0 });

            migrationBuilder.InsertData(
                table: "TiposTareas",
                columns: new[] { "TipoTareaId", "Descripcion", "Tiempo" },
                values: new object[] { 3, "Programación", 0 });

            migrationBuilder.InsertData(
                table: "TiposTareas",
                columns: new[] { "TipoTareaId", "Descripcion", "Tiempo" },
                values: new object[] { 4, "Prueba", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TiposTareas");
        }
    }
}
