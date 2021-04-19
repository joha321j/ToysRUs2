using Microsoft.EntityFrameworkCore.Migrations;

namespace ToysRUs2.Migrations
{
    public partial class ClothesAndImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClothingSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    SexId = table.Column<int>(type: "INTEGER", nullable: true),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: true),
                    SizeId = table.Column<int>(type: "INTEGER", nullable: true),
                    ColourId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothingSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClothingSet_Colours_ColourId",
                        column: x => x.ColourId,
                        principalTable: "Colours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClothingSet_Sexes_SexId",
                        column: x => x.SexId,
                        principalTable: "Sexes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClothingSet_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClothingSet_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClothingImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClothingId = table.Column<int>(type: "INTEGER", nullable: false),
                    FileLocation = table.Column<string>(type: "TEXT", nullable: true),
                    ClothesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothingImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClothingImages_ClothingSet_ClothesId",
                        column: x => x.ClothesId,
                        principalTable: "ClothingSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClothingImages_ClothesId",
                table: "ClothingImages",
                column: "ClothesId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingSet_ColourId",
                table: "ClothingSet",
                column: "ColourId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingSet_SexId",
                table: "ClothingSet",
                column: "SexId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingSet_SizeId",
                table: "ClothingSet",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingSet_TypeId",
                table: "ClothingSet",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClothingImages");

            migrationBuilder.DropTable(
                name: "ClothingSet");
        }
    }
}
