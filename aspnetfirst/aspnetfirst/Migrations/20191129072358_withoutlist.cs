using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetfirst.Migrations
{
    public partial class withoutlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_UserId",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_UserId",
                table: "AspNetRoles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "184c0727-3f3c-4246-a68c-b44340d1161a", "5e455ec3-4a6c-4395-a57c-5750b484f144" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "988fbdb9-dfa5-457e-8ee1-5c53152b74eb", "c8891e9e-64b0-4e85-9996-09ddc2754f3a" });

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AspNetRoles");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5e5418db-a7eb-45ec-9f70-08b9a0c99cf0", "6dc27a4e-40e4-4ec6-95de-aade2c58f203" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ea5a6f35-b2e8-4b5a-a5d0-b1db406944a8", "364bf46b-eef0-4abd-a043-ce5d660a519c" });

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "UserId" },
                values: new object[] { "988fbdb9-dfa5-457e-8ee1-5c53152b74eb", "c8891e9e-64b0-4e85-9996-09ddc2754f3a", "admin", null, null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "UserId" },
                values: new object[] { "184c0727-3f3c-4246-a68c-b44340d1161a", "5e455ec3-4a6c-4395-a57c-5750b484f144", "user", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "79fe89ed-748c-44ef-9688-db78c13060fb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8862ee6d-5f22-40a9-b21d-f493498a6bf9");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_UserId",
                table: "AspNetRoles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_UserId",
                table: "AspNetRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
