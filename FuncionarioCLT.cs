using CadastroSalario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    internal class FuncionarioCLT : Funcionario
    {
        public double Bonus { get; set; }
        public override void CalcularSalario()
        {
            SalarioFinal = SalarioBase + Bonus;
        }

        public void ReceberDadosCLT()
        {
            Console.Write("Digite o BOnus");
            Bonus = double.Parse(Console.ReadLine());
        }
    }
}
