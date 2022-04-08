using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBC.Migrations
{
    public partial class late : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registration_CustomerManager_CustomerNameId",
                table: "Registration");

            migrationBuilder.DropForeignKey(
                name: "FK_Registration_ProductManager_ProductNameId",
                table: "Registration");

            migrationBuilder.DropIndex(
                name: "IX_Registration_CustomerNameId",
                table: "Registration");

            migrationBuilder.DropIndex(
                name: "IX_Registration_ProductNameId",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "CustomerNameId",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "ProductNameId",
                table: "Registration");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Registration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                table: "Registration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "ProductCode",
                table: "Registration");

            migrationBuilder.AddColumn<int>(
                name: "CustomerNameId",
                table: "Registration",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductNameId",
                table: "Registration",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Registration_CustomerNameId",
                table: "Registration",
                column: "CustomerNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Registration_ProductNameId",
                table: "Registration",
                column: "ProductNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_CustomerManager_CustomerNameId",
                table: "Registration",
                column: "CustomerNameId",
                principalTable: "CustomerManager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_ProductManager_ProductNameId",
                table: "Registration",
                column: "ProductNameId",
                principalTable: "ProductManager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
