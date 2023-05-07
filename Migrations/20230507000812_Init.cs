using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriTechPlus.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Composicoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ObservacaoGeral = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LoginUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoAtual = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GatewayUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Composicoes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Composicoes");
        }
    }
}
