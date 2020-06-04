using Microsoft.EntityFrameworkCore.Migrations;

namespace BotAppData.Migrations
{
    public partial class extendspayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsExtends",
                table: "Payment",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsExtends",
                table: "Payment");
        }
    }
}
