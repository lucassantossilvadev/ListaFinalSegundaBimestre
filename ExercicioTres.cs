using System;

class Veiculo
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public double ValorBaseManutencao { get; set; }

    public void ReceberDados()
    {
        Console.Write("Modelo: ");
        Modelo = Console.ReadLine();

        Console.Write("Ano: ");
        Ano = int.Parse(Console.ReadLine());

        Console.Write("Valor Base de Manutenção: R$ ");
        ValorBaseManutencao = double.Parse(Console.ReadLine());
    }

    public virtual double CalcularCustoManutencao()
    {
        return ValorBaseManutencao;
    }

    public virtual void MostrarDados()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Custo de Manutenção: R$ {CalcularCustoManutencao():F2}");
    }
}

class Carro : Veiculo
{
    public int QuantidadePortas { get; set; }

    public void ReceberDadosCarro()
    {
        ReceberDados();
        Console.Write("Quantidade de Portas: ");
        QuantidadePortas = int.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 200;
    }

    public override void MostrarDados()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Quantidade de Portas: {QuantidadePortas}");
        Console.WriteLine($"Custo de Manutenção: R$ {CalcularCustoManutencao():F2}");
    }
}

class Moto : Veiculo
{
    public int Cilindradas { get; set; }

    public void ReceberDadosMoto()
    {
        ReceberDados();
        Console.Write("Cilindradas (cc): ");
        Cilindradas = int.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 100;
    }

    public override void MostrarDados()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Cilindradas: {Cilindradas} cc");
        Console.WriteLine($"Custo de Manutenção: R$ {CalcularCustoManutencao():F2}");
    }
}

class Caminhao : Veiculo
{
    public double CapacidadeCarga { get; set; }

    public void ReceberDadosCaminhao()
    {
        ReceberDados();
        Console.Write("Capacidade de Carga (toneladas): ");
        CapacidadeCarga = double.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 500;
    }

    public override void MostrarDados()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Capacidade de Carga: {CapacidadeCarga} toneladas");
        Console.WriteLine($"Custo de Manutenção: R$ {CalcularCustoManutencao():F2}");
    }
}

class ExercicioTres
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Cadastro do Carro ===");
        Carro carro = new Carro();
        carro.ReceberDadosCarro();

        Console.WriteLine("\n=== Cadastro da Moto ===");
        Moto moto = new Moto();
        moto.ReceberDadosMoto();

        Console.WriteLine("\n=== Cadastro do Caminhão ===");
        Caminhao caminhao = new Caminhao();
        caminhao.ReceberDadosCaminhao();

        Console.WriteLine("\n======= RELATÓRIO DE MANUTENÇÃO =======");

        Console.WriteLine("\n--- Carro ---");
        carro.MostrarDados();

        Console.WriteLine("\n--- Moto ---");
        moto.MostrarDados();

        Console.WriteLine("\n--- Caminhão ---");
        caminhao.MostrarDados();
    }
}