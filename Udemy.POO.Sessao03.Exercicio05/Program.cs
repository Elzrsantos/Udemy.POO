using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.POO.Sessao03.Exercicio05 {
    class Program {
        static void Main(string[] args) {

            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("Quantos alunos possui o curso A? ");
            int alunosCursoA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < alunosCursoA; i++) {
                cursoA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Quantos alunos possui o curso B? ");
            int alunosCursoB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B ");
            for (int i = 0; i < alunosCursoB; i++) {
                cursoB.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Quantos alunos possui o curso C? ");
            int alunosCursoC = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < alunosCursoC; i++) {
                cursoC.Add(int.Parse(Console.ReadLine()));
            }

            cursoA.UnionWith(cursoB);
            cursoA.UnionWith(cursoC);

            Console.Write("Total de alunos: " + cursoA.Count.ToString());

            Console.ReadLine();
        }
    }
}
