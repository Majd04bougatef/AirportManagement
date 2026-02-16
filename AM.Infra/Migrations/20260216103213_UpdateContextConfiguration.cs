using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infra.Migrations
{
    /// <inheritdoc />
    public partial class UpdateContextConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AirlineLogo",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AirlineLogo",
                table: "Flights");
        }
    }
}
