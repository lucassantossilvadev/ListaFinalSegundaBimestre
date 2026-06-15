using System;

class Pagamento
{
    public string NomeCliente { get; set; }
    public double Valor { get; set; }

    public void ReceberDados()
    {
        Console.Write("Nome do Cliente: ");
        NomeCliente = Console.ReadLine();

        Console.Write("Valor do Pagamento: R$ ");
        Valor = double.Parse(Console.ReadLine());
    }

    public virtual void ProcessarPagamento()
    {
        Console.WriteLine($"Pagamento de R$ {Valor:F2} para {NomeCliente} foi processado.");
    }

    public virtual void MostrarPagamento()
    {
        Console.WriteLine($"Cliente: {NomeCliente}");
        Console.WriteLine($"Valor: R$ {Valor:F2}");
    }
}

class PagamentoPix : Pagamento
{
    public string ChavePix { get; set; }
    private string Status { get; set; }

    public void ReceberDadosPix()
    {
        ReceberDados();
        Console.Write("Chave Pix: ");
        ChavePix = Console.ReadLine();
    }

    public override void ProcessarPagamento()
    {
        Status = "Aprovado";
        Console.WriteLine($"Pagamento via Pix de R$ {Valor:F2} para {NomeCliente} foi aprovado instantaneamente!");
    }

    public override void MostrarPagamento()
    {
        Console.WriteLine($"Cliente: {NomeCliente}");
        Console.WriteLine($"Valor: R$ {Valor:F2}");
        Console.WriteLine($"Chave Pix: {ChavePix}");
        Console.WriteLine($"Status: {Status}");
    }
}

class PagamentoCartaoCredito : Pagamento
{
    public int QuantidadeParcelas { get; set; }
    public double ValorParcela { get; private set; }

    public void ReceberDadosCartao()
    {
        ReceberDados();
        Console.Write("Quantidade de Parcelas: ");
        QuantidadeParcelas = int.Parse(Console.ReadLine());

        if (QuantidadeParcelas <= 0)
        {
            Console.WriteLine("Quantidade de parcelas inválida. Definindo como 1.");
            QuantidadeParcelas = 1;
        }
    }

    public override void ProcessarPagamento()
    {
        ValorParcela = Valor / QuantidadeParcelas;
        Console.WriteLine($"Pagamento no cartão de crédito aprovado para {NomeCliente}!");
        Console.WriteLine($"Total: R$ {Valor:F2} em {QuantidadeParcelas}x de R$ {ValorParcela:F2}");
    }

    public override void MostrarPagamento()
    {
        Console.WriteLine($"Cliente: {NomeCliente}");
        Console.WriteLine($"Valor Total: R$ {Valor:F2}");
        Console.WriteLine($"Parcelas: {QuantidadeParcelas}x de R$ {ValorParcela:F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Pagamento via Pix ===");
        PagamentoPix pix = new PagamentoPix();
        pix.ReceberDadosPix();
        pix.ProcessarPagamento();

        Console.WriteLine("\n=== Pagamento via Cartão de Crédito ===");
        PagamentoCartaoCredito cartao = new PagamentoCartaoCredito();
        cartao.ReceberDadosCartao();
        cartao.ProcessarPagamento();

        Console.WriteLine("\n======= RESUMO DOS PAGAMENTOS =======");

        Console.WriteLine("\n--- Pagamento Pix ---");
        pix.MostrarPagamento();

        Console.WriteLine("\n--- Pagamento Cartão de Crédito ---");
        cartao.MostrarPagamento();
    }
}