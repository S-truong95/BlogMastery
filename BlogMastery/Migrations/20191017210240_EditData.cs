using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogMastery.Migrations
{
    public partial class EditData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_TagId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Post",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Post",
                table: "Genres");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Posts",
                newName: "Reviewer");

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTag_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Horror" },
                    { 6, "Drama" },
                    { 7, "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "DateTime", "GenreId", "Reviewer" },
                values: new object[] { "A sorcerer lost his parents and is taken in by his horrible aunt. The scorcerer's name is Harry Potter and he starts his new life with many adventures as he attends Hogwarts School of Witchcraft and Wizardry, learns how to perform magic and comes face to face with his archenemy, Lord Voldemort.", new DateTime(2019, 10, 17, 17, 2, 40, 85, DateTimeKind.Local), 4, "Jk Rowling" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "DateTime", "GenreId", "Reviewer", "Title" },
                values: new object[] { "When Thor's evil brother, Loki, gains access to the unlimited power of the energy cube called the Tesseract, Nick Fury, director of S.H.I.E.L.D., initiates a superhero recruitment effort to defeat the unprecedented threat to Earth. Joining Fury's 'dream team' are Iron Man, Captain America, the Hulk, Thor, the Black Widow and Hawkeye.", new DateTime(2019, 10, 17, 17, 2, 40, 87, DateTimeKind.Local), 1, "Stan Lee", "Avengers" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Horror" },
                    { 6, "Drama" },
                    { 7, "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 2, 5 },
                    { 1, 6 },
                    { 2, 6 },
                    { 1, 7 },
                    { 2, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagId",
                table: "PostTag",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.RenameColumn(
                name: "Reviewer",
                table: "Posts",
                newName: "Author");

            migrationBuilder.AddColumn<string>(
                name: "Post",
                table: "Tags",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Post",
                table: "Genres",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Body", "DateTime", "GenreId", "TagId" },
                values: new object[] { "Jk", "sorcerer", new DateTime(2019, 10, 17, 12, 4, 17, 689, DateTimeKind.Local), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Body", "DateTime", "GenreId", "TagId", "Title" },
                values: new object[] { "Ryan Gosling", "Alzheimers", new DateTime(2019, 10, 17, 12, 4, 17, 691, DateTimeKind.Local), 2, 2, "Notebook" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Body", "DateTime", "GenreId", "TagId", "Title" },
                values: new object[,]
                {
                    { 3, "steven spielberg", "if or", new DateTime(2019, 10, 17, 12, 4, 17, 691, DateTimeKind.Local), 1, 1, "Matrix" },
                    { 4, "steven spielberg", "Optimus Prime", new DateTime(2019, 10, 17, 12, 4, 17, 691, DateTimeKind.Local), 1, 1, "Transformers" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TagId",
                table: "Posts",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
