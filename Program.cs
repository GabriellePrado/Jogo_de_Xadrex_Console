using System;
using tabuleiro;
using PecasDoJogo;
namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 1));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 0));
                tab.colocarPeca(new Dama(tab, Cor.Preta), new Posicao(4, 4));

                Tela.imprimirTabuleiro(tab);

                Console.WriteLine("Deu certo");
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
