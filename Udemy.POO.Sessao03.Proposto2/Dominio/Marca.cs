using System.Collections.Generic;
using Udemy.POO.Sessao03.Proposto2.Dominio;

namespace Udemy.POO.Sessao03.Proposto2.Dominio {
    class Marca {

        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Pais { get; private set; }

        public Marca(int codigo, string nome, string pais) {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Pais = pais;
        }

        public int QtdCarros() {
            return Program.carros.FindAll(x => x.Marca.Codigo == this.Codigo).Count;
        }

        public override string ToString() {
            return this.Codigo
                + ", "
                + this.Nome
                + ", País: "
                + this.Pais
                + ", Número de carros: "
                + this.QtdCarros().ToString();
        }

        public static void IniciarMarcas() {
            Program.marcas.Add(new Marca(1001, "Volkswagen", "Alemanha"));
            Program.marcas.Add(new Marca(1002, "General Motors", "Estados Unidos"));
        }
    }
}
