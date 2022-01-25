namespace Algoritmos;

internal static class AlgoritmosGulosos
{
    public static void Executar()
    {
        var estadosAbranger = new HashSet<string> { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };
        var estacoes = new Dictionary<string, HashSet<string>>
        {
            { "um", new HashSet<string> { "id", "nv", "ut"} },
            { "dois", new HashSet<string> { "wa", "id", "mt"} },
            { "tres", new HashSet<string> { "or", "nv", "ca"} },
            { "quatro", new HashSet<string> { "nv", "ut"} },
            { "cinco", new HashSet<string> { "ca", "az"} },
        };

        var estacoesFinal = new HashSet<string>();

        while (estadosAbranger.Count() > 0)
        {
            var melhorEstacao = string.Empty;
            var estadosCobertos = new HashSet<string>();

            foreach (var estacao in estacoes)
            {
                var estadosCobertosPelaEstacaoAtual = estadosAbranger.Intersect(estacao.Value).ToHashSet();

                if (estadosCobertosPelaEstacaoAtual.Count() > estadosCobertos.Count())
                {
                    melhorEstacao = estacao.Key;
                    estadosCobertos = estadosCobertosPelaEstacaoAtual;
                }
            }

            estadosAbranger = estadosAbranger.Except(estadosCobertos).ToHashSet();
            estacoesFinal.Add(melhorEstacao);
        }

        foreach (var item in estacoesFinal)
            Console.WriteLine(item);
    }
}
