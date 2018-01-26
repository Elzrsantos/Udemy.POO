using System;
using System.Collections.Generic;
using System.Globalization;

namespace Udemy.POO.Sessao03.Proposto2.Dominio {
    class Carro : IComparable {
        public int Codigo { get; private set; }
        public string Modelo { get; set; }
        public int Ano { get; private set; }
        public double PrecoBasico { get; private set; }

        public Marca Marca { get; set; }
        public List<Acessorio> Acessorios { get; set; }

        public Carro(int codigo, string modelo, int ano, double precoBasico, Marca marca) {
            this.Codigo = codigo;
            this.Modelo = modelo;
            this.Ano = ano;
            this.PrecoBasico = precoBasico;
            this.Marca = marca;

            this.Acessorios = new List<Acessorio>();
        }

        public double PrecoTotal() {
            double soma = this.PrecoBasico;

            foreach (Acessorio item in Acessorios) {
                soma += item.Preco;
            }

            return soma;
        }

        public void IncluirAcessorio(Acessorio acessorio) {
            this.Acessorios.Add(acessorio);
        }

        public override string ToString() {
            string carro = this.Codigo.ToString()
                + ", "
                + this.Modelo
                + ", Ano: "
                + this.Ano.ToString()
                + ", Preço básico: "
                + this.PrecoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + ", Preço total: "
                + this.PrecoTotal().ToString("F2", CultureInfo.InvariantCulture);

            string acessorios = "";

            if (this.Acessorios.Count > 0) {
                acessorios = "\nAcessórios:";

                foreach (Acessorio item in this.Acessorios) {
                    acessorios += "\n";
                    acessorios += item;
                }
            }

            return carro
                + acessorios;
        }

        public static void IniciarCarros() {
            Program.carros.Add(new Carro(101, "Fusca", 1980, 5000.00, Program.marcas[0]));
            Program.carros.Add(new Carro(102, "Golf", 2016, 60000.00, Program.marcas[0]));
            Program.carros.Add(new Carro(103, "Fox", 2017, 30000.00, Program.marcas[0]));
            Program.carros.Add(new Carro(104, "Cruze", 2016, 30000.00, Program.marcas[1]));
            Program.carros.Add(new Carro(105, "Cobalt", 2015, 25000.00, Program.marcas[1]));
            Program.carros.Add(new Carro(106, "Cobalt", 2017, 35000.00, Program.marcas[1]));
        }

        public int CompareTo(object obj) {
            int ret;
            Carro carroCompare = (Carro)obj;

            ret = this.Modelo.CompareTo(carroCompare.Modelo);

            if (ret == 0) {
                ret = -this.PrecoTotal().CompareTo(carroCompare.PrecoTotal());
            }

            return ret;
        }
    }
}
