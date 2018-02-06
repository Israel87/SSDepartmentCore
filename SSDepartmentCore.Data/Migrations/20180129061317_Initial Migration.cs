using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SSDepartmentCore.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Adventist = table.Column<bool>(nullable: false),
                    Church = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    DateVisited = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    NeedCounselling = table.Column<bool>(nullable: false),
                    PrayerRequest = table.Column<string>(nullable: true),
                    SeePastor = table.Column<bool>(nullable: false),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitors");
        }
    }
}
