using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniMovieApi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "Titanic", 1997 },
                    { 2, "The Shawshank Redemption", 1994 },
                    { 3, "The Godfather", 1972 },
                    { 4, "The Dark Knight", 2008 },
                    { 5, "Pulp Fiction", 1994 },
                    { 6, "Forrest Gump", 1994 },
                    { 7, "Inception", 2010 },
                    { 8, "Fight Club", 1999 },
                    { 9, "The Matrix", 1999 },
                    { 10, "The Lord of the Rings: The Return of the King", 2003 },
                    { 11, "Gladiator", 2000 },
                    { 12, "The Lion King", 1994 },
                    { 13, "Schindler's List", 1993 },
                    { 14, "Goodfellas", 1990 },
                    { 15, "Star Wars: Episode IV - A New Hope", 1977 },
                    { 16, "Avengers: Endgame", 2019 },
                    { 17, "Saving Private Ryan", 1998 },
                    { 18, "The Silence of the Lambs", 1991 },
                    { 19, "Jurassic Park", 1993 },
                    { 20, "The Departed", 2006 },
                    { 21, "The Prestige", 2006 },
                    { 22, "Memento", 2000 },
                    { 23, "The Green Mile", 1999 },
                    { 24, "Braveheart", 1995 },
                    { 25, "American Beauty", 1999 },
                    { 26, "The Usual Suspects", 1995 },
                    { 27, "The Avengers", 2012 },
                    { 28, "The Wolf of Wall Street", 2013 },
                    { 29, "Django Unchained", 2012 },
                    { 30, "Interstellar", 2014 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
