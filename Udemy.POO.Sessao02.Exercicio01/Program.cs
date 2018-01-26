using System;
using System.Globalization;

namespace Udemy.POO.Sessao02.Exercicio01 {
    class Program {
        static void Main(string[] args) {

            Retangulo retangulo;

            retangulo = new Retangulo();

            retangulo.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("AREA: " + retangulo.area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO: " + retangulo.perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + retangulo.diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
