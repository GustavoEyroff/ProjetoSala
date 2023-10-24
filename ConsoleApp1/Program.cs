using System;
using System.Collections.Generic;

class Produto
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public double PrecoUnitario { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public Produto(int codigo, string nome, double precoUnitario, int quantidadeEmEstoque)
    {
        Codigo = codigo;
        Nome = nome;
        PrecoUnitario = precoUnitario;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public override string ToString()
    {
        return $"{Codigo}: {Nome} - Preço: ${PrecoUnitario} - Estoque: {QuantidadeEmEstoque} unidades";
    }
}

class CarrinhoDeCompras
{
    public List<Produto> Itens { get; private set; }

    public CarrinhoDeCompras()
    {
        Itens = new List<Produto>();
    }

    public void AdicionarItem(Produto produto, int quantidade)
    {
        for (int i = 0; i < quantidade; i++)
        {
            Itens.Add(produto);
        }
    }

    public double CalcularTotal()
    {
        double total = 0;
        foreach (var item in Itens)
        {
            total += item.PrecoUnitario;
        }
        return total;
    }
}

class Program
{
    static void Main()
    {
        List<Produto> estoque = new List<Produto>
        {
            new Produto(1, "Camiseta", 19.99, 50),
            new Produto(2, "Calça Jeans", 49.99, 30),
            new Produto(3, "Tênis", 79.99, 20),
            new Produto(4, "Boné", 9.99, 100)
        };

        CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

        Console.WriteLine("Bem-vindo à nossa loja!");
        Console.WriteLine("Produtos disponíveis:");

        foreach (var produto in estoque)
        {
            Console.WriteLine(produto);
        }

        while (true)
        {
            Console.WriteLine("\nDigite o código do produto que deseja adicionar ao carrinho (ou '0' para sair):");
            int codigo = int.Parse(Console.ReadLine());

            if (codigo == 0)
            {
                break;
            }

            Console.WriteLine("Digite a quantidade desejada:");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produtoSelecionado = estoque.Find(p => p.Codigo == codigo);

            if (produtoSelecionado != null && produtoSelecionado.QuantidadeEmEstoque >= quantidade)
            {
                carrinho.AdicionarItem(produtoSelecionado, quantidade);
                Console.WriteLine($"'{produtoSelecionado.Nome}' adicionado ao carrinho.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado ou quantidade insuficiente em estoque.");
            }
        }

        Console.WriteLine($"\nTotal do carrinho: ${carrinho.CalcularTotal():0.00}");

        Console.WriteLine("\nObrigado por fazer compras conosco!");
    }
}
