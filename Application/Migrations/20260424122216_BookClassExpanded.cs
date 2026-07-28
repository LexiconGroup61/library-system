using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class BookClassExpanded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublishedOnId",
                table: "Book",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Book",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PublicationDate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Published = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicationDate", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublishedOnId",
                table: "Book",
                column: "PublishedOnId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_PublicationDate_PublishedOnId",
                table: "Book",
                column: "PublishedOnId",
                principalTable: "PublicationDate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_PublicationDate_PublishedOnId",
                table: "Book");

            migrationBuilder.DropTable(
                name: "PublicationDate");

            migrationBuilder.DropIndex(
                name: "IX_Book_PublishedOnId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "PublishedOnId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Book");
        }
    }
}
