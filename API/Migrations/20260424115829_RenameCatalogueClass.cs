using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class RenameCatalogueClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Catalogue_CatalogueId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Catalogue");

            migrationBuilder.RenameColumn(
                name: "CatalogueId",
                table: "Posts",
                newName: "DirectoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_CatalogueId",
                table: "Posts",
                newName: "IX_Posts_DirectoryId");

            migrationBuilder.CreateTable(
                name: "Directory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directory", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Directory_DirectoryId",
                table: "Posts",
                column: "DirectoryId",
                principalTable: "Directory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Directory_DirectoryId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Directory");

            migrationBuilder.RenameColumn(
                name: "DirectoryId",
                table: "Posts",
                newName: "CatalogueId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_DirectoryId",
                table: "Posts",
                newName: "IX_Posts_CatalogueId");

            migrationBuilder.CreateTable(
                name: "Catalogue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogue", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Catalogue_CatalogueId",
                table: "Posts",
                column: "CatalogueId",
                principalTable: "Catalogue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
