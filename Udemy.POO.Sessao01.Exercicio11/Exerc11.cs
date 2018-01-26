using System;

namespace Udemy.POO.Sessao01.Exercicio11 {
    class Exerc11 {
        static void Main(string[] args) {
            int volumeInicial, volumeFinal, ca;

            volumeInicial = int.Parse(Console.ReadLine());

            volumeFinal = volumeInicial;

            ca = int.Parse(Console.ReadLine());

            while (ca != 0) {

                volumeFinal += ca;

                if (volumeFinal < 0) {
                    volumeFinal = 0;
                }
                else if (volumeFinal > 100) {
                    volumeFinal = 100;
                }

                Console.WriteLine(volumeFinal);

                ca = int.Parse(Console.ReadLine());
            }
        }
    }
}
