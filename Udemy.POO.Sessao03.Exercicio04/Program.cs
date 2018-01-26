using System;
using System.Collections.Generic;
using System.Globalization;

namespace Udemy.POO.Sessao03.Exercicio04 {
    class Program {
        static void Main(string[] args) {

            List<Funcionario> lisFuncionario = new List<Funcionario>();

            Console.Write("Quantos funcionários serão cadastrados? ");
            int qtdFuncionarios = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdFuncionarios; i++) {
                Console.WriteLine("Dados do " + (i + 1) + "° funcionário:");

                Console.Write("CPF: ");
                int cPF = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lisFuncionario.Add(new Funcionario(cPF, nome, salario));

                Console.WriteLine();
            }

            Console.Write("Digite o CPF do funcionário que terá aumento: ");
            int aumentoParaFuncionario = int.Parse(Console.ReadLine());

            int idxFuncionario = lisFuncionario.FindIndex(x => x.Cpf == aumentoParaFuncionario);

            if (idxFuncionario < 0) {
                Console.WriteLine("CPF INEXISTENTE");
            }
            else {

                Console.Write("Digite a porcentagem de aumento: ");
                double percentualDeAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lisFuncionario[idxFuncionario].aumentarSalario(percentualDeAumento);
            }

            Console.WriteLine();

            Console.WriteLine("Listagem atualizada de funcionários:");

            foreach (Funcionario item in lisFuncionario) {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
