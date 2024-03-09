using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSample.Migrations
{
    public partial class BookTableWriterColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublisherName",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublisherName",
                table: "Books");
        }
    }
}
