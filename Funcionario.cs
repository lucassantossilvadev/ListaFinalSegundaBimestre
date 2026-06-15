using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSalario
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double SalarioBase { get; set; }
        public double SalarioFinal { get; set; }

        public void ReceberDados()
        {
            Console.Write("Digite o Nome:");
            Nome = Console.ReadLine();

            Console.Write("Digite o Cargo:");
            Cargo = Console.ReadLine();

            Console.Write("Digite o Sal Base:");
            SalarioBase = double.Parse(Console.ReadLine());

        }

        public void MostrarDados()
        {
            Console.Write($"O {Nome} tem o salário {SalarioFinal}");

        }

        public abstract void CalcularSalario();



    }
}
