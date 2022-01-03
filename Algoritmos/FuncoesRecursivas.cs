namespace Algoritmos
{
    public class FuncoesRecursivas
    {
        public static void Executar()
        {
            var numeroParaSerCalculado = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"Fatorial de {numeroParaSerCalculado} eh:  {Fatorial(numeroParaSerCalculado)}");

            Console.WriteLine();
            Console.WriteLine("Iniciando a funcao de contagem regressiva.");

            ContagemRegressiva(10);
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
    }
}
