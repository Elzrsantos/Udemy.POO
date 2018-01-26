using System;
using System.Globalization;

namespace Udemy.POO.Sessao02.Exercicio03 {
    class Program {
        static void Main(string[] args) {

            Aluno aluno;

            string nome = Console.ReadLine();

            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno = new Aluno(nome, nota1, nota2, nota3);

            Console.WriteLine();
            Console.WriteLine("Nota final: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.Diferenca().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

            Console.ReadLine();
        }
    }
}
