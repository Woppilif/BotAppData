using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BotAppData.Migrations
{
    public partial class paymentstr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PaymentId",
                table: "Payment",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "PaymentId",
                table: "Payment",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
