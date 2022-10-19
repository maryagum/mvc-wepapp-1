using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Personagens.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Altura = table.Column<double>(type: "REAL", nullable: false),
                    DataEstreia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsAlive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagem", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Personagem",
                columns: new[] { "Id", "Altura", "DataEstreia", "IsAlive", "Nome" },
                values: new object[] { 1, 1.6000000000000001, new DateTime(2018, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Entrapta" });

            migrationBuilder.InsertData(
                table: "Personagem",
                columns: new[] { "Id", "Altura", "DataEstreia", "IsAlive", "Nome" },
                values: new object[] { 2, 1.71, new DateTime(2018, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Rhaenyra Targaryen" });

            migrationBuilder.InsertData(
                table: "Personagem",
                columns: new[] { "Id", "Altura", "DataEstreia", "IsAlive", "Nome" },
                values: new object[] { 3, 1.6599999999999999, new DateTime(2018, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Alicent Hightower" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personagem");
        }
    }
}
