using Microsoft.EntityFrameworkCore.Migrations;

namespace ToysRUs2.Migrations
{
    public partial class Multiplicities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClothingSet_Colours_ColourId",
                table: "ClothingSet");

            migrationBuilder.DropForeignKey(
                name: "FK_ClothingSet_Sizes_SizeId",
                table: "ClothingSet");

            migrationBuilder.DropIndex(
                name: "IX_ClothingSet_ColourId",
                table: "ClothingSet");

            migrationBuilder.DropIndex(
                name: "IX_ClothingSet_SizeId",
                table: "ClothingSet");

            migrationBuilder.DropColumn(
                name: "ColourId",
                table: "ClothingSet");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "ClothingSet");

            migrationBuilder.AddColumn<int>(
                name: "ClothesId",
                table: "Sizes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClothesId",
                table: "Colours",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_ClothesId",
                table: "Sizes",
                column: "ClothesId");

            migrationBuilder.CreateIndex(
                name: "IX_Colours_ClothesId",
                table: "Colours",
                column: "ClothesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colours_ClothingSet_ClothesId",
                table: "Colours",
                column: "ClothesId",
                principalTable: "ClothingSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_ClothingSet_ClothesId",
                table: "Sizes",
                column: "ClothesId",
                principalTable: "ClothingSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colours_ClothingSet_ClothesId",
                table: "Colours");

            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_ClothingSet_ClothesId",
                table: "Sizes");

            migrationBuilder.DropIndex(
                name: "IX_Sizes_ClothesId",
                table: "Sizes");

            migrationBuilder.DropIndex(
                name: "IX_Colours_ClothesId",
                table: "Colours");

            migrationBuilder.DropColumn(
                name: "ClothesId",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "ClothesId",
                table: "Colours");

            migrationBuilder.AddColumn<int>(
                name: "ColourId",
                table: "ClothingSet",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "ClothingSet",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClothingSet_ColourId",
                table: "ClothingSet",
                column: "ColourId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingSet_SizeId",
                table: "ClothingSet",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClothingSet_Colours_ColourId",
                table: "ClothingSet",
                column: "ColourId",
                principalTable: "Colours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClothingSet_Sizes_SizeId",
                table: "ClothingSet",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
