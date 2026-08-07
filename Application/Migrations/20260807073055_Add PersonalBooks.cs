using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class AddPersonalBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalBook_AspNetUsers_LibraryUserId",
                table: "PersonalBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonalBook",
                table: "PersonalBook");

            migrationBuilder.RenameTable(
                name: "PersonalBook",
                newName: "PersonalBooks");

            migrationBuilder.RenameIndex(
                name: "IX_PersonalBook_LibraryUserId",
                table: "PersonalBooks",
                newName: "IX_PersonalBooks_LibraryUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonalBooks",
                table: "PersonalBooks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalBooks_AspNetUsers_LibraryUserId",
                table: "PersonalBooks",
                column: "LibraryUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalBooks_AspNetUsers_LibraryUserId",
                table: "PersonalBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonalBooks",
                table: "PersonalBooks");

            migrationBuilder.RenameTable(
                name: "PersonalBooks",
                newName: "PersonalBook");

            migrationBuilder.RenameIndex(
                name: "IX_PersonalBooks_LibraryUserId",
                table: "PersonalBook",
                newName: "IX_PersonalBook_LibraryUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonalBook",
                table: "PersonalBook",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalBook_AspNetUsers_LibraryUserId",
                table: "PersonalBook",
                column: "LibraryUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
