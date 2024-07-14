using ScreenSound.Banco;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus;

internal class MenuMostrarMusicaPorAlbum: Menu
{
    public override void Executar(DAL<Artista> artistaDAL)
    {
        base.Executar(artistaDAL);
        ExibirTituloDaOpcao("Mostrar musicas por album");
        Console.Write("Digite o album para consultar músicas:");
        string album = Console.ReadLine()!;
        var musicaDal = new DAL<Musica>(new ScreenSoundContext());
        var listaAlbum = musicaDal.ListarPor(a => a.Album == album);
        if (listaAlbum.Any())
        {
            Console.WriteLine($"\nMusicas do Album {album}:");
            foreach (var musica in listaAlbum)
            {
                musica.ExibirFichaTecnica();
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO album {album} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
