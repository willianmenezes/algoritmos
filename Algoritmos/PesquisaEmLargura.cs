namespace Algoritmos;

internal static class PesquisaEmLargura
{
    public static Pessoa EncontrarVendedor()
    {
        var willian = new Pessoa("willian", false);
        var tamires = new Pessoa("tamires", false);
        var matheus = new Pessoa("matheus", false);
        var thiago = new Pessoa("thiago", false);
        var ismael = new Pessoa("ismael", false);
        var beth = new Pessoa("beth", false);
        var rosi = new Pessoa("rosi", false);
        var meire = new Pessoa("meire", false);

        willian.AdicionarVizinhos(tamires, matheus, thiago);
        tamires.AdicionarVizinhos(ismael, beth);
        matheus.AdicionarVizinhos(rosi);
        thiago.AdicionarVizinhos(rosi, meire);

        Queue<Pessoa> vizinhosMeus = new Queue<Pessoa>(willian.Vizinhos);
        var verificados = new List<Pessoa>();

        while (vizinhosMeus.Count > 0)
        {
            var primeiro = vizinhosMeus.Dequeue();

            if (!verificados.Any(x => x.Nome == primeiro.Nome) && primeiro.EhVendedor)
                return primeiro;
            else
            {
                foreach (var item in primeiro.Vizinhos)
                    vizinhosMeus.Enqueue(item);

                verificados.Add(primeiro);
            }
        }

        return null;
    }
}

public class Pessoa
{
    public Pessoa(string nome, bool ehVendedor)
    {
        Nome = nome;
        EhVendedor = ehVendedor;
        Vizinhos = new List<Pessoa>();
    }

    public void AdicionarVizinhos(params Pessoa[] pessoas)
    {
        for (int i = 0; i < pessoas.Length; i++)
            Vizinhos.Add(pessoas[i]);
    }

    public string Nome { get; set; }
    public bool EhVendedor { get; set; }
    public List<Pessoa> Vizinhos { get; set; }
}
