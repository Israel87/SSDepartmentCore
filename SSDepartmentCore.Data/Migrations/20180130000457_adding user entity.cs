using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SSDepartmentCore.Data.Migrations
{
    public partial class addinguserentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Visitors",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Visitors",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Visitors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Visitors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Visitors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Visitors");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Visitors",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Visitors",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
