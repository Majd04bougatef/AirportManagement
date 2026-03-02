using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infra.Migrations
{
    /// <inheritdoc />
    public partial class addTicketANDreservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Classe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationTicket",
                columns: table => new
                {
                    DateReservation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FkPassenger = table.Column<string>(type: "nvarchar(7)", nullable: false),
                    FkTicket = table.Column<int>(type: "int", nullable: false),
                    Prix = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationTicket", x => new { x.FkPassenger, x.FkTicket, x.DateReservation });
                    table.ForeignKey(
                        name: "FK_ReservationTicket_Passengers_FkPassenger",
                        column: x => x.FkPassenger,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationTicket_Ticket_FkTicket",
                        column: x => x.FkTicket,
                        principalTable: "Ticket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationTicket_FkTicket",
                table: "ReservationTicket",
                column: "FkTicket");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationTicket");

            migrationBuilder.DropTable(
                name: "Ticket");
        }
    }
}
