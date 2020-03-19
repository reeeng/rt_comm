using Microsoft.EntityFrameworkCore.Migrations;

namespace RTComm.Migrations
{
    public partial class jobeventmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Event_EventID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_EventID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "EventID",
                table: "Comments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventID",
                table: "Comments",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_EventID",
                table: "Comments",
                column: "EventID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Event_EventID",
                table: "Comments",
                column: "EventID",
                principalTable: "Event",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
