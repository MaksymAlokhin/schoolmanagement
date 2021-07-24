using Microsoft.EntityFrameworkCore.Migrations;

namespace sms.Data.Migrations
{
    public partial class LessonEnumToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "day",
                table: "Lessons",
                newName: "Day");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Day",
                table: "Lessons",
                newName: "day");
        }
    }
}
