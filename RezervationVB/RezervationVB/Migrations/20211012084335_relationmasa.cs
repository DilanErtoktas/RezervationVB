using Microsoft.EntityFrameworkCore.Migrations;

namespace RezervationVB.Migrations
{
    public partial class relationmasa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "masaid",
                table: "TableRezerve",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TableRezerve_masaid",
                table: "TableRezerve",
                column: "masaid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TableRezerve_TableMasa_masaid",
                table: "TableRezerve",
                column: "masaid",
                principalTable: "TableMasa",
                principalColumn: "masaid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableRezerve_TableMasa_masaid",
                table: "TableRezerve");

            migrationBuilder.DropIndex(
                name: "IX_TableRezerve_masaid",
                table: "TableRezerve");

            migrationBuilder.DropColumn(
                name: "masaid",
                table: "TableRezerve");
        }
    }
}
