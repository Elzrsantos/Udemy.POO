using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.POO.Sessao1.Exercicio7 {
    class Exerc7 {
        static void Main(string[] args) {

            int num, saida;

            num = int.Parse(Console.ReadLine());

            while (num != 0) {

                saida = (int)Math.Pow(num, 2);

                Console.WriteLine(saida);

                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
