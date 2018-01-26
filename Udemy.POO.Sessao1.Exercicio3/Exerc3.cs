using System;

namespace Udemy.POO.Sessao1.Exercicio3 {
    class Exerc3 {
        static void Main(string[] args) {
            int larguraFoto, alturaFoto, larguraRetrato, alturaRetrato;
            string saida = "NAO";

            string[] entradaFoto = Console.ReadLine().Split(' ');

            larguraFoto = int.Parse(entradaFoto[0], System.Globalization.CultureInfo.InvariantCulture);
            alturaFoto = int.Parse(entradaFoto[1], System.Globalization.CultureInfo.InvariantCulture);

            string[] entradaRetrato = Console.ReadLine().Split(' ');

            larguraRetrato = int.Parse(entradaRetrato[0], System.Globalization.CultureInfo.InvariantCulture);
            alturaRetrato = int.Parse(entradaRetrato[1], System.Globalization.CultureInfo.InvariantCulture);

            if ((larguraFoto <= larguraRetrato && alturaFoto <= alturaRetrato)
                || (larguraFoto <= alturaRetrato && alturaFoto <= larguraRetrato)) {
                saida = "SIM";
            }

            Console.WriteLine(saida);
            Console.ReadLine();
        }
    }
}
