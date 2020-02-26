using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RTComm.Migrations
{
    public partial class ApplicationDbContext2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "JobAddress",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Client",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "JobAddress",
                table: "Jobs");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Client",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
