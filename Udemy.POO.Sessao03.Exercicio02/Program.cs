using System;
using System.Globalization;

namespace Udemy.POO.Sessao03.Exercicio02 {
    class Program {
        static void Main(string[] args) {

            Quarto[] quartos;

            quartos = new Quarto[10];

            for (int i = 0; i < 10; i++) {
                quartos[i] = new Quarto(i);
            }

            Console.Write("Quantos aluguéis serão registrados? ");
            int alugueis = int.Parse(Console.ReadLine());

            for (int i = 1; i <= alugueis; i++) {

                Console.WriteLine();

                Console.WriteLine("Dados do " + i + "º aluguel: ");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quartoNum = int.Parse(Console.ReadLine());

                Quarto quarto = quartos[quartoNum];
                quarto.Estudante = new Estudante(nome, email);
            }

            Console.WriteLine();

            Console.WriteLine("Quartos ocupados:");

            foreach (Quarto quarto in quartos) {

                if (quarto.Estudante != null) {
                    Console.WriteLine(quarto.ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
