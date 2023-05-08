using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Work.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EditProject2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f39ee59-21b0-4675-b79b-9abf29b604fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a8ebd6c-0bef-4a21-873a-027ec6e87b1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebbafa22-e944-4afe-a98b-20631a47cd97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f32d39b0-ce04-45ab-b1bf-88516dbdf3d6");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Project");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f39ee59-21b0-4675-b79b-9abf29b604fa", "db4462a7-b0d3-4e79-a2ed-8a537ec25d73", "Specialist", "SPECIALIST" },
                    { "6a8ebd6c-0bef-4a21-873a-027ec6e87b1b", "3c64ade6-a318-41fc-bda4-41fbad0f0a62", "Student", "STUDENT" },
                    { "ebbafa22-e944-4afe-a98b-20631a47cd97", "40ebb8af-3b41-46ba-bfc6-0f8811e25737", "Investor", "INVESTOR" },
                    { "f32d39b0-ce04-45ab-b1bf-88516dbdf3d6", "e48af14d-bc84-4f10-8690-891c5dc72dd0", "Graduate", "GRADUATE" }
                });
        }
    }
}
