using Microsoft.EntityFrameworkCore.Migrations;

namespace CasinoOrt.Migrations
{
    public partial class addmigrationseguna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "informes",
                columns: table => new
                {
                    InformeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    montoInicial = table.Column<int>(nullable: false),
                    cantGanadas = table.Column<int>(nullable: false),
                    cantPerdidas = table.Column<int>(nullable: false),
                    ganancia = table.Column<int>(nullable: false),
                    montoPerdida = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_informes", x => x.InformeId);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreUsuario = table.Column<string>(nullable: false),
                    contraseña = table.Column<string>(nullable: false),
                    nombre = table.Column<string>(nullable: false),
                    InformeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_usuarios_informes_InformeId",
                        column: x => x.InformeId,
                        principalTable: "informes",
                        principalColumn: "InformeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_InformeId",
                table: "usuarios",
                column: "InformeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "informes");
        }
    }
}
