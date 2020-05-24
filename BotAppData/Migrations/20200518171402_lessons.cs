using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BotAppData.Migrations
{
    public partial class lessons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_BroadcastGroup_GroupId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_GroupId",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Lessons");

            migrationBuilder.AddColumn<Guid>(
                name: "Group",
                table: "Lessons",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group",
                table: "Lessons");

            migrationBuilder.AddColumn<Guid>(
                name: "GroupId",
                table: "Lessons",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_GroupId",
                table: "Lessons",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_BroadcastGroup_GroupId",
                table: "Lessons",
                column: "GroupId",
                principalTable: "BroadcastGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
