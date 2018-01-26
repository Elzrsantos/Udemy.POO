using System;
using System.Collections.Generic;
using Udemy.POO.Sessao03.Proposto1.Dominio;

namespace Udemy.POO.Sessao03.Proposto1 {
    class Program {

        public static List<Artista> lisArtista = new List<Artista>();
        public static List<Filme> lisFilme = new List<Filme>();

        static void Main(string[] args) {

            Artista.IniciarArtistas(ref lisArtista);

            int opcao = 0;

            while (opcao != 5) {

                Tela.ExibirMenu();

                Console.Write("Digite uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                Console.WriteLine();

                try {
                    switch (opcao) {
                        case 1:
                            Tela.ListarArtistas();
                            break;

                        case 2:
                            Tela.CadastrarArtista();
                            break;

                        case 3:
                            Tela.CadastrarFilme();
                            break;

                        case 4:
                            Tela.MostrarFilme();
                            break;
                        case 5:
                            Console.WriteLine("Programa finalizado!");
                            break;
                        default:
                            break;
                    }
                }
                catch (ModelException e) {
                    Console.WriteLine("Erro de negócio: " + e.Message);
                }
                catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                }

                Console.ReadLine();
            }
        }
    }
}
