using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlaCollegeV1.Migrations
{
    public partial class Updateforeignkeyrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollegeID",
                table: "Colleges");

            migrationBuilder.RenameColumn(
                name: "CollegeID",
                table: "Students",
                newName: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CollegeId",
                table: "Students",
                column: "CollegeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Colleges_CollegeId",
                table: "Students",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Colleges_CollegeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CollegeId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "CollegeId",
                table: "Students",
                newName: "CollegeID");

            migrationBuilder.AddColumn<string>(
                name: "CollegeID",
                table: "Colleges",
                type: "text",
                nullable: true);
        }
    }
}
