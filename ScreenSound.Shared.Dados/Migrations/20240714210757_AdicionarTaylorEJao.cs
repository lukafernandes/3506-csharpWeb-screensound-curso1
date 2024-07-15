using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTaylorEJao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Taylor Swift", "Taylor Alison Swift é uma cantora, compositora, diretora e roteirista americana. Suas composições narrativas, muitas vezes inspiradas pelas suas experiências pessoais, têm recebido ampla cobertura mediática e elogios de críticos.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Jão", "João Vitor Romania Balbino, mais conhecido como Jão, é um cantor, compositor e publicitário brasileiro. Ele começou sua carreira musical em 2016, postando covers de canções no aplicativo de compartilhamento de vídeos YouTube.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
