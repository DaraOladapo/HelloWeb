using Microsoft.EntityFrameworkCore.Migrations;

namespace CattyWebApp.Migrations
{
    public partial class VetsAndVisitsTypoFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VisitData",
                table: "Visits",
                newName: "VisitDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VisitDate",
                table: "Visits",
                newName: "VisitData");
        }
    }
}
