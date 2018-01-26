using System.Globalization;
using System.Collections.Generic;

namespace Udemy.POO.Sessao03.Proposto1.Dominio {
    class Filme {
        public int Codigo { get; private set; }
        public string Titulo { get; private set; }
        public int Ano { get; private set; }
        public List<Participacao> LisParticipacao { get; set; }

        public Filme(int codigo, string titulo, int ano) {
            this.Codigo = codigo;
            this.Titulo = titulo;
            this.Ano = ano;
            this.LisParticipacao = new List<Participacao>();
        }

        public double CustoTotal() {
            double soma = 0;

            foreach (Participacao item in LisParticipacao) {
                soma += item.Custo();
            }

            return soma;
        }

        public override string ToString() {
            string filme = "";
            string participacoes = "";
            string ret = "";
            string custoTotal = "";

            filme = "Filme "
                + this.Codigo
                + ", Título: "
                + this.Titulo
                + ", Ano: "
                + this.Ano;

            foreach (Participacao item in this.LisParticipacao) {
                participacoes += "\n"
                    + item;
            }

            custoTotal = "\n"
                + "Custo total do filme: "
                + this.CustoTotal().ToString("F2", CultureInfo.InvariantCulture);

            ret = filme
                + "\n"
                + "Participações:"
                + participacoes
                + custoTotal;

            return ret;
        }
    }
}
