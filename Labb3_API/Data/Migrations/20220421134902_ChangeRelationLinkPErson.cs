using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb3_API.Migrations
{
    public partial class ChangeRelationLinkPErson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinkPerson");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Links",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Links_PersonId",
                table: "Links",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Persons_PersonId",
                table: "Links",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_Persons_PersonId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_PersonId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Links");

            migrationBuilder.CreateTable(
                name: "LinkPerson",
                columns: table => new
                {
                    LinksId = table.Column<int>(type: "int", nullable: false),
                    PersonsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkPerson", x => new { x.LinksId, x.PersonsId });
                    table.ForeignKey(
                        name: "FK_LinkPerson_Links_LinksId",
                        column: x => x.LinksId,
                        principalTable: "Links",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinkPerson_Persons_PersonsId",
                        column: x => x.PersonsId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LinkPerson_PersonsId",
                table: "LinkPerson",
                column: "PersonsId");
        }
    }
}
