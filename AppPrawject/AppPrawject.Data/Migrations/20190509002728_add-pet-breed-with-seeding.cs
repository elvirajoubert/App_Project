using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPrawject.Data.Migrations
{
    public partial class addpetbreedwithseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 2, "Chihuahua" },
                    { 3, "Poodle" },
                    { 4, "Beagle" },
                    { 5, "Mixed Breed" },
                    { 6, "Boston Terrier" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetBreeds");
        }
    }
}
