using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication12.DAL.Migrations
{
    public partial class start9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exists");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exists",
                columns: table => new
                {
                    prod_Id = table.Column<int>(type: "int", nullable: false),
                    bran_Id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exists", x => new { x.prod_Id, x.bran_Id });
                    table.ForeignKey(
                        name: "FK_Exists_Branches_bran_Id",
                        column: x => x.bran_Id,
                        principalTable: "Branches",
                        principalColumn: "Branc_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exists_Products_prod_Id",
                        column: x => x.prod_Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exists_bran_Id",
                table: "Exists",
                column: "bran_Id");
        }
    }
}
