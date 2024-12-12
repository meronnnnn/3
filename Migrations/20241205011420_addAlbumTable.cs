using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TuneTracks.Migrations
{
    /// <inheritdoc />
    public partial class addAlbumTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_ArtistID",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_AlbumID",
                table: "Songs");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Artists_ArtistID",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "ArtistID",
                table: "Songs",
                newName: "ArtistId");

            migrationBuilder.RenameColumn(
                name: "AlbumID",
                table: "Songs",
                newName: "AlbumId");

            migrationBuilder.RenameColumn(
                name: "SongID",
                table: "Songs",
                newName: "SongId");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_ArtistID",
                table: "Songs",
                newName: "IX_Songs_ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_AlbumID",
                table: "Songs",
                newName: "IX_Songs_AlbumId");

            migrationBuilder.RenameColumn(
                name: "ArtistID",
                table: "Artists",
                newName: "ArtistId");

            migrationBuilder.RenameColumn(
                name: "ArtistID",
                table: "Albums",
                newName: "ArtistId");

            migrationBuilder.RenameColumn(
                name: "AlbumID",
                table: "Albums",
                newName: "AlbumId");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_ArtistID",
                table: "Albums",
                newName: "IX_Albums_ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_ArtistId",
                table: "Albums",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Artists_ArtistId",
                table: "Songs",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_ArtistId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Artists_ArtistId",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Songs",
                newName: "ArtistID");

            migrationBuilder.RenameColumn(
                name: "AlbumId",
                table: "Songs",
                newName: "AlbumID");

            migrationBuilder.RenameColumn(
                name: "SongId",
                table: "Songs",
                newName: "SongID");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_ArtistId",
                table: "Songs",
                newName: "IX_Songs_ArtistID");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                newName: "IX_Songs_AlbumID");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Artists",
                newName: "ArtistID");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Albums",
                newName: "ArtistID");

            migrationBuilder.RenameColumn(
                name: "AlbumId",
                table: "Albums",
                newName: "AlbumID");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                newName: "IX_Albums_ArtistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_ArtistID",
                table: "Albums",
                column: "ArtistID",
                principalTable: "Artists",
                principalColumn: "ArtistID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Albums_AlbumID",
                table: "Songs",
                column: "AlbumID",
                principalTable: "Albums",
                principalColumn: "AlbumID");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Artists_ArtistID",
                table: "Songs",
                column: "ArtistID",
                principalTable: "Artists",
                principalColumn: "ArtistID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
