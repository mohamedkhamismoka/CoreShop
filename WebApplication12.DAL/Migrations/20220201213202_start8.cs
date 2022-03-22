using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication12.DAL.Migrations
{
    public partial class start8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Orders",
                newName: "totalPrice");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "totalPrice",
                table: "Orders",
                newName: "quantity");
        }
    }
}
