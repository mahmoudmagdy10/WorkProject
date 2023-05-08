using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Work.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RequestEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33ed4d1c-e4da-482f-8e5d-185f2768d80e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d090a5a-40a2-4363-820d-7884aaad8a2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc0b57e8-8744-4c47-9101-495aa1aeefb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6a1d65d-f356-4b6b-a997-108184b3ff5e");

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Agree = table.Column<bool>(type: "bit", nullable: true),
                    SenderEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Request");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33ed4d1c-e4da-482f-8e5d-185f2768d80e", "533fa7b7-ca39-4a5c-9ef9-1c66dbbd785e", "Specialist", "SPECIALIST" },
                    { "3d090a5a-40a2-4363-820d-7884aaad8a2a", "9b9fd5f4-9e4c-4ac5-b60a-6c32663259c7", "Student", "STUDENT" },
                    { "cc0b57e8-8744-4c47-9101-495aa1aeefb1", "c7ea025b-f2a2-474d-a70e-ea5c7335221b", "Graduate", "GRADUATE" },
                    { "d6a1d65d-f356-4b6b-a997-108184b3ff5e", "79ee42d7-3681-4676-b0f8-ca01bae93a0e", "Investor", "INVESTOR" }
                });
        }
    }
}
