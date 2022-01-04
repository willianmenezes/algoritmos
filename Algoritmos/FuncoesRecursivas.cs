namespace Algoritmos
{
    public class FuncoesRecursivas
    {
        public static void Executar()
        {
            var soma = Soma(new int[] { 1, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3 });
            Console.WriteLine(soma);
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

        private static int Soma(int[] numeros)
        {
            if (numeros.Length == 0) return 0;

            return numeros[0] + Soma(numeros.Skip(1).ToArray());
        }
    }
}
