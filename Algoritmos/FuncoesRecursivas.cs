namespace Algoritmos
{
    public class FuncoesRecursivas
    {
        public static void Executar()
        {
            var numeroParaSerCalculado = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"Fatorial de {numeroParaSerCalculado} eh:  {Fatorial(numeroParaSerCalculado)}");
        }

        private static int Fatorial(int x)
        {
            if (x == 1) return 1;

            return x * Fatorial(x - 1);
        }
    }
}
