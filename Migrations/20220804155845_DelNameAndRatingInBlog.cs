using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp4.Migrations
{
    public partial class DelNameAndRatingInBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "Blogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Blogs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "rating",
                table: "Blogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
