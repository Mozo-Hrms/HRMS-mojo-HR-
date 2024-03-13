using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartH2RCore.Core.Migrations
{
    public partial class abcd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Area_code",
                schema: "Master",
                table: "Bank",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area_code",
                schema: "Master",
                table: "Bank");
        }
    }
}
