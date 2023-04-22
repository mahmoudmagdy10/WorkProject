using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Work.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Reply : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fcd426-9877-4884-b98d-e0bc9e8a0b8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d2ff5b8-ae2f-49d3-ba76-f30740c80306");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdd74d2b-e7f1-4960-8174-4333641e0f7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dee6ddb2-0029-4a46-8ff5-7560cda1436b");

            migrationBuilder.CreateTable(
                name: "Reply",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reply", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reply_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reply_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Reply_PostId",
                table: "Reply",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Reply_UserId",
                table: "Reply",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reply");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42fcd426-9877-4884-b98d-e0bc9e8a0b8d", "b0cf22a0-f606-4ff4-acf8-2c523dec2f41", "Graduate", "GRADUATE" },
                    { "9d2ff5b8-ae2f-49d3-ba76-f30740c80306", "3a20df2f-1b3e-460b-b7b0-9a340626e51a", "Investor", "INVESTOR" },
                    { "bdd74d2b-e7f1-4960-8174-4333641e0f7b", "82cccb44-7959-48d2-921a-07d723a5909d", "Student", "STUDENT" },
                    { "dee6ddb2-0029-4a46-8ff5-7560cda1436b", "2670a648-2f20-4c16-bd67-2581e55143bf", "Specialist", "SPECIALIST" }
                });
        }
    }
}
