using System;
using System.Globalization;

namespace Udemy.POO.Sessao03.Exercicio06.Dominio {
    class ItemPedido {
        public int Quantidade { get; set; }
        public double PorcentagemDesconto { get; set; }
        public Produto Produto { get; set; }

        public ItemPedido(int quantidade, double porcentagemDesconto, Produto produto) {
            this.Quantidade = quantidade;
            this.PorcentagemDesconto = porcentagemDesconto;
            this.Produto = produto;
        }

        public double SubTotal() {
            double desconto = this.Produto.Preco * this.PorcentagemDesconto / 100.00;

            return (this.Produto.Preco - desconto) * this.Quantidade;
        }

        public override string ToString() {
            return this.Produto.Descricao
                + ", Preço: "
                + this.Produto.Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Qte: "
                + this.Quantidade.ToString()
                + ", Desconto: "
                + this.PorcentagemDesconto.ToString("F2", CultureInfo.InvariantCulture)
                +"%, Subtotal: "
                + this.SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
