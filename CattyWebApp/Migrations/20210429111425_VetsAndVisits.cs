using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CattyWebApp.Migrations
{
    public partial class VetsAndVisits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Visit",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VisitData = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    VetID = table.Column<int>(type: "int", nullable: true),
                    CatID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Visit_Cats_CatID",
                        column: x => x.CatID,
                        principalTable: "Cats",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visit_Vet_VetID",
                        column: x => x.VetID,
                        principalTable: "Vet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visit_CatID",
                table: "Visit",
                column: "CatID");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_VetID",
                table: "Visit",
                column: "VetID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visit");

            migrationBuilder.DropTable(
                name: "Vet");
        }
    }
}
