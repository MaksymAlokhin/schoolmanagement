using Microsoft.EntityFrameworkCore.Migrations;

namespace sms.Data.Migrations
{
    public partial class Avatars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "Teachers",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "Students",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Students");
        }
    }
}
