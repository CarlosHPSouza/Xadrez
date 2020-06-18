using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {           
                                   
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentoPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.excutaMovimento(origem, destino);
                }
                
                Console.ReadKey();
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
           
        }
    }
}
