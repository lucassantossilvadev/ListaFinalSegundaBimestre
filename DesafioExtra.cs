using System;
using System.Collections.Generic;

class Cliente
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Cidade { get; set; }
}

class DesafioExtra
{
    static List<Cliente> clientes = new List<Cliente>();

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU DE CLIENTES =====");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Listar clientes");
            Console.WriteLine("3 - Buscar cliente por nome");
            Console.WriteLine("4 - Remover cliente");
            Console.WriteLine("5 - Sair");
            Console.Write("\nEscolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarCliente();
                    break;
                case 2:
                    ListarClientes();
                    break;
                case 3:
                    BuscarCliente();
                    break;
                case 4:
                    RemoverCliente();
                    break;
                case 5:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (opcao != 5);
    }

    static void CadastrarCliente()
    {
        Console.WriteLine("\n--- Cadastrar Cliente ---");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Erro: o nome não pode ser vazio.");
            return;
        }

        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        clientes.Add(new Cliente { Nome = nome, Telefone = telefone, Cidade = cidade });
        Console.WriteLine("Cliente cadastrado com sucesso!");
    }

    static void ListarClientes()
    {
        Console.WriteLine("\n--- Lista de Clientes ---");

        if (clientes.Count == 0)
        {
            Console.WriteLine("Nenhum cliente cadastrado.");
            return;
        }

        Console.WriteLine($"{"Nome",-25} {"Telefone",-15} {"Cidade",-20}");
        Console.WriteLine(new string('-', 62));

        foreach (Cliente c in clientes)
        {
            Console.WriteLine($"{c.Nome,-25} {c.Telefone,-15} {c.Cidade,-20}");
        }
    }

    static void BuscarCliente()
    {
        Console.WriteLine("\n--- Buscar Cliente ---");

        Console.Write("Digite o nome do cliente: ");
        string nome = Console.ReadLine();

        Cliente cliente = clientes.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado.");
            return;
        }

        Console.WriteLine("Cliente encontrado:");
        Console.WriteLine($"Nome: {cliente.Nome}");
        Console.WriteLine($"Telefone: {cliente.Telefone}");
        Console.WriteLine($"Cidade: {cliente.Cidade}");
    }

    static void RemoverCliente()
    {
        Console.WriteLine("\n--- Remover Cliente ---");

        Console.Write("Digite o nome do cliente a remover: ");
        string nome = Console.ReadLine();

        Cliente cliente = clientes.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado.");
            return;
        }

        clientes.Remove(cliente);
        Console.WriteLine($"Cliente \"{cliente.Nome}\" removido com sucesso!");
    }
}