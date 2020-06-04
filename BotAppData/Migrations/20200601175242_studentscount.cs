using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BotAppData.Migrations
{
    public partial class studentscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentsCount",
                table: "BroadcastGroup",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ChatId = table.Column<long>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CapturedAt = table.Column<DateTime>(nullable: false),
                    IsPayed = table.Column<bool>(nullable: false),
                    SubscriptionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ChatId = table.Column<long>(nullable: false),
                    Begin = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    Product = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "StudentsCount",
                table: "BroadcastGroup");
        }
    }
}
