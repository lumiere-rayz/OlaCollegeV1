using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlaCollegeV1.Migrations
{
    public partial class Updatecollege : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CollegeID",
                table: "Colleges",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollegeID",
                table: "Colleges");
        }
    }
}
