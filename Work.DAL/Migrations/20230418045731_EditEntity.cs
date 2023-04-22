using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Work.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EditEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35bd9235-7728-4a3a-94be-bcb1fe378e64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccc51fb7-2a91-4056-ba9b-c53009381ceb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df506706-4357-48de-9174-047536372dd6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee303437-37e7-460a-a4ae-02a1b1565ca1");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Reply",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Post",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "UserEmail",
                table: "Reply");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Post");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "35bd9235-7728-4a3a-94be-bcb1fe378e64", "ce18c274-d703-4ae7-9d05-31970eb8a55d", "Graduate", "GRADUATE" },
                    { "ccc51fb7-2a91-4056-ba9b-c53009381ceb", "f7b86ed4-d52d-4542-9b88-304bb2f796b1", "Specialist", "SPECIALIST" },
                    { "df506706-4357-48de-9174-047536372dd6", "d0fab1e1-31a2-4e16-9157-00fbdcd2bf8d", "Investor", "INVESTOR" },
                    { "ee303437-37e7-460a-a4ae-02a1b1565ca1", "4c71a62a-5070-4c2a-9118-fd740024363e", "Student", "STUDENT" }
                });
        }
    }
}
