using CadastroSalario;
using Exercicio1ParaFinalizar;
using Salario;

FuncionarioCLT _funcclt = new FuncionarioCLT();
_funcclt.ReceberDados();
_funcclt.ReceberDadosCLT();
_funcclt.CalcularSalario();
_funcclt.MostrarDados();

Console.WriteLine();

FuncionarioComissionado _funccom = new FuncionarioComissionado();
_funccom.ReceberDados();
_funccom.ReceberDadosComissionado();
_funccom.CalcularSalario();
_funccom.MostrarDados();