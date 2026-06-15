using CadastroSalario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1ParaFinalizar
{
    internal class FuncionarioComissionado : Funcionario
    {
        public double TotalVendas { get; set; }
        public double PercentualComissao { get; set; }

        public override void CalcularSalario()
        {
            SalarioFinal = SalarioBase + (TotalVendas * PercentualComissao / 100);
        }

        public void ReceberDadosComissionado()
        {
            Console.Write("Digite o Total de Vendas: ");
            TotalVendas = double.Parse(Console.ReadLine());

            Console.Write("Digite o Percentual de Comissão (%): ");
            PercentualComissao = double.Parse(Console.ReadLine());
        }
    }
}