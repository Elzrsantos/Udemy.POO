using System.Globalization;

namespace Udemy.POO.Sessao03.Proposto1.Dominio {
    class Participacao {
        public double Desconto { get; private set; }
        Artista Artista { get; set; }

        public Participacao(Artista artista, double desconto) {
            this.Desconto = desconto;
            this.Artista = artista;
        }

        public double Custo() {
            return this.Artista.Cache - Desconto;
        }

        public override string ToString() {
            return this.Artista.Nome
                + ", Cachê: "
                + this.Artista.Cache
                + ", Desconto: "
                + this.Desconto.ToString("F2", CultureInfo.InvariantCulture)
                + ", Custo: "
                + this.Custo().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
