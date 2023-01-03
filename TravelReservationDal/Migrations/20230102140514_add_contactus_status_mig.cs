using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelReservationDal.Migrations
{
    public partial class add_contactus_status_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "ContactUses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ContactUses");
        }
    }
}
