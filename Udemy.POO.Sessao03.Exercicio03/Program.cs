using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.POO.Sessao03.Exercicio03 {
    class Program {
        static void Main(string[] args) {

            int[,] matriz;

            string[] tamanhoDaMatriz = Console.ReadLine().Split(' ');

            int M = int.Parse(tamanhoDaMatriz[0]);
            int N = int.Parse(tamanhoDaMatriz[1]);

            matriz = new int[M, N];

            for (int i = 0; i < M; i++) {

                string[] entradaMatrz = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(entradaMatrz[j]);
                }
            }

            int X = int.Parse(Console.ReadLine());

#pragma warning disable CS0219 // A variável "esquerda" é atribuída, mas seu valor nunca é usado
            int esquerda = 0;
#pragma warning restore CS0219 // A variável "esquerda" é atribuída, mas seu valor nunca é usado
#pragma warning disable CS0219 // A variável "acima" é atribuída, mas seu valor nunca é usado
            int acima = 0;
#pragma warning restore CS0219 // A variável "acima" é atribuída, mas seu valor nunca é usado
#pragma warning disable CS0219 // A variável "abaixo" é atribuída, mas seu valor nunca é usado
            int abaixo = 0;
#pragma warning restore CS0219 // A variável "abaixo" é atribuída, mas seu valor nunca é usado

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {

                    int valor = matriz[i, j];

                    if (valor == X) {
                        //    esquerda = matriz[i, j - 1];
                        //    acima = matriz[i - 1, j];
                        //    abaixo = matriz[i + 1, j];

                        if (j > 0) {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Acima: " + matriz[i - 1, j]);
                        }
                        if (j < N - 1) {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }
                        if (i < M - 1) {
                            Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                        }

                        // solução paliativa para parar de varrer a matriz: 
                        j = N;
                        i = M;
                    }
                }
            }

            //Console.WriteLine();
            //Console.WriteLine("Esquerda: " + esquerda.ToString());
            //Console.WriteLine("Acima: " + acima.ToString());
            //Console.WriteLine("Abaixo: " + abaixo.ToString());

            Console.ReadLine();
        }
    }
}
