using System;
using System.Globalization;

namespace Udemy.POO.Sessao1.Exercicio10 {
    class Exerc10 {
        static void Main(string[] args) {
            int nQtdAlunos;
#pragma warning disable CS0168 // A variável "nota1" está declarada, mas nunca é usada
#pragma warning disable CS0168 // A variável "nota3" está declarada, mas nunca é usada
#pragma warning disable CS0168 // A variável "nota2" está declarada, mas nunca é usada
            double nota1, nota2, nota3, notaFinal;
#pragma warning restore CS0168 // A variável "nota2" está declarada, mas nunca é usada
#pragma warning restore CS0168 // A variável "nota3" está declarada, mas nunca é usada
#pragma warning restore CS0168 // A variável "nota1" está declarada, mas nunca é usada

            nQtdAlunos = int.Parse(Console.ReadLine());

            for (int i = 0; i < nQtdAlunos; i++) {
                string[] entrada = Console.ReadLine().Split(' ');

                notaFinal = double.Parse(entrada[0], CultureInfo.InvariantCulture);
                notaFinal += double.Parse(entrada[1], CultureInfo.InvariantCulture);
                notaFinal += double.Parse(entrada[2], CultureInfo.InvariantCulture);

                Console.WriteLine(notaFinal.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
