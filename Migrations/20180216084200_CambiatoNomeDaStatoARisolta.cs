using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace voxpopuli.Migrations
{
    public partial class CambiatoNomeDaStatoARisolta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stato",
                table: "Segnalazioni",
                newName: "Risolta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Risolta",
                table: "Segnalazioni",
                newName: "Stato");
        }
    }
}
