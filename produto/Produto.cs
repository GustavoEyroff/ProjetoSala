public class Produto
{

    public string Nome { get; set; }
    public string TipoProduto { get; set; }
    public string Descricao { get; set; }
    public double Preco { get; set; }
    public void Popular()
    {
        Console.WriteLine("Digite o nome do produto");
        Nome = Console.ReadLine();

        Console.WriteLine("Digite o Tipo do produto");
        Descricao = Console.ReadLine();

        Console.WriteLine("Digite a descrição do produto");
        TipoProduto = Console.ReadLine();

        Console.WriteLine("Digite o valor");
        Preco = Convert.ToInt32(Console.ReadLine());
    }


    public void Listar()
    {
        Console.WriteLine($"Nome: {Nome}, Valor do Produto: {Preco}, Tipo do Produto: {TipoProduto}, " +
            $"Descrição: {Descricao}");
    }
}
