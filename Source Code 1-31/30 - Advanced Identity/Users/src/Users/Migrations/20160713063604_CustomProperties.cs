using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Users.Models;

namespace Users.Migrations
{
    public partial class CustomProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "City",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: Cities.None);

            migrationBuilder.AddColumn<int>(
                name: "Qualifications",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: QualificationLevels.None);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Qualifications",
                table: "AspNetUsers");
        }
    }
}
