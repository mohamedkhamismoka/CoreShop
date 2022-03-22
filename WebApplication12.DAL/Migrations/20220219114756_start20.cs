using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication12.DAL.Migrations
{
    public partial class start20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_mail",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_phone",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "mail",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "mail",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_mail",
                table: "Customers",
                column: "mail",
                unique: true,
                filter: "[mail] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_phone",
                table: "Customers",
                column: "phone",
                unique: true,
                filter: "[phone] IS NOT NULL");
        }
    }
}
