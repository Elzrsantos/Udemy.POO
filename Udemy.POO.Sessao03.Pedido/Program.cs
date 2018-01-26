using System;
using System.Collections.Generic;
using Udemy.POO.Sessao03.Exercicio06.Dominio;

namespace Udemy.POO.Sessao03.Exercicio06 {
    class Program {

        public static List<Produto> produtos = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>();

        static void Main(string[] args) {

            int opcao = 0;

            produtos.Add(new Produto(1001, "Cadeira simples", 500.00));
            produtos.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
            produtos.Add(new Produto(1003, "Sofá de três lugares", 2000.00));
            produtos.Add(new Produto(1004, "Mesa retangular", 1500.00));
            produtos.Add(new Produto(1005, "Mesa retangular", 2000.00));

            while (opcao != 5) {
                Console.Clear();

                Tela.MostrarMenu();

                try {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {

                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }

                Console.WriteLine();

                switch (opcao) {
                    case 1:
                        Tela.MostrarProdutos();
                        break;
                    case 2:
                        try {
                            Tela.CadastrarProduto();
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 3:
                        try {
                            Tela.CadastrarPedido();
                        }
                        catch (ModelException e) {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 4:
                        Tela.MostrarPedido();
                        break;
                    case 5:
                        Console.WriteLine("Fim do programa!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
