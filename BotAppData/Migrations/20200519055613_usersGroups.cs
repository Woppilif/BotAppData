using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BotAppData.Migrations
{
    public partial class usersGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_BroadcastGroup_BroadcastGroupId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BroadcastGroupId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BroadcastGroupId",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "Group",
                table: "Users",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "BroadcastGroupId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_BroadcastGroupId",
                table: "Users",
                column: "BroadcastGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_BroadcastGroup_BroadcastGroupId",
                table: "Users",
                column: "BroadcastGroupId",
                principalTable: "BroadcastGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
