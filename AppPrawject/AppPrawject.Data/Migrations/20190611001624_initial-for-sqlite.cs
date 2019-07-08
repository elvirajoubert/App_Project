using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AppPrawject.Data.Migrations
{
    public partial class initialforsqlite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetBreeds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetBreeds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    PetBreedId = table.Column<int>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pets_PetBreeds_PetBreedId",
                        column: x => x.PetBreedId,
                        principalTable: "PetBreeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    ProviderId = table.Column<string>(nullable: true),
                    ServiceTypeId1 = table.Column<int>(nullable: true),
                    ServiceTypeId = table.Column<string>(nullable: true),
                    PetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Services_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Services_AspNetUsers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Services_ServiceTypes_ServiceTypeId1",
                        column: x => x.ServiceTypeId1,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServicePets",
                columns: table => new
                {
                    PetId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePets", x => new { x.PetId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_ServicePets_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicePets_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b5a75374-d7a1-4924-ab70-e4a40e254864", "7784141e-72c2-40ce-99a8-fde56d486954", "Provider", "PROVIDER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2045c760-e6ca-4c8b-907b-1f6dbf301da2", "d005a790-24a3-483a-aec1-00ef53cb8830", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 39, "English Mastiff" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 23, "Pomeranian" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 24, "Pembroke Welsh Corgi" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 25, "Bernese Mountain Dog" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 26, "Basset Hound" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 27, "Greyhound" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 28, "American Staffordshire Terrier" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 29, "Jack Russell Terrier" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 40, "Pitbull" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 30, "Australian Cattle Dog" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 32, "Akita" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 33, "American Foxhound" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 34, "Vizsla" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 35, "Scottish Terrier" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 36, "Weimaraner" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 37, "Doberman" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 38, "Bullterrier" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 22, "Dachshund" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 31, "Alaskan Malamute" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 21, "Pointer" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 19, "Bichon Frise" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 2, "Chihuahua" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 3, "Poodle" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 4, "Beagle" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 5, "Mixed Breed" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 6, "Boston Terrier" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 7, "Collie" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 8, "French Bulldog" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 9, "German Shepherd" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 10, "Pug" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 11, "Bulldog" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 12, "Siberian Husky" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 13, "Great Dane" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 14, "Rottweiler" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 15, "Yorkshire Terrier" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 16, "Golden Retriever" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 17, "Boxer" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 18, "Australian Shepherd" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 20, "Chow Chow" });

            migrationBuilder.InsertData(
                table: "PetBreeds",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "Labrador" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_AppUserId",
                table: "Pets",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_PetBreedId",
                table: "Pets",
                column: "PetBreedId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePets_ServiceId",
                table: "ServicePets",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_CustomerId",
                table: "Services",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_PetId",
                table: "Services",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ProviderId",
                table: "Services",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceTypeId1",
                table: "Services",
                column: "ServiceTypeId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ServicePets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PetBreeds");
        }
    }
}
