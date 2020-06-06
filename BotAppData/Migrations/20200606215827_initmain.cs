using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BotAppData.Migrations
{
    public partial class initmain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "bots");

            migrationBuilder.CreateTable(
                name: "BroadcastGroup",
                schema: "bots",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Creator = table.Column<Guid>(nullable: false),
                    StudentsCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BroadcastGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                schema: "bots",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Group = table.Column<Guid>(nullable: false),
                    LessonAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    PatternId = table.Column<Guid>(nullable: false),
                    IsRepeats = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinkSpyers",
                schema: "bots",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LessonId = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ChatId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkSpyers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatternMessages",
                schema: "bots",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PatternId = table.Column<Guid>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    AtTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatternMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patterns",
                schema: "bots",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patterns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                schema: "bots",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ChatId = table.Column<long>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CapturedAt = table.Column<DateTime>(nullable: false),
                    IsPayed = table.Column<bool>(nullable: false),
                    SubscriptionId = table.Column<Guid>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    PaymentId = table.Column<string>(nullable: true),
                    IsExtends = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductItem",
                schema: "bots",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Ages = table.Column<int[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                schema: "bots",
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

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "bots",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ChatId = table.Column<long>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Group = table.Column<Guid>(nullable: false),
                    Platform = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Registered = table.Column<bool>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false),
                    IsTeacher = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BroadcastGroup",
                schema: "bots");

            migrationBuilder.DropTable(
                name: "Lessons",
                schema: "bots");

            migrationBuilder.DropTable(
                name: "LinkSpyers",
                schema: "bots");

            migrationBuilder.DropTable(
                name: "PatternMessages",
                schema: "bots");

            migrationBuilder.DropTable(
                name: "Patterns",
                schema: "bots");

            migrationBuilder.DropTable(
                name: "Payment",
                schema: "bots");

            migrationBuilder.DropTable(
                name: "ProductItem",
                schema: "bots");

            migrationBuilder.DropTable(
                name: "Subscriptions",
                schema: "bots");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "bots");
        }
    }
}
