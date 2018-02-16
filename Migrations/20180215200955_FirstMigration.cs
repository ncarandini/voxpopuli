using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace voxpopuli.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Segnalazioni",
                columns: table => new
                {
                    SegnalazioneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataSegnalazione = table.Column<DateTime>(nullable: false),
                    Descrizione = table.Column<string>(nullable: false),
                    PresaInCarico = table.Column<bool>(nullable: false),
                    Proprietario = table.Column<string>(nullable: true),
                    Stato = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segnalazioni", x => x.SegnalazioneId);
                });

            migrationBuilder.CreateTable(
                name: "Suggerimenti",
                columns: table => new
                {
                    SuggerimentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Descrizione = table.Column<string>(nullable: false),
                    Titolo = table.Column<string>(nullable: false),
                    Voti = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggerimenti", x => x.SuggerimentoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Segnalazioni_Descrizione",
                table: "Segnalazioni",
                column: "Descrizione");

            migrationBuilder.CreateIndex(
                name: "IX_Suggerimenti_Data",
                table: "Suggerimenti",
                column: "Data");

            migrationBuilder.CreateIndex(
                name: "IX_Suggerimenti_Descrizione",
                table: "Suggerimenti",
                column: "Descrizione");

            migrationBuilder.CreateIndex(
                name: "IX_Suggerimenti_Titolo",
                table: "Suggerimenti",
                column: "Titolo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Segnalazioni");

            migrationBuilder.DropTable(
                name: "Suggerimenti");
        }
    }
}
