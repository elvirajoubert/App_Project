using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPrawject.Data.Migrations
{
    public partial class petseedingandrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PetBreedId",
                table: "Pets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PetBreeds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetBreeds", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Labrador" },
                    { 23, "Pomeranian" },
                    { 24, "Pembroke Welsh Corgi" },
                    { 25, "Bernese Mountain Dog" },
                    { 26, "Basset Hound" },
                    { 27, "Greyhound" },
                    { 28, "American Staffordshire Terrier" },
                    { 29, "Jack Russell Terrier" },
                    { 22, "Dachshund" },
                    { 30, "Australian Cattle Dog" },
                    { 32, "Akita" },
                    { 33, "American Foxhound" },
                    { 34, "Vizsla" },
                    { 35, "Scottish Terrier" },
                    { 36, "Weimaraner" },
                    { 37, "Doberman" },
                    { 38, "Bullterrier" },
                    { 31, "Alaskan Malamute" },
                    { 21, "Pointer" },
                    { 20, "Chow Chow" },
                    { 19, "Bichon Frise" },
                    { 2, "Chihuahua" },
                    { 3, "Poodle" },
                    { 4, "Beagle" },
                    { 5, "Mixed Breed" },
                    { 6, "Boston Terrier" },
                    { 7, "Collie" },
                    { 8, "French Bulldog" },
                    { 9, "German Shepherd" },
                    { 10, "Pug" },
                    { 11, "Bulldog" },
                    { 12, "Siberian Husky" },
                    { 13, "Great Dane" },
                    { 14, "Rottweiler" },
                    { 15, "Yorkshire Terrier" },
                    { 16, "Golden Retriever" },
                    { 17, "Boxer" },
                    { 18, "Australian Shepherd" },
                    { 39, "English Mastiff" },
                    { 40, "Pitbull" }
                });

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

            migrationBuilder.DropTable(
                name: "PetBreeds");

            migrationBuilder.DropIndex(
                name: "IX_Pets_PetBreedId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "PetBreedId",
                table: "Pets");
        }
    }
}
