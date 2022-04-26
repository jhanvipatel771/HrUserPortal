using Microsoft.EntityFrameworkCore.Migrations;

namespace HrUserPortal.Migrations
{
    public partial class Doj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DOJ",
                table: "AspNetUsers",
                newName: "Doj");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Doj",
                table: "AspNetUsers",
                newName: "DOJ");
        }
    }
}
