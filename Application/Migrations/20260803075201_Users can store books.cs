using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class Userscanstorebooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
