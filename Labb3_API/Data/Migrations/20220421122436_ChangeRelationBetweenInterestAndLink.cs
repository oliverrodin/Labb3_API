using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb3_API.Migrations
{
    public partial class ChangeRelationBetweenInterestAndLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterestLink");

            migrationBuilder.AddColumn<int>(
                name: "InterestId",
                table: "Links",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Links_InterestId",
                table: "Links",
                column: "InterestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Interests_InterestId",
                table: "Links",
                column: "InterestId",
                principalTable: "Interests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_Interests_InterestId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_InterestId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "InterestId",
                table: "Links");

            migrationBuilder.CreateTable(
                name: "InterestLink",
                columns: table => new
                {
                    InterestsId = table.Column<int>(type: "int", nullable: false),
                    LinksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestLink", x => new { x.InterestsId, x.LinksId });
                    table.ForeignKey(
                        name: "FK_InterestLink_Interests_InterestsId",
                        column: x => x.InterestsId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterestLink_Links_LinksId",
                        column: x => x.LinksId,
                        principalTable: "Links",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InterestLink_LinksId",
                table: "InterestLink",
                column: "LinksId");
        }
    }
}
