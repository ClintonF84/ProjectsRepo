using Microsoft.EntityFrameworkCore.Migrations;

namespace Resume.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResumeWorkHistories_Resume_ResumeId",
                table: "ResumeWorkHistories");

            migrationBuilder.DropColumn(
                name: "ReusmeId",
                table: "ResumeWorkHistories");

            migrationBuilder.AlterColumn<int>(
                name: "ResumeId",
                table: "ResumeWorkHistories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeWorkHistories_Resume_ResumeId",
                table: "ResumeWorkHistories",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResumeWorkHistories_Resume_ResumeId",
                table: "ResumeWorkHistories");

            migrationBuilder.AlterColumn<int>(
                name: "ResumeId",
                table: "ResumeWorkHistories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ReusmeId",
                table: "ResumeWorkHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeWorkHistories_Resume_ResumeId",
                table: "ResumeWorkHistories",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
