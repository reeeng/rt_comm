using Microsoft.EntityFrameworkCore.Migrations;

namespace RTComm.Migrations
{
    public partial class applicationdbcontext4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Jobs_jobId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "jobId",
                table: "Comments",
                newName: "JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_jobId",
                table: "Comments",
                newName: "IX_Comments_JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Jobs_JobId",
                table: "Comments",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Jobs_JobId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "Comments",
                newName: "jobId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_JobId",
                table: "Comments",
                newName: "IX_Comments_jobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Jobs_jobId",
                table: "Comments",
                column: "jobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
