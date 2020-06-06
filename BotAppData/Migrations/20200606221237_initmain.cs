using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BotAppData.Migrations
{
    public partial class initmain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "bots2");

            migrationBuilder.CreateTable(
                name: "BroadcastGroup",
                schema: "bots2",
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
                name: "Patterns",
                schema: "bots2",
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
                name: "ProductItem",
                schema: "bots2",
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
                name: "Users",
                schema: "bots2",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ChatId = table.Column<long>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    GroupId = table.Column<Guid>(nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Users_BroadcastGroup_GroupId",
                        column: x => x.GroupId,
                        principalSchema: "bots2",
                        principalTable: "BroadcastGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                schema: "bots2",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    GroupId = table.Column<Guid>(nullable: true),
                    LessonAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    PatternId = table.Column<Guid>(nullable: true),
                    IsRepeats = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_BroadcastGroup_GroupId",
                        column: x => x.GroupId,
                        principalSchema: "bots2",
                        principalTable: "BroadcastGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lessons_Patterns_PatternId",
                        column: x => x.PatternId,
                        principalSchema: "bots2",
                        principalTable: "Patterns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatternMessages",
                schema: "bots2",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PatternId = table.Column<Guid>(nullable: true),
                    IsFirst = table.Column<bool>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    AtTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatternMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatternMessages_Patterns_PatternId",
                        column: x => x.PatternId,
                        principalSchema: "bots2",
                        principalTable: "Patterns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                schema: "bots2",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UsersId = table.Column<Guid>(nullable: true),
                    Begin = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    Product = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Users_UsersId",
                        column: x => x.UsersId,
                        principalSchema: "bots2",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LinkSpyers",
                schema: "bots2",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LessonId = table.Column<Guid>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UsersId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkSpyers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LinkSpyers_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalSchema: "bots2",
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LinkSpyers_Users_UsersId",
                        column: x => x.UsersId,
                        principalSchema: "bots2",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                schema: "bots2",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UsersId = table.Column<Guid>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CapturedAt = table.Column<DateTime>(nullable: false),
                    IsPayed = table.Column<bool>(nullable: false),
                    SubscriptionId = table.Column<Guid>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    PaymentId = table.Column<string>(nullable: true),
                    IsExtends = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalSchema: "bots2",
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_Users_UsersId",
                        column: x => x.UsersId,
                        principalSchema: "bots2",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_GroupId",
                schema: "bots2",
                table: "Lessons",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_PatternId",
                schema: "bots2",
                table: "Lessons",
                column: "PatternId");

            migrationBuilder.CreateIndex(
                name: "IX_LinkSpyers_LessonId",
                schema: "bots2",
                table: "LinkSpyers",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_LinkSpyers_UsersId",
                schema: "bots2",
                table: "LinkSpyers",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_PatternMessages_PatternId",
                schema: "bots2",
                table: "PatternMessages",
                column: "PatternId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_SubscriptionId",
                schema: "bots2",
                table: "Payment",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_UsersId",
                schema: "bots2",
                table: "Payment",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UsersId",
                schema: "bots2",
                table: "Subscriptions",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GroupId",
                schema: "bots2",
                table: "Users",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinkSpyers",
                schema: "bots2");

            migrationBuilder.DropTable(
                name: "PatternMessages",
                schema: "bots2");

            migrationBuilder.DropTable(
                name: "Payment",
                schema: "bots2");

            migrationBuilder.DropTable(
                name: "ProductItem",
                schema: "bots2");

            migrationBuilder.DropTable(
                name: "Lessons",
                schema: "bots2");

            migrationBuilder.DropTable(
                name: "Subscriptions",
                schema: "bots2");

            migrationBuilder.DropTable(
                name: "Patterns",
                schema: "bots2");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "bots2");

            migrationBuilder.DropTable(
                name: "BroadcastGroup",
                schema: "bots2");
        }
    }
}
