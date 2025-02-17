using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission6_Thomas.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "movieCategory",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "movieDirector",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "movieName",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "Movies",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "lentTo",
                table: "Movies",
                newName: "LentTo");

            migrationBuilder.RenameColumn(
                name: "edited",
                table: "Movies",
                newName: "Edited");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "Movies",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "Movies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "movieYear",
                table: "Movies",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "movieRating",
                table: "Movies",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "categoryName",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<bool>(
                name: "Edited",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Movies",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<bool>(
                name: "CopiedToPlex",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Movies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CopiedToPlex",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "Movies",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "LentTo",
                table: "Movies",
                newName: "lentTo");

            migrationBuilder.RenameColumn(
                name: "Edited",
                table: "Movies",
                newName: "edited");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Movies",
                newName: "categoryId");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movies",
                newName: "MovieID");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Movies",
                newName: "movieYear");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movies",
                newName: "movieRating");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "categoryName");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "categoryId");

            migrationBuilder.AlterColumn<bool>(
                name: "edited",
                table: "Movies",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "categoryId",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "movieCategory",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "movieDirector",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "movieName",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
