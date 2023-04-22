using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Work.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34155f1c-b75c-40eb-8a45-4416e4d881b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74d764fa-4cf0-4ece-8641-fe231b8776ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d61705da-1356-49fd-b0d3-b4477517f90a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef9812c5-8c1a-49b7-8522-5388070719db");

            migrationBuilder.DropColumn(
                name: "RecieverId",
                table: "Chat");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Chat");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Reply",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Budget",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Post",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1917aebf-7724-4616-b573-a250db2019b3", "26242a39-7190-4393-8f89-e96423dbfce2", "Investor", "INVESTOR" },
                    { "4a93f6ed-c5e5-49c4-a89c-4ee8d050c2a9", "5b4f7b60-0714-4103-9dc9-b6dc3c3ad47d", "Specialist", "SPECIALIST" },
                    { "b6205dc3-29bf-4c4f-8637-81d4ecf81f58", "dce91aae-58f8-4827-b7b9-00888b1e046e", "Student", "STUDENT" },
                    { "e10ea5ea-2a8c-4ded-874f-a5443e67d963", "a24a348a-6f2d-4ada-9353-bcc4f11f912d", "Graduate", "GRADUATE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1917aebf-7724-4616-b573-a250db2019b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a93f6ed-c5e5-49c4-a89c-4ee8d050c2a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6205dc3-29bf-4c4f-8637-81d4ecf81f58");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e10ea5ea-2a8c-4ded-874f-a5443e67d963");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Reply");

            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Chat");

            migrationBuilder.AddColumn<string>(
                name: "RecieverId",
                table: "Chat",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                table: "Chat",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34155f1c-b75c-40eb-8a45-4416e4d881b2", "c91c0434-be13-481b-a5d5-8b8da5644505", "Graduate", "GRADUATE" },
                    { "74d764fa-4cf0-4ece-8641-fe231b8776ed", "cc721457-0f36-4fd0-8b07-a3acc2cc7b5d", "Specialist", "SPECIALIST" },
                    { "d61705da-1356-49fd-b0d3-b4477517f90a", "d7c4525a-8b1b-47c5-9ab3-bde281a2c975", "Student", "STUDENT" },
                    { "ef9812c5-8c1a-49b7-8522-5388070719db", "ed8eed36-458a-44d1-9eb3-e7effacc493b", "Investor", "INVESTOR" }
                });
        }
    }
}
