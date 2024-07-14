using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class AlbumEMusica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Musicas SET Album = 'evermore' WHERE Nome = 'no body, no crime'");
            migrationBuilder.Sql("UPDATE Musicas SET Album = '1989' WHERE Nome = 'Shake It Off'");
            migrationBuilder.Sql("UPDATE Musicas SET Album = 'Super' WHERE Nome = 'Sinais'");
            migrationBuilder.Sql("UPDATE Musicas SET Album = 'Lobos' WHERE Nome = 'Lobos'");
            migrationBuilder.Sql("UPDATE Musicas SET Album = 'folklore' WHERE Nome = 'cardigan'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Musicas");
        }
    }
}
