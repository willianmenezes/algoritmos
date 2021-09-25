using System;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = PesquisaBinaria(new int[] { 1, 3, 5, 7, 9 }, 9);

            Console.WriteLine($"A posicao do item na lista eh: {resultado}");
        }

        static int? PesquisaBinaria(int[] lista, int itemDeBusca)
        {
            var menor = 0;
            var maior = lista.Length - 1;

            while (menor <= maior)
            {
                var meio = (menor + maior) / 2;
                var itemChute = lista[meio];

                if (itemChute == itemDeBusca)
                {
                    return meio;
                }

                if (itemChute > itemDeBusca)
                {
                    maior = meio - 1;
                }
                else
                {
                    menor = meio + 1;
                }

            }

            return null;
        }
    }
}
