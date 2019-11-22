using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetfirst.Migrations
{
    public partial class admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "184c0727-3f3c-4246-a68c-b44340d1161a", "5e455ec3-4a6c-4395-a57c-5750b484f144" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "988fbdb9-dfa5-457e-8ee1-5c53152b74eb", "c8891e9e-64b0-4e85-9996-09ddc2754f3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d715c96e-97b8-48ca-9066-4fac7a1c887b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f85a1d70-d09c-4116-96e1-be44bdc2bb2a");
        }
    }
}
