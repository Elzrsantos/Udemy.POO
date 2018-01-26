using System;

namespace Udemy.POO.Sessao1.Exercicio1
{
    class Exerc1
    {
        static void Main(string[] args)
        {
            int volumeInicial, vazao, tempo, volumeRestante;

            volumeInicial = int.Parse(Console.ReadLine());
            vazao = int.Parse(Console.ReadLine());
            tempo = int.Parse(Console.ReadLine());

            volumeRestante = volumeInicial - vazao * tempo;

            if (volumeRestante < 0) {
                Console.WriteLine("nao eh possivel");
            }
            else {
                Console.WriteLine(volumeRestante);
            }

            Console.ReadLine();
        }
    }
}
