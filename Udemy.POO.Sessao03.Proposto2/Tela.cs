using System;
using System.Globalization;
using System.Collections.Generic;
using Udemy.POO.Sessao03.Proposto2.Dominio;

namespace Udemy.POO.Sessao03.Proposto2 {
    class Tela {

        public static void ExibirMenu() {
            Console.Clear();

            Console.WriteLine("1 – Listar marcas");
            Console.WriteLine("2 – Listar carros de uma marca");
            Console.WriteLine("3 – Cadastrar marca");
            Console.WriteLine("4 – Cadastrar carro");
            Console.WriteLine("5 – Cadastrar acessório");
            Console.WriteLine("6 – Mostrar detalhes de um carro");
            Console.WriteLine("7 – Sair");

            Console.WriteLine();
        }

        public static void ListarMarcas() {
            Console.WriteLine("LISTAGEM DE MARCAS:");

            Program.marcas.Sort();

            foreach (Marca item in Program.marcas) {
                Console.WriteLine(item);
            }
        }

        public static void ListarCarros() {
            Console.Write("Digite o código da marca: ");
            int codigoMarca = int.Parse(Console.ReadLine());

            Marca marca = Program.marcas.Find(x => x.Codigo == codigoMarca);

            if (marca == null) {
                throw new ModelException("Marca não existe.");
            }

            Console.WriteLine("Carros da marca " + marca.Nome + ":");

            List<Carro> carrosPorMarca = Program.carros.FindAll(x => x.Marca.Codigo == marca.Codigo);

            carrosPorMarca.Sort();

            foreach (Carro item in carrosPorMarca) {
                Console.WriteLine(item);
            }
        }

        public static void CadastrarMarca() {
            Console.WriteLine("Digite os dados da marca:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("País de origem: ");
            string pais = Console.ReadLine();

            Program.marcas.Add(new Marca(codigo, nome, pais));
        }

        public static void CadastrarCarro() {
            Console.WriteLine("Digite os dados do carro:");
            Console.Write("Marca(código): ");
            int codigoMarca = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Marca marca = Program.marcas.Find(x => x.Codigo == codigoMarca);

            if (marca == null) {
                throw new ModelException("Marca não existe.");
            }

            Console.Write("Código do carro: ");
            int codigoCarro = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Preço básico: ");
            double precoBasico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Program.carros.Add(new Carro(codigoCarro, modelo, ano, precoBasico, marca));
        }

        public static void CadastrarAcessorio() {
            Console.WriteLine("Digite os dados do acessório:");
            Console.Write("Carro(código): ");
            int codigoCarro = int.Parse(Console.ReadLine());

            int pos = Program.carros.FindIndex(x => x.Codigo == codigoCarro);

            if (pos == -1) {
                throw new ModelException("Carro não existe.");
            }

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Program.carros[pos].IncluirAcessorio(new Acessorio(descricao, preco));
        }

        public static void MostrarCarro() {
            Console.Write("Digite o código do carro: ");
            int codigoCarro = int.Parse(Console.ReadLine());

            Carro carro = Program.carros.Find(x => x.Codigo == codigoCarro);

            if (carro == null) {
                throw new ModelException("O carro não existe.");
            }

            Console.WriteLine(carro);
        }
    }
}
