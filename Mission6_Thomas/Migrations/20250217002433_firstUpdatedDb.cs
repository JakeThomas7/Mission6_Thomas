using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission6_Thomas.Migrations
{
    /// <inheritdoc />
    public partial class firstUpdatedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    movieName = table.Column<string>(type: "TEXT", nullable: false),
                    movieCategory = table.Column<string>(type: "TEXT", nullable: false),
                    movieYear = table.Column<int>(type: "INTEGER", nullable: false),
                    movieDirector = table.Column<string>(type: "TEXT", nullable: false),
                    movieRating = table.Column<string>(type: "TEXT", nullable: false),
                    notes = table.Column<string>(type: "TEXT", nullable: true),
                    lentTo = table.Column<string>(type: "TEXT", nullable: true),
                    edited = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
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
