using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb3_API.Migrations
{
    public partial class nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_Interests_InterestId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Persons_PersonId",
                table: "Links");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Links",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InterestId",
                table: "Links",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Interests_InterestId",
                table: "Links",
                column: "InterestId",
                principalTable: "Interests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Persons_PersonId",
                table: "Links",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_Interests_InterestId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Persons_PersonId",
                table: "Links");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Links",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InterestId",
                table: "Links",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Interests_InterestId",
                table: "Links",
                column: "InterestId",
                principalTable: "Interests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Persons_PersonId",
                table: "Links",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
