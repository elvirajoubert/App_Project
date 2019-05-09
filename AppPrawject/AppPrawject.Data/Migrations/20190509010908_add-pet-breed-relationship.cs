using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPrawject.Data.Migrations
{
    public partial class addpetbreedrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PetBreedId",
                table: "Pets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_PetBreedId",
                table: "Pets",
                column: "PetBreedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetBreeds_PetBreedId",
                table: "Pets",
                column: "PetBreedId",
                principalTable: "PetBreeds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetBreeds_PetBreedId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_PetBreedId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "PetBreedId",
                table: "Pets");
        }
    }
}
