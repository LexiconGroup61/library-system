using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class Addusersavedbook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_LibraryUserId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_LibraryUserId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "LibraryUserId",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "PersonalBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    LibraryUserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalBook_AspNetUsers_LibraryUserId",
                        column: x => x.LibraryUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalBook_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalBook_BookId",
                table: "PersonalBook",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalBook_LibraryUserId",
                table: "PersonalBook",
                column: "LibraryUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalBook");

            migrationBuilder.AddColumn<string>(
                name: "LibraryUserId",
                table: "Books",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_LibraryUserId",
                table: "Books",
                column: "LibraryUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_LibraryUserId",
                table: "Books",
                column: "LibraryUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
