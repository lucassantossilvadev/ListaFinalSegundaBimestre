using System;

class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public double SalarioBase { get; set; }

    public void ReceberDados()
    {
        Console.Write("Nome: ");
        Nome = Console.ReadLine();

        Console.Write("Cargo: ");
        Cargo = Console.ReadLine();

        Console.Write("Salário Base: R$ ");
        SalarioBase = double.Parse(Console.ReadLine());
    }

    public virtual double CalcularSalarioFinal()
    {
        return SalarioBase;
    }

    public virtual void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário Final: R$ {CalcularSalarioFinal():F2}");
    }
}

class FuncionarioCLT : Funcionario
{
    public double Bonus { get; set; }

    public void ReceberDadosCLT()
    {
        ReceberDados();
        Console.Write("Bônus: R$ ");
        Bonus = double.Parse(Console.ReadLine());
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioBase + Bonus;
    }

    public override void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário Base: R$ {SalarioBase:F2}");
        Console.WriteLine($"Bônus: R$ {Bonus:F2}");
        Console.WriteLine($"Salário Final: R$ {CalcularSalarioFinal():F2}");
    }
}

class FuncionarioComissionado : Funcionario
{
    public double TotalVendas { get; set; }
    public double PercentualComissao { get; set; }

    public void ReceberDadosComissionado()
    {
        ReceberDados();
        Console.Write("Total de Vendas: R$ ");
        TotalVendas = double.Parse(Console.ReadLine());

        Console.Write("Percentual de Comissão (%): ");
        PercentualComissao = double.Parse(Console.ReadLine());
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioBase + (TotalVendas * PercentualComissao / 100);
    }

    public override void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário Base: R$ {SalarioBase:F2}");
        Console.WriteLine($"Total de Vendas: R$ {TotalVendas:F2}");
        Console.WriteLine($"Percentual de Comissão: {PercentualComissao}%");
        Console.WriteLine($"Salário Final: R$ {CalcularSalarioFinal():F2}");
    }
}

class ExercicioUm
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Funcionário CLT ===");
        FuncionarioCLT clt = new FuncionarioCLT();
        clt.ReceberDadosCLT();

        Console.WriteLine("\n=== Funcionário Comissionado ===");
        FuncionarioComissionado comissionado = new FuncionarioComissionado();
        comissionado.ReceberDadosComissionado();

        Console.WriteLine("\n======= RESULTADO =======");

        Console.WriteLine("\n--- Funcionário CLT ---");
        clt.MostrarDados();

        Console.WriteLine("\n--- Funcionário Comissionado ---");
        comissionado.MostrarDados();
    }
}