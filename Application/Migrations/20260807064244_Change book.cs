using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class Changebook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalBook_Books_BookId",
                table: "PersonalBook");

            migrationBuilder.DropIndex(
                name: "IX_PersonalBook_BookId",
                table: "PersonalBook");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "PersonalBook");

            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "PersonalBook",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "PersonalBook",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "PersonalBook",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "PersonalBook",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Creator",
                table: "PersonalBook");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "PersonalBook");

            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "PersonalBook");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "PersonalBook");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "PersonalBook",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalBook_BookId",
                table: "PersonalBook",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalBook_Books_BookId",
                table: "PersonalBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
