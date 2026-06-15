using System;
using System.Collections.Generic;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class ExercicioSeis
{
    static void Main(string[] args)
    {
        List<Produto> produtos = new List<Produto>();

        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine($"Produto {i}:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: R$ ");
            double preco = double.Parse(Console.ReadLine());

            produtos.Add(new Produto { Nome = nome, Preco = preco });

            Console.WriteLine();
        }

        Console.WriteLine("Produtos cadastrados:");
        double total = 0;

        foreach (Produto p in produtos)
        {
            Console.WriteLine($"{p.Nome} - R$ {p.Preco:F2}");
            total += p.Preco;
        }

        Console.WriteLine($"\nValor total: R$ {total:F2}");
    }
}