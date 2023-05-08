using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Work.DAL.Migrations
{
    /// <inheritdoc />
    public partial class editproject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "PaperName",
                table: "Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "60c26bb6-a2e3-4d84-b029-fad487b98682", "f350584a-b315-44dd-890b-946948d8c883", "Student", "STUDENT" },
                    { "a355779e-d164-4d56-b1d2-2d07d88dbe62", "31e49190-abba-47f3-ab6c-70dc2cf3a79c", "Investor", "INVESTOR" },
                    { "c36462bd-682e-4ae5-86e7-6807fe0f3088", "9e4a2e8b-aa18-4b9d-b9f9-5f45433a562b", "Graduate", "GRADUATE" },
                    { "e106e0c9-38ca-41b8-8b62-b5e800a57b3d", "371fd35b-a1d3-416d-ba5c-48def8a30cdf", "Specialist", "SPECIALIST" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60c26bb6-a2e3-4d84-b029-fad487b98682");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a355779e-d164-4d56-b1d2-2d07d88dbe62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c36462bd-682e-4ae5-86e7-6807fe0f3088");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e106e0c9-38ca-41b8-8b62-b5e800a57b3d");

            migrationBuilder.DropColumn(
                name: "PaperName",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "Project");

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
    }
}
