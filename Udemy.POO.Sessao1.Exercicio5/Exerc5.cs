using System;
using System.Globalization;

namespace Udemy.POO.Sessao1.Exercicio5 {
    class Exerc5 {
        static void Main(string[] args) {
            double medida1, medida2, medida3, maior;

            string[] entrada = Console.ReadLine().Split(' ');

            medida1 = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            medida2 = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            medida3 = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            maior = (double)Math.Max(Math.Max(medida1, medida2), medida3);

            Console.WriteLine(maior.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
