using System.Globalization;

namespace Udemy.POO.Sessao03.Proposto2.Dominio {
    class Acessorio {
        public string Nome { get; private set; }
        public double Preco { get; private set; }

        public Acessorio(string nome, double preco) {
            this.Nome = nome;
            this.Preco = preco;
        }

        public override string ToString() {
            return this.Nome    
                + ", Preço: "
                + this.Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
