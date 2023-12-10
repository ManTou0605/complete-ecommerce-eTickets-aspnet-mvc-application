using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class FixRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_Cinemald",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_Cinemald",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Cinemald",
                table: "Movies");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "Cinemald",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Cinemald",
                table: "Movies",
                column: "Cinemald",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_Cinemald",
                table: "Movies",
                column: "Cinemald",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
