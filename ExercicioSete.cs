using System;

interface IDesconto
{
    decimal Calcular(decimal valor);
}

class DescontoClienteComum : IDesconto
{
    public decimal Calcular(decimal valor)
    {
        return valor - (valor * 0.05m);
    }
}

class DescontoClienteVip : IDesconto
{
    public decimal Calcular(decimal valor)
    {
        return valor - (valor * 0.10m);
    }
}

class ExercicioSete
{
    static void Main(string[] args)
    {
        decimal valorCompra = 100.00m;

        IDesconto descontoComum = new DescontoClienteComum();
        IDesconto descontoVip = new DescontoClienteVip();

        decimal valorFinalComum = descontoComum.Calcular(valorCompra);
        decimal valorFinalVip = descontoVip.Calcular(valorCompra);

        Console.WriteLine($"Valor original: R$ {valorCompra:F2}");
        Console.WriteLine();
        Console.WriteLine($"Cliente Comum  (5% de desconto): R$ {valorFinalComum:F2}");
        Console.WriteLine($"Cliente VIP   (10% de desconto): R$ {valorFinalVip:F2}");
    }
}