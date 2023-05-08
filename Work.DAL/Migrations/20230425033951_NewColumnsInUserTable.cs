using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Work.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NewColumnsInUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Job",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "LanguageLevel",
                table: "AspNetUsers",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "19ce20cb-e521-473c-a0b3-eccae039f2b5", "c4a7f932-a938-4335-a13a-f4b97a54942e", "Specialist", "SPECIALIST" },
                    { "41aee786-8ecd-426d-8d6e-035d75ee2f5c", "4eb3396f-f745-4920-9bee-c812c6a7235a", "Graduate", "GRADUATE" },
                    { "783f98fa-4ee0-4e00-bb99-34ab3415aa5b", "dfedade1-c3f7-48b7-b6ad-4b19cfcbc10c", "Student", "STUDENT" },
                    { "a20cc54d-47fe-446d-a973-a19d411f3418", "81ca17c9-462d-4bde-be9f-298c782f2379", "Investor", "INVESTOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19ce20cb-e521-473c-a0b3-eccae039f2b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41aee786-8ecd-426d-8d6e-035d75ee2f5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "783f98fa-4ee0-4e00-bb99-34ab3415aa5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a20cc54d-47fe-446d-a973-a19d411f3418");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Job",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LanguageLevel",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "AspNetUsers");

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
    }
}
