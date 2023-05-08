using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Work.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UserFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Language",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LanguageLevel",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "126bbde6-903f-4c48-b084-6e1c75635ccf", "e5e3aef8-2652-454f-a94c-2b81fd793c41", "Investor", "INVESTOR" },
                    { "1ce03f81-32ef-4eae-b2d8-64f9449a2d6f", "537f7712-a7e1-4656-a4ed-7804837f1697", "Student", "STUDENT" },
                    { "a18b3152-70bc-420b-acac-05046ce35e9f", "e23c8a71-5146-4104-bbe5-2e9eccfe7365", "Specialist", "SPECIALIST" },
                    { "cebe1651-f690-4fe2-a1f8-6b1a3ed0e71e", "9b017270-6d90-46f5-a27b-3df35562c518", "Graduate", "GRADUATE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126bbde6-903f-4c48-b084-6e1c75635ccf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ce03f81-32ef-4eae-b2d8-64f9449a2d6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18b3152-70bc-420b-acac-05046ce35e9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cebe1651-f690-4fe2-a1f8-6b1a3ed0e71e");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
    }
}
