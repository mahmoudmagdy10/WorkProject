using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Work.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EditProject3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04bb4e97-c56c-47c4-b1b8-5570100ae10d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fc8d28f-1fb1-4ff6-a83d-54e0c64e2c91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d3ae1b3-3846-48ff-a14b-7ef506ff4b12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c19b8e6-dc0c-4ca5-b080-d5cb06f00b0d");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Request");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04bb4e97-c56c-47c4-b1b8-5570100ae10d", "55ec6d30-b662-4dbb-956d-631efa3db1ae", "Investor", "INVESTOR" },
                    { "4fc8d28f-1fb1-4ff6-a83d-54e0c64e2c91", "44b1dd47-0dad-45e6-9867-d310350c77b7", "Student", "STUDENT" },
                    { "5d3ae1b3-3846-48ff-a14b-7ef506ff4b12", "bc8f759b-579f-44db-908e-0ffd0aa62e15", "Specialist", "SPECIALIST" },
                    { "8c19b8e6-dc0c-4ca5-b080-d5cb06f00b0d", "533327c4-05ea-49d5-9afb-0cd978961aad", "Graduate", "GRADUATE" }
                });
        }
    }
}
