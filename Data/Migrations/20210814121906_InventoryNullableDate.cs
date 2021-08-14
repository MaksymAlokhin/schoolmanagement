using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sms.Data.Migrations
{
    public partial class InventoryNullableDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Decommissioned",
                table: "Inventories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DecommissionDate",
                table: "Inventories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DecommissionDate",
                table: "Inventories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Decommissioned",
                table: "Inventories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
