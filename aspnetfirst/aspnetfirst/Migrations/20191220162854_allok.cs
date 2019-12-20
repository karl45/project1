using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetfirst.Migrations
{
    public partial class allok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f31398b-9aec-4e80-bd22-4e87a63916f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "942220bc-cf16-446a-8fff-499c37632e85");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "105765f0-88cb-42b6-a129-f49b5ca1f555", "8d28c1c7-2cfc-4693-900a-c44c652c97a3", "admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5be16200-5839-4ebc-8fa6-8e2df864c7d6", "7e092982-e457-469d-ab38-e90478f68579", "user", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "61524aa9-2ea5-49d5-923e-8a8daa14acf8", "b484ec93-36f7-4ec1-b250-193c5a5c95cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "91ccc84d-9e48-497b-a0c7-b5d40dc4eb09", "5d1c2bc7-4254-441c-98fb-d3e78b3e255f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "105765f0-88cb-42b6-a129-f49b5ca1f555");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5be16200-5839-4ebc-8fa6-8e2df864c7d6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "942220bc-cf16-446a-8fff-499c37632e85", "bd42e6fa-0bc1-4018-95eb-1900dabcc11e", "admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f31398b-9aec-4e80-bd22-4e87a63916f8", "35d6222f-6a1f-4da1-b42a-a27e9f562411", "user", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ba130cc-58ca-4d5d-92f8-e43c9326b8e5", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d56556f5-0f09-461a-9ffd-56ee6e4a3759", null });
        }
    }
}
