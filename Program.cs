using System;
using tabuleiro;
namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiroNovo = new Tabuleiro(8, 8);
           

            Tela.imprimirTabuleiro(tabuleiroNovo);

            Console.WriteLine(  "Deu certo");

            Console.ReadLine();

        }
    }
}
