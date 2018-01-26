using System;
using System.Globalization;

namespace Udemy.POO.Sessao1.Exercicio6 {
    class Exerc6 {
        static void Main(string[] args) {
            int num1, num2, soma = 0, i;

            string[] entrada = Console.ReadLine().Split(' ');

            num1 = int.Parse(entrada[0], CultureInfo.InvariantCulture);
            num2 = int.Parse(entrada[1], CultureInfo.InvariantCulture);

            for (i = num1; i <= num2; i++) {
                if (i % 2 != 0) {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
