using System;
using System.Collections.Generic;

class Aluno
{
    public string RA { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class ExercicioQuatro
{
    static List<Aluno> alunos = new List<Aluno>();

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("\n======= GERENCIAMENTO DE ALUNOS =======");
            Console.WriteLine("1 - Cadastrar aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Alterar dados de aluno");
            Console.WriteLine("4 - Remover aluno");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarAluno();
                    break;
                case 2:
                    ListarAlunos();
                    break;
                case 3:
                    AlterarAluno();
                    break;
                case 4:
                    RemoverAluno();
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

    static void CadastrarAluno()
    {
        Console.WriteLine("\n--- Cadastrar Aluno ---");

        Console.Write("RA: ");
        string ra = Console.ReadLine();

        // Verifica se o RA já existe
        Aluno existente = alunos.Find(a => a.RA == ra);
        if (existente != null)
        {
            Console.WriteLine("Erro: já existe um aluno com este RA.");
            return;
        }

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Aluno novoAluno = new Aluno
        {
            RA = ra,
            Nome = nome,
            Idade = idade
        };

        alunos.Add(novoAluno);
        Console.WriteLine("Aluno cadastrado com sucesso!");
    }

    static void ListarAlunos()
    {
        Console.WriteLine("\n--- Lista de Alunos ---");

        if (alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado.");
            return;
        }

        Console.WriteLine($"{"RA",-15} {"Nome",-30} {"Idade",-5}");
        Console.WriteLine(new string('-', 52));

        foreach (Aluno a in alunos)
        {
            Console.WriteLine($"{a.RA,-15} {a.Nome,-30} {a.Idade,-5}");
        }
    }

    static void AlterarAluno()
    {
        Console.WriteLine("\n--- Alterar Dados do Aluno ---");

        Console.Write("Informe o RA do aluno: ");
        string ra = Console.ReadLine();

        Aluno aluno = alunos.Find(a => a.RA == ra);

        if (aluno == null)
        {
            Console.WriteLine("Aluno não encontrado.");
            return;
        }

        Console.WriteLine($"Aluno encontrado: {aluno.Nome}");

        Console.Write($"Novo Nome (atual: {aluno.Nome}): ");
        string novoNome = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(novoNome))
            aluno.Nome = novoNome;

        Console.Write($"Nova Idade (atual: {aluno.Idade}): ");
        string novaIdadeStr = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(novaIdadeStr))
            aluno.Idade = int.Parse(novaIdadeStr);

        Console.WriteLine("Dados alterados com sucesso!");
    }

    static void RemoverAluno()
    {
        Console.WriteLine("\n--- Remover Aluno ---");

        Console.Write("Informe o RA do aluno: ");
        string ra = Console.ReadLine();

        Aluno aluno = alunos.Find(a => a.RA == ra);

        if (aluno == null)
        {
            Console.WriteLine("Aluno não encontrado.");
            return;
        }

        Console.Write($"Confirma a remoção do aluno {aluno.Nome}? (S/N): ");
        string confirmacao = Console.ReadLine().ToUpper();

        if (confirmacao == "S")
        {
            alunos.Remove(aluno);
            Console.WriteLine("Aluno removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Remoção cancelada.");
        }
    }
}