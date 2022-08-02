using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp4.Migrations
{
    public partial class AddingRatingCloumnInBlogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "rating",
                table: "Blogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rating",
                table: "Blogs");
        }
    }
}
