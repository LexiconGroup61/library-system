using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class BookDbSetAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Book_BooksId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_PublicationDate_PublishedOnId",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublicationDate",
                table: "PublicationDate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.RenameTable(
                name: "PublicationDate",
                newName: "PublicationDates");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_Book_PublishedOnId",
                table: "Books",
                newName: "IX_Books_PublishedOnId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublicationDates",
                table: "PublicationDates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Books_BooksId",
                table: "AuthorBook",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_PublicationDates_PublishedOnId",
                table: "Books",
                column: "PublishedOnId",
                principalTable: "PublicationDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Books_BooksId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_PublicationDates_PublishedOnId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublicationDates",
                table: "PublicationDates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "PublicationDates",
                newName: "PublicationDate");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameIndex(
                name: "IX_Books_PublishedOnId",
                table: "Book",
                newName: "IX_Book_PublishedOnId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublicationDate",
                table: "PublicationDate",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Book_BooksId",
                table: "AuthorBook",
                column: "BooksId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_PublicationDate_PublishedOnId",
                table: "Book",
                column: "PublishedOnId",
                principalTable: "PublicationDate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
