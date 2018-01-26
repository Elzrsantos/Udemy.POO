using System;
using System.Globalization;
using System.Collections.Generic;

using Udemy.POO.Sessao03.Proposto1.Dominio;

namespace Udemy.POO.Sessao03.Proposto1 {
    class Tela {

        public static void ExibirMenu() {
            Console.Clear();

            Console.WriteLine("1 – Listar artistas ordenadamente");
            Console.WriteLine("2 – Cadastrar artista");
            Console.WriteLine("3 – Cadastrar filme");
            Console.WriteLine("4 – Mostrar dados de um filme");
            Console.WriteLine("5 – Sair");

            Console.WriteLine();
        }

        public static void ListarArtistas() {

            Program.lisArtista.Sort();

            foreach (Artista item in Program.lisArtista) {
                Console.WriteLine(item);
            }
        }

        public static void CadastrarArtista() {

            Console.WriteLine("Digite os dados do artista: ");

            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Valor do cachê: ");
            double cache = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Artista artista = new Artista(codigo, nome, cache);

            Program.lisArtista.Add(artista);
        }

        public static void CadastrarFilme() {
            int codigo;
            string nome;
            int ano;
            int n;
            Filme filme;
            List<Participacao> lisParticipacao;

            Console.WriteLine("Digite os dados do filme:");

            Console.Write("Código: ");
            codigo = int.Parse(Console.ReadLine());

            Console.Write("Título: ");
            nome = Console.ReadLine();

            Console.Write("Ano: ");
            ano = int.Parse(Console.ReadLine());

            Console.Write("Quantas participações tem o filme? ");
            n = int.Parse(Console.ReadLine());

            filme = new Filme(codigo, nome, ano);

            lisParticipacao = new List<Participacao>();

            for (int i = 1; i <= n; i++) {
                int codigoArtista;
                double desconto;
                int pos;

                Console.WriteLine("Digite os dados da " + i + "ª participação:");

                Console.Write("Artista(código): ");
                codigoArtista = int.Parse(Console.ReadLine());

                pos = Program.lisArtista.FindIndex(x => x.Codigo == codigoArtista);

                if (pos == -1) {
                    throw new ModelException("Artista não encontrado.");
                }

                Console.Write("Desconto: ");
                desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                filme.LisParticipacao.Add(new Participacao(Program.lisArtista[pos], desconto));
            }

            Program.lisFilme.Add(filme);
        }

        public static void MostrarFilme() {

            Console.Write("Digite o código do filme: ");
            int codigoFilme = int.Parse(Console.ReadLine());

            int pos = Program.lisFilme.FindIndex(x => x.Codigo == codigoFilme);

            if (pos == -1) {
                throw new ModelException("Filme não encontrado.");
            }

            Console.WriteLine(Program.lisFilme[pos]);
        }
    }
}
