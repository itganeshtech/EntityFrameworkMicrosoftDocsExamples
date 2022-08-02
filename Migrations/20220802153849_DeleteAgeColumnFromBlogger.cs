using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp4.Migrations
{
    public partial class DeleteAgeColumnFromBlogger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Bloggers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Bloggers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
