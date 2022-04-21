using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb3_API.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterestPerson");

            migrationBuilder.CreateTable(
                name: "PersonInterest",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    InterestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonInterest", x => new { x.PersonId, x.InterestId });
                    table.ForeignKey(
                        name: "FK_PersonInterest_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonInterest_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Love all kind of movies from Action to love comedies.", "Movies" },
                    { 2, "Get a rush every time i have the chance to explore our beautiful mother earth!", "Traveling" },
                    { 3, "The feeling of cooking food for families and friends is Fantastic!", "Cooking" },
                    { 4, "Read books i like therapy, it emphasize your soul!", "Books" },
                    { 5, "Its a great way of training and discover your surroundings.", "Gravel-biking" },
                    { 6, "Its a nice way to express your aesthetic mind.", "Photographing" },
                    { 7, "Everybody need a backpack and you cant have to many!", "Backpacks" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Lyckovägen 11", "oliver@oliver.com", "Oliver Rodin", 10999301 },
                    { 2, "Glada gatan 3", "amina@amina.com", "Amina Eliasson", 10765342 },
                    { 3, "Happy Street 13", "fredrik@fredrik.com", "Fredrik Nilsson", 10946371 },
                    { 4, "Tjärnvägen 1", "sofie@sofie.com", "Sofie Johansen", 10761301 }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "InterestId", "PersonId", "Url" },
                values: new object[,]
                {
                    { 1, 1, 4, "https://en.wikipedia.org/wiki/History_of_film" },
                    { 2, 1, 3, "https://www.imdb.com/" },
                    { 3, 2, 3, "https://www.tripadvisor.com/" },
                    { 4, 2, 3, "https://www.airbnb.com/" },
                    { 5, 3, 2, "https://www.thefork.com/" },
                    { 6, 3, 2, "https://12fwd.com/" },
                    { 7, 4, 4, "https://wordery.com/" },
                    { 8, 4, 3, "https://harappa.education/harappa-diaries/importance-of-reading/" },
                    { 9, 5, 1, "https://www.bikeradar.com/features/routes-and-rides/what-is-gravel-riding/" },
                    { 10, 5, 1, "https://www.canyon.com/sv-se/gravel-bikes/bike-packing/grizl/al/" },
                    { 11, 6, 2, "https://www.borrowlenses.com/blog/photography-tips/" },
                    { 12, 6, 2, "https://www.digitalcameraworld.com/tutorials/147-photography-techniques-tips-and-tricks-for-taking-pictures-of-anything" },
                    { 13, 7, 1, "https://www.carryology.com/" },
                    { 14, 7, 1, "https://rushfaster.com.au/" }
                });

            migrationBuilder.InsertData(
                table: "PersonInterest",
                columns: new[] { "InterestId", "PersonId" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 7, 1 },
                    { 3, 2 },
                    { 6, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 4, 3 },
                    { 1, 4 },
                    { 4, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonInterest_InterestId",
                table: "PersonInterest",
                column: "InterestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonInterest");

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.CreateTable(
                name: "InterestPerson",
                columns: table => new
                {
                    InterestsId = table.Column<int>(type: "int", nullable: false),
                    PersonsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestPerson", x => new { x.InterestsId, x.PersonsId });
                    table.ForeignKey(
                        name: "FK_InterestPerson_Interests_InterestsId",
                        column: x => x.InterestsId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterestPerson_Persons_PersonsId",
                        column: x => x.PersonsId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InterestPerson_PersonsId",
                table: "InterestPerson",
                column: "PersonsId");
        }
    }
}
