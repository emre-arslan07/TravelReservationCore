﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelReservationDal.Migrations
{
    public partial class mig_new_guid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuidID",
                table: "Destinations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuidID",
                table: "Destinations",
                type: "int",
                nullable: true);
        }
    }
}
