using Microsoft.EntityFrameworkCore.Migrations;

namespace HrUserPortal.Migrations
{
    public partial class Email : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "personalEmail",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "personalEmail",
                table: "AspNetUsers");
        }
    }
}
