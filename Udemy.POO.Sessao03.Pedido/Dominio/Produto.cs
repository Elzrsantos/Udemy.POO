using System;
using System.Globalization;

namespace Udemy.POO.Sessao03.Exercicio06.Dominio {
    class Produto : IComparable {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto(int codigo, string descricao, double preco) {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        public override string ToString() {
            return this.Codigo
                + ", "
                + this.Descricao
                + ", "
                + this.Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) {
            Produto outro = (Produto)obj;
            int resultado = this.Descricao.CompareTo(outro.Descricao);

            if (resultado == 0) {
                resultado = -this.Preco.CompareTo(outro.Preco);
            }

            return resultado;
        }
    }
}
