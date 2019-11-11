using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPlaneControl.Repository.Migrations
{
    public partial class ReservatedSeats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservedSeats",
                table: "Airplanes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservedSeats",
                table: "Airplanes");
        }
    }
}
