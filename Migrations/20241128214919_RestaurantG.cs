using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion_de_restaurant.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategoriesId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CategoriesId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Articles",
                newName: "Prix");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Articles",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Articles",
                newName: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategorieId",
                table: "Articles",
                column: "CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_CategorieId",
                table: "Articles",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategorieId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CategorieId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "Prix",
                table: "Articles",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Articles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CategorieId",
                table: "Articles",
                newName: "CategoryId");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoriesId",
                table: "Articles",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_CategoriesId",
                table: "Articles",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
