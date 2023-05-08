using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Work.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UserPic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "PicName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "PicName",
                table: "AspNetUsers");

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
    }
}
