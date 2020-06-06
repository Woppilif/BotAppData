using Microsoft.EntityFrameworkCore.Migrations;

namespace BotAppData.Migrations
{
    public partial class isfirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "PatternMessages");

            migrationBuilder.AddColumn<bool>(
                name: "IsFirst",
                table: "PatternMessages",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFirst",
                table: "PatternMessages");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "PatternMessages",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
