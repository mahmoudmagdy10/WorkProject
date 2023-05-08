using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Work.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UserFeatures2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Rate",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "356a395e-7a20-4995-84fc-e67682197e4c", "150ed5be-1523-4c25-84a4-fb37f174aa90", "Specialist", "SPECIALIST" },
                    { "9becab90-9984-414a-8d1c-4b77b4242721", "081a9cd8-9eb1-486e-afc2-4aa62a1f2048", "Student", "STUDENT" },
                    { "cc2b6801-e1f6-40b6-b332-a027428053b7", "b41a3c31-9788-4b6c-98c5-a02ac3804d3f", "Investor", "INVESTOR" },
                    { "ec48b3eb-22c3-4cc1-8cb4-b420825bbac8", "150f22ba-8c82-411c-9640-a8269e7499ff", "Graduate", "GRADUATE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "356a395e-7a20-4995-84fc-e67682197e4c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9becab90-9984-414a-8d1c-4b77b4242721");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2b6801-e1f6-40b6-b332-a027428053b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec48b3eb-22c3-4cc1-8cb4-b420825bbac8");

            migrationBuilder.AlterColumn<int>(
                name: "Rate",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
