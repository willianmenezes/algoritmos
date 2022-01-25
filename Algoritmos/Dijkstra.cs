namespace Algoritmos;

internal static class Dijkstra
{
    public static void Executar()
    {
        var grafo = new Dictionary<string, Dictionary<string, int>>()
            {
                {
                    "INICIO", new Dictionary<string, int>(){ { "A", 6 }, { "B", 2 } }
                },
                {
                    "A", new Dictionary<string, int>(){ { "FIM", 1 } }
                },
                {
                    "B", new Dictionary<string, int>(){ { "A", 3 }, { "FIM", 5 } }
                },
                {
                    "FIM", new Dictionary<string, int>()
                }
            };

        var custos = new Dictionary<string, int>()
            {
                {"A", 6 },
                {"B", 2 },
                {"FIM", int.MaxValue }
            };

        var pais = new Dictionary<string, string>()
            {
                {"A", "INICIO" },
                {"B", "INICIO" },
                {"FIM", string.Empty }
            };

        var procesados = new List<string>();
        var verticeCustoMaisBaixo = EncontrarVerticeComCustoMaisBaixo(procesados, custos);

        while (!string.IsNullOrWhiteSpace(verticeCustoMaisBaixo.Key))
        {
            var custo = verticeCustoMaisBaixo.Value;
            var vizinhos = grafo[verticeCustoMaisBaixo.Key];

            foreach (var vizinho in vizinhos)
            {
                var novoCusto = custo + vizinho.Value;

                if (custos[vizinho.Key] > novoCusto)
                {
                    custos[vizinho.Key] = novoCusto;
                    pais[vizinho.Key] = verticeCustoMaisBaixo.Key;
                }
            }

            procesados.Add(verticeCustoMaisBaixo.Key);
            verticeCustoMaisBaixo = EncontrarVerticeComCustoMaisBaixo(procesados, custos);
        }
    }

    public static KeyValuePair<string, int> EncontrarVerticeComCustoMaisBaixo(List<string> procesados, Dictionary<string, int> custos)
    {
        var custoMaisBaixo = int.MaxValue;
        var verticeCustoMaisBaixo = KeyValuePair.Create<string, int>(string.Empty, 0);

        foreach (var vertice in custos)
        {
            var custo = vertice.Value;

            if (custo < custoMaisBaixo && !procesados.Any(x => x == vertice.Key))
            {
                custoMaisBaixo = custo;
                verticeCustoMaisBaixo = vertice;
            }
        }

        return verticeCustoMaisBaixo;
    }
}
