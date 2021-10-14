using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RezervationVB.Migrations
{
    public partial class yenitabloo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TableMasa",
                columns: table => new
                {
                    masaid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    masaetiketi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    masadurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableMasa", x => x.masaid);
                });

            migrationBuilder.CreateTable(
                name: "TableRezerve",
                columns: table => new
                {
                    rezerveid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sicilno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kullaniciadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rezervebaslangic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    rezervebitis = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableRezerve", x => x.rezerveid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TableMasa");

            migrationBuilder.DropTable(
                name: "TableRezerve");
        }
    }
}
