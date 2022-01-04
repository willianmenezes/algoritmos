namespace Algoritmos
{
    public class FuncoesRecursivas
    {
        public static void Executar()
        {
            var quantidade = MaiorValor(new int[] { 25, 1, 3, 10, 15 });
            Console.WriteLine(quantidade);
        }

        private static int Fatorial(int x)
        {
            if (x == 1) return 1;
            return x * Fatorial(x - 1);
        }

        private static void ContagemRegressiva(int valor)
        {
            Console.WriteLine(valor);

            if (valor <= 0)
                return;

            Thread.Sleep(1000);

            ContagemRegressiva(valor - 1);
        }

        private static int Soma(IEnumerable<int> numeros)
        {
            if (!numeros.Any()) return 0;

            return numeros.First() + Soma(numeros.Skip(1));
        }

        private static int QuantidadeDeItens<T>(IEnumerable<T> lista)
        {
            if (!lista.Any()) return 0;

            return 1 + QuantidadeDeItens(lista.Skip(1));
        }

        private static int MaiorValor(IEnumerable<int> lista)
        {
            var primeiro = lista.First();
            var proximo = lista.Skip(1).First();

            if (lista.Count() == 2)
                return primeiro > proximo ? primeiro : proximo;

            var maior = MaiorValor(lista.Skip(1));

            return maior > primeiro ? maior : primeiro;
        }
    }
}
