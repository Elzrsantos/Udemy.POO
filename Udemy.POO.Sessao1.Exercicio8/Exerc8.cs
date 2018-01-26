using System;

namespace Udemy.POO.Sessao1.Exercicio8 {
    class Exerc8 {
        static void Main(string[] args) {
            int n, a, b, i;

            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            for (i = a; i <= b; i++) {
                if (i % n == 0) {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
