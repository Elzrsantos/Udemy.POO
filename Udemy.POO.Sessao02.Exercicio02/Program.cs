using System;
using System.Globalization;

namespace Udemy.POO.Sessao02.Exercicio02 {
    class Program {
        static void Main(string[] args) {

            Funcionario funcionario;

            funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.nome = Console.ReadLine();

            Console.Write("Salario bruto: ");
            funcionario.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Desconto: ");
            funcionario.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Dados do funcionário: " + funcionario);
            Console.WriteLine();

            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            funcionario.aumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados do funcionário: " + funcionario);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
