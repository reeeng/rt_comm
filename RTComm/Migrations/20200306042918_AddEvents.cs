using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RTComm.Migrations
{
    public partial class AddEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventID",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobId = table.Column<int>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Author = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Event_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_EventID",
                table: "Comments",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_Event_JobId",
                table: "Event",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Event_EventID",
                table: "Comments",
                column: "EventID",
                principalTable: "Event",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Event_EventID",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Comments_EventID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "EventID",
                table: "Comments");
        }
    }
}
