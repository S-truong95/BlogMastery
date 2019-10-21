using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogMastery.Migrations
{
    public partial class sorcerer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "Title" },
                values: new object[] { new DateTime(2019, 10, 18, 15, 25, 47, 853, DateTimeKind.Local), "Harry Potter And The Sorcerers Stone" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 10, 18, 15, 25, 47, 854, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "Title" },
                values: new object[] { new DateTime(2019, 10, 17, 18, 29, 40, 209, DateTimeKind.Local), "Harry Potter" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 10, 17, 18, 29, 40, 211, DateTimeKind.Local));
        }
    }
}
