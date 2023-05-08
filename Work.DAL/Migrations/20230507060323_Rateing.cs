using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Work.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Rateing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Rate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Sender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rate_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "029bff78-5216-4df5-8f08-d6d83a1b92f1", "ff17709c-035f-46e1-942f-9ffcad3abd8e", "Graduate", "GRADUATE" },
                    { "356a612e-5511-43ef-a38b-0934b5a7764e", "34db68fa-ad73-42e0-8789-e04952fd6656", "Investor", "INVESTOR" },
                    { "82985b4d-ed89-4e32-8471-3e4e050eb0e6", "b1293227-9dda-4d81-9ca7-9ea0c0687453", "Student", "STUDENT" },
                    { "d7cb22bf-6a26-48d9-9c3f-99540ad4c337", "62f55c81-fffc-4818-a75e-c5524af728b3", "Specialist", "SPECIALIST" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rate_UserId",
                table: "Rate",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rate");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "029bff78-5216-4df5-8f08-d6d83a1b92f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "356a612e-5511-43ef-a38b-0934b5a7764e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82985b4d-ed89-4e32-8471-3e4e050eb0e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7cb22bf-6a26-48d9-9c3f-99540ad4c337");

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
    }
}
