namespace Algoritmos
{
    public class PesquisaBinaria
    {
        public static void Executar()
        {
            var arrayDeNumerosOrdenados = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numeroEscolhido = 5;

            var resultado = BuscaBinaria(arrayDeNumerosOrdenados, numeroEscolhido);

            if (resultado >= 0)
                Console.WriteLine($"O item esta na posicao {resultado}");
            else
                Console.WriteLine("Item nao encontrato");
        }

        // O log(n)
        private static int BuscaBinaria(int[] arrayDeNumerosOrdenados, int numeroEscolhido)
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
