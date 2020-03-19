using Microsoft.EntityFrameworkCore.Migrations;

namespace RTComm.Migrations
{
    public partial class jobeventmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "event2",
                table: "Event",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "event2",
                table: "Event");
        }
    }
}
