﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelReservationDal.Migrations
{
    public partial class mig_add_guidelistimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GuideListImage",
                table: "Guides",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuideListImage",
                table: "Guides");
        }
    }
}
