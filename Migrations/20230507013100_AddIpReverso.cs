using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriTechPlus.Migrations
{
    /// <inheritdoc />
    public partial class AddIpReverso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IpExternoReverso",
                table: "Composicoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IpExternoReverso",
                table: "Composicoes");
        }
    }
}
