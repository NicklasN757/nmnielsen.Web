using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nmnielsen.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "EndDate", "Imagename", "Name", "ShortDescription", "StartDate" },
                values: new object[] { 1, "I marts 2022 bestemte jeg mig for at lave en hjemmeside, hvor jeg kunne dele min projecter og fortælle lidt om mig selv, dette er den hjemmeside du ser det her på. Formålet med projektet var bare som sagt at kunne vise hvad jeg har arbejdet med og for at kunne fortælle lidt om mig selv, men jeg lavede den også for at kunne få et sted jeg kunne bruge som et sandbox miljø til at øve og blive bedre til de ting jeg lære igennem tiden.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nmnielsen.dk_hjemmesiden", "nmnielsen.dk hjemmesiden", "Det her projekt er den side du er på nu.", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
