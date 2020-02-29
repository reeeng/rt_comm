using Microsoft.EntityFrameworkCore.Migrations;

namespace RTComm.Migrations
{
    public partial class applicationdbcontext3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Jobs_JobsId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_JobsId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "JobsId",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Jobs",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Jobs",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ConstructionCo",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "jobId",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_jobId",
                table: "Comments",
                column: "jobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Jobs_jobId",
                table: "Comments",
                column: "jobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Jobs_jobId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_jobId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "jobId",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Jobs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Jobs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ConstructionCo",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "JobsId",
                table: "Comments",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_JobsId",
                table: "Comments",
                column: "JobsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Jobs_JobsId",
                table: "Comments",
                column: "JobsId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
