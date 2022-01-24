using Algoritmos;

//PesquisaBinaria.Executar();

//FuncoesRecursivas.Executar();

var resultado = PesquisaEmLargura.EncontrarVendedor();

if (resultado != null)
    Console.WriteLine($"A pessoa {resultado.Nome} eh um vendedor");
else
    Console.WriteLine("Nao existem vendedores");