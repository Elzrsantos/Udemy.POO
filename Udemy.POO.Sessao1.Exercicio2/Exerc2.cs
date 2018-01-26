using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.POO.Sessao1.Exercicio2 {
    class Exerc2 {
        static void Main(string[] args) {
            double nota1, nota2, nota3, notaFinal;

            string[] entrada = Console.ReadLine().Split(' ');

            nota1 = double.Parse(entrada[0], System.Globalization.CultureInfo.InvariantCulture);
            nota2 = double.Parse(entrada[1], System.Globalization.CultureInfo.InvariantCulture);
            nota3 = double.Parse(entrada[2], System.Globalization.CultureInfo.InvariantCulture);

            notaFinal = nota1 + nota2 + nota3;

            Console.WriteLine(notaFinal.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));

            if (notaFinal < 60.00) {
                Console.WriteLine("DEPENDENCIA");
            }

            Console.ReadLine();
        }
    }
}
