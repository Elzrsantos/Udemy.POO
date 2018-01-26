using System;
using System.Collections.Generic;
using Udemy.POO.Sessao03.Proposto2.Dominio;

/// <summary>
/// Exercício proposto
/// </summary>
/// <remarks>
/// Teste com Git
/// </remarks>
namespace Udemy.POO.Sessao03.Proposto2 {
    class Program {

        public static List<Marca> marcas = new List<Marca>();
        public static List<Carro> carros = new List<Carro>();
        public static List<Acessorio> acessorio = new List<Acessorio>();

        static void Main(string[] args) {

            Marca.IniciarMarcas();
            Carro.IniciarCarros();

            int opcao = 0;

            while (opcao != 7) {
                Tela.ExibirMenu();

                Console.Write("Digite uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                try {
                    switch (opcao) {
                        case 1:
                            Tela.ListarMarcas();
                            break;
                        case 2:
                            Tela.ListarCarros();
                            break;
                        case 3:
                            Tela.CadastrarMarca();
                            break;
                        case 4:
                            Tela.CadastrarCarro();
                            break;
                        case 5:
                            Tela.CadastrarAcessorio();
                            break;
                        case 6:
                            Tela.MostrarCarro();
                            break;
                        case 7:
                            Console.WriteLine("Programa finalizado!");
                            break;
                        default:
                            break;
                    }
                }
                catch (ModelException e) {
                    Console.WriteLine("Ocorreu um erro de negócio: " + e.Message);
                    throw;
                }
                catch (Exception e) {
                    Console.WriteLine("Ocorreu um erro inesperado: " + e.Message);
                }

                Console.ReadLine();
            }
        }
    }
}
