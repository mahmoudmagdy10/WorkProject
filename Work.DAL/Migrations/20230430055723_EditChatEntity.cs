using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Work.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EditChatEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "307fbfc2-b20b-4e3b-9e02-fdb9df77e4ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61bea8bd-e4b8-4407-bf84-497ffc9e0806");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1356572-38d8-4137-ae50-2a7f69138063");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7cd6dba-9bf8-4fa1-836a-23da823c05ee");

            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "Chat",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11fb6500-9691-4e8f-90e7-1f551e38b698", "a5c25964-a5a2-4dfa-b74f-01d715e985a5", "Investor", "INVESTOR" },
                    { "7fba298e-d47d-4f99-b75f-ef0f955aec15", "97f7c387-0f33-4569-b187-1069386a4424", "Specialist", "SPECIALIST" },
                    { "9f4253bf-aec3-4570-bb5c-d15891d3da8b", "e11d5604-9f4a-4628-b4ea-72e930ee408a", "Graduate", "GRADUATE" },
                    { "bd8299bf-7efd-4820-b666-edc98a94484f", "6689b4cf-d204-4cfe-932a-8d7a53dd9cbe", "Student", "STUDENT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11fb6500-9691-4e8f-90e7-1f551e38b698");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fba298e-d47d-4f99-b75f-ef0f955aec15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f4253bf-aec3-4570-bb5c-d15891d3da8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd8299bf-7efd-4820-b666-edc98a94484f");

            migrationBuilder.DropColumn(
                name: "GroupName",
                table: "Chat");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "307fbfc2-b20b-4e3b-9e02-fdb9df77e4ad", "126446ef-9423-4cdf-b2c3-5df9e5f1a7bf", "Investor", "INVESTOR" },
                    { "61bea8bd-e4b8-4407-bf84-497ffc9e0806", "a451ea8f-2e83-49b2-a525-d062a92bb1b1", "Student", "STUDENT" },
                    { "c1356572-38d8-4137-ae50-2a7f69138063", "bf62da79-7003-4d77-b7d6-2767c1cb6d0f", "Graduate", "GRADUATE" },
                    { "e7cd6dba-9bf8-4fa1-836a-23da823c05ee", "026082a8-950b-4fe9-b989-50b144ccffc6", "Specialist", "SPECIALIST" }
                });
        }
    }
}
