public class Cliente 
{

   public string Nome { get; set; }
   public string Cpf { get; set; }
   public int Idade { get; set; }

    public void Popular()
    {
        Console.WriteLine("Digite o nome do cliente");
        Nome = Console.ReadLine();

        Console.WriteLine("Digite o cpf do cliente");
        Cpf = Console.ReadLine();

        Console.WriteLine("Digite a idade do cliente");
        Idade = Convert.ToInt32(Console.ReadLine());
    }


    public void Listar()
    {
        Console.WriteLine($"Nome: {Nome}, CPF: {Cpf}, Idade: {Idade}");
    }
}
