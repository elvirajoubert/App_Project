using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPrawject.Data.Migrations
{
    public partial class initialrun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2045c760-e6ca-4c8b-907b-1f6dbf301da2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5a75374-d7a1-4924-ab70-e4a40e254864");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7de4ddb-9c1f-464a-80d3-cd5d2ce1c51a", "db7b5ff3-0776-476a-8b8e-b181a1790209", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb319c7c-c142-4123-b788-0e1eb2ffb8fe", "0a3a7783-5fc4-4910-ab00-3537da259edb", "Provider", "PROVIDER" });

            migrationBuilder.UpdateData(
                table: "PetBreeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "Description",
                value: "Cat");

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 41, "Pitbull" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb319c7c-c142-4123-b788-0e1eb2ffb8fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7de4ddb-9c1f-464a-80d3-cd5d2ce1c51a");

            migrationBuilder.DeleteData(
                table: "PetBreeds",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2045c760-e6ca-4c8b-907b-1f6dbf301da2", "d005a790-24a3-483a-aec1-00ef53cb8830", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b5a75374-d7a1-4924-ab70-e4a40e254864", "7784141e-72c2-40ce-99a8-fde56d486954", "Provider", "PROVIDER" });

            migrationBuilder.UpdateData(
                table: "PetBreeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "Description",
                value: "Pitbull");
        }
    }
}
