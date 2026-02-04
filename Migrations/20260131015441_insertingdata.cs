using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace code_first_approch.Migrations
{
    /// <inheritdoc />
    public partial class insertingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Registers",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "Name", "Password", "PhoneNumber", "gender" },
                values: new object[,]
                {
                    { 1, "India", new DateTime(2026, 1, 31, 7, 24, 41, 557, DateTimeKind.Local).AddTicks(671), "Admin@gmail.com", "Admin", "Admin@123", 1234567890L, "male" },
                    { 2, "India2", new DateTime(2026, 1, 31, 7, 24, 41, 557, DateTimeKind.Local).AddTicks(699), "Admin2@gmail.com", "Admi2n", "Admin2@123", 12234567890L, "male" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Registers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Registers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
