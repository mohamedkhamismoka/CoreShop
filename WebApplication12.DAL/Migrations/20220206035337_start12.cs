using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication12.DAL.Migrations
{
    public partial class start12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_order_Orders_ord_id",
                table: "Product_order");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_order_Products_pro_id",
                table: "Product_order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product_order",
                table: "Product_order");

            migrationBuilder.RenameTable(
                name: "Product_order",
                newName: "product_Orders");

            migrationBuilder.RenameIndex(
                name: "IX_Product_order_pro_id",
                table: "product_Orders",
                newName: "IX_product_Orders_pro_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product_Orders",
                table: "product_Orders",
                columns: new[] { "ord_id", "pro_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_product_Orders_Orders_ord_id",
                table: "product_Orders",
                column: "ord_id",
                principalTable: "Orders",
                principalColumn: "orderr_num",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_Orders_Products_pro_id",
                table: "product_Orders",
                column: "pro_id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_Orders_Orders_ord_id",
                table: "product_Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_product_Orders_Products_pro_id",
                table: "product_Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product_Orders",
                table: "product_Orders");

            migrationBuilder.RenameTable(
                name: "product_Orders",
                newName: "Product_order");

            migrationBuilder.RenameIndex(
                name: "IX_product_Orders_pro_id",
                table: "Product_order",
                newName: "IX_Product_order_pro_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product_order",
                table: "Product_order",
                columns: new[] { "ord_id", "pro_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_order_Orders_ord_id",
                table: "Product_order",
                column: "ord_id",
                principalTable: "Orders",
                principalColumn: "orderr_num",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_order_Products_pro_id",
                table: "Product_order",
                column: "pro_id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
