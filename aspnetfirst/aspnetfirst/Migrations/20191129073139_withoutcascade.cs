using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetfirst.Migrations
{
    public partial class withoutcascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5e5418db-a7eb-45ec-9f70-08b9a0c99cf0", "6dc27a4e-40e4-4ec6-95de-aade2c58f203" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ea5a6f35-b2e8-4b5a-a5d0-b1db406944a8", "364bf46b-eef0-4abd-a043-ce5d660a519c" });

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
                column: "ConcurrencyStamp",
                value: "1ba130cc-58ca-4d5d-92f8-e43c9326b8e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d56556f5-0f09-461a-9ffd-56ee6e4a3759");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0f31398b-9aec-4e80-bd22-4e87a63916f8", "35d6222f-6a1f-4da1-b42a-a27e9f562411" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "942220bc-cf16-446a-8fff-499c37632e85", "bd42e6fa-0bc1-4018-95eb-1900dabcc11e" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5e5418db-a7eb-45ec-9f70-08b9a0c99cf0", "6dc27a4e-40e4-4ec6-95de-aade2c58f203", "admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea5a6f35-b2e8-4b5a-a5d0-b1db406944a8", "364bf46b-eef0-4abd-a043-ce5d660a519c", "user", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "91b2bd4d-9363-483c-8961-c6947d2aa1bd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1d280c75-df8e-4875-a336-d8fc66a11af1");
        }
    }
}
