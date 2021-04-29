using Microsoft.EntityFrameworkCore.Migrations;

namespace CattyWebApp.Migrations
{
    public partial class VetsAndVisitsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Cats_CatID",
                table: "Visit");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Vet_VetID",
                table: "Visit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Visit",
                table: "Visit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vet",
                table: "Vet");

            migrationBuilder.RenameTable(
                name: "Visit",
                newName: "Visits");

            migrationBuilder.RenameTable(
                name: "Vet",
                newName: "Vets");

            migrationBuilder.RenameIndex(
                name: "IX_Visit_VetID",
                table: "Visits",
                newName: "IX_Visits_VetID");

            migrationBuilder.RenameIndex(
                name: "IX_Visit_CatID",
                table: "Visits",
                newName: "IX_Visits_CatID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visits",
                table: "Visits",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vets",
                table: "Vets",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Cats_CatID",
                table: "Visits",
                column: "CatID",
                principalTable: "Cats",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Vets_VetID",
                table: "Visits",
                column: "VetID",
                principalTable: "Vets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Cats_CatID",
                table: "Visits");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Vets_VetID",
                table: "Visits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Visits",
                table: "Visits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vets",
                table: "Vets");

            migrationBuilder.RenameTable(
                name: "Visits",
                newName: "Visit");

            migrationBuilder.RenameTable(
                name: "Vets",
                newName: "Vet");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_VetID",
                table: "Visit",
                newName: "IX_Visit_VetID");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_CatID",
                table: "Visit",
                newName: "IX_Visit_CatID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visit",
                table: "Visit",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vet",
                table: "Vet",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Cats_CatID",
                table: "Visit",
                column: "CatID",
                principalTable: "Cats",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Vet_VetID",
                table: "Visit",
                column: "VetID",
                principalTable: "Vet",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
