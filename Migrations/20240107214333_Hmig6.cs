using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server_side.Migrations
{
    /// <inheritdoc />
    public partial class Hmig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Baskett",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Baskett_ProductId",
                table: "Baskett",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskett_productss_ProductId",
                table: "Baskett",
                column: "ProductId",
                principalTable: "productss",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskett_productss_ProductId",
                table: "Baskett");

            migrationBuilder.DropIndex(
                name: "IX_Baskett_ProductId",
                table: "Baskett");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Baskett");
        }
    }
}
