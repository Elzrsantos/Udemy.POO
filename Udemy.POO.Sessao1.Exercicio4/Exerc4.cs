using System;
using System.Globalization;

namespace Udemy.POO.Sessao1.Exercicio4 {
    class Exerc4 {
        static void Main(string[] args) {
            double glicose;
            string saida;

            glicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (glicose <= 100) {
                saida = "Normal";
            }
            else if (glicose <= 140) {
                saida = "Elevado";
            }
            else {
                saida = "Diabetes";
            }

            Console.WriteLine(saida);
            Console.ReadLine();
        }
    }
}