using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Aluno
    {
        public string RA { get; set; }
        public string Nome { get; set; }

        public int Idade { get; set; }


        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome} RA:{RA} Idade: {Idade}");
        }

    }
}
