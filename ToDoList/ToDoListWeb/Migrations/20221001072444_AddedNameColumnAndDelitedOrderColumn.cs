using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoListWeb.Migrations
{
    public partial class AddedNameColumnAndDelitedOrderColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Assignments");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Assignments");

            migrationBuilder.AddColumn<long>(
                name: "DisplayOrder",
                table: "Assignments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
