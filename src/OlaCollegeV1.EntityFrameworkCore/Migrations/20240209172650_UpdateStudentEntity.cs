using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlaCollegeV1.Migrations
{
    public partial class UpdateStudentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CollegeID",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollegeID",
                table: "Students");
        }
    }
}
