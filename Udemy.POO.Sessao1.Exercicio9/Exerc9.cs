using System;
using System.Globalization;

namespace Udemy.POO.Sessao1.Exercicio9 {
    class Exerc9 {
        static void Main(string[] args) {
            double duracaoTotal, tempo, saida;
            int nVezes, i;

            duracaoTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nVezes = int.Parse(Console.ReadLine());

            saida = duracaoTotal;

            for (i = 0; i < nVezes; i++) {
                tempo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                saida -= tempo;

                if (saida < 0) {
                    Console.WriteLine("recarregar");
                }
                else {
                    Console.WriteLine(saida.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            Console.ReadLine();
        }
    }
}
