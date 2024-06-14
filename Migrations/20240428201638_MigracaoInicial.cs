using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BUSAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ONIBUS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Linha = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    NomeLinha = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    PontoPartida = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    PontoFinal = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    TempoEspera = table.Column<int>(type: "int", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ONIBUS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_ONIBUS",
                columns: new[] { "Id", "Linha", "NomeLinha", "PontoFinal", "PontoPartida", "Situacao", "TempoEspera" },
                values: new object[,]
                {
                    { 1, "1234A", "Parque Luiz Fernando", "Av. Vitor Luz", "Parque Luiz Cardoso", 1, 5 },
                    { 2, "1345A", "Av. Professora Quitereia", "R. Sarjento Bruno", "Av. Professora Quiteria", 1, 15 },
                    { 3, "1456A", "Vila Guilherme", "Rua Soldado   Brad kynndy", "Vila Guilherme", 1, 25 },
                    { 4, "1567A", "AV. Marion", "Rua Professora Fatima", "Av. Marion", 1, 35 },
                    { 5, "1678A", "Av. Eduardo Kaue", " Rua Senior Bruno Leitao", "Av. Eduardo Kaue", 3, 45 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ONIBUS");
        }
    }
}
