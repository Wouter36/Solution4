using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spelers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rugnummer = table.Column<int>(nullable: false),
                    Naam = table.Column<string>(nullable: true),
                    TransferWaarde = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spelers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Stamnummer = table.Column<int>(nullable: false),
                    TrainerNaam = table.Column<string>(nullable: true),
                    Naam = table.Column<string>(nullable: true),
                    Bijnaam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Stamnummer);
                });

            migrationBuilder.CreateTable(
                name: "Transfers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    spelerId = table.Column<int>(nullable: true),
                    OudTeamStamnummer = table.Column<int>(nullable: true),
                    NieuwTeamStamnummer = table.Column<int>(nullable: true),
                    Prijs = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transfers_Teams_NieuwTeamStamnummer",
                        column: x => x.NieuwTeamStamnummer,
                        principalTable: "Teams",
                        principalColumn: "Stamnummer",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transfers_Teams_OudTeamStamnummer",
                        column: x => x.OudTeamStamnummer,
                        principalTable: "Teams",
                        principalColumn: "Stamnummer",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transfers_Spelers_spelerId",
                        column: x => x.spelerId,
                        principalTable: "Spelers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_NieuwTeamStamnummer",
                table: "Transfers",
                column: "NieuwTeamStamnummer");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_OudTeamStamnummer",
                table: "Transfers",
                column: "OudTeamStamnummer");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_spelerId",
                table: "Transfers",
                column: "spelerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transfers");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Spelers");
        }
    }
}
