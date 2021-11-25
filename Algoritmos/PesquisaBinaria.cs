﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class PesquisaBinaria
    {
        public static void Executar()
        {
            var arrayDeNumerosOrdenados = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numeroEscolhido = 10;

            var resultado = EncontrarElemento(arrayDeNumerosOrdenados, numeroEscolhido);

            if (resultado >= 0)
                Console.WriteLine($"O item esta na posicao {resultado}");
            else
                Console.WriteLine("Item nao encontrato");
        }

        private static int EncontrarElemento(int[] arrayDeNumerosOrdenados, int numeroEscolhido)
        {
            var menor = 0;
            var maior = arrayDeNumerosOrdenados.Length - 1;

            while (menor <= maior)
            {
                var meio = (menor + maior) / 2;
                var chute = arrayDeNumerosOrdenados[meio];

                if (chute == numeroEscolhido)
                    return meio;

                if (chute < numeroEscolhido)
                    menor = meio + 1;
                else
                    maior = meio - 1;
            }

            return -1;
        }
    }
}
