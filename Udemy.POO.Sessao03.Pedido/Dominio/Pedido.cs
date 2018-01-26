using System;
using System.Collections.Generic;
using System.Globalization;

namespace Udemy.POO.Sessao03.Exercicio06.Dominio {
    class Pedido {
        public int Codigo { get; set;  }
        public DateTime Data { get; set; }
        public List<ItemPedido> Itens { get; set; }

        public Pedido(int codigo, int dia, int mes, int ano) {
            this.Codigo = codigo;
            this.Data = new DateTime(ano, mes, dia);
            Itens = new List<ItemPedido>();
        }

        public double ValorTotal() {
            double soma = 0;

            for (int i = 0; i < Itens.Count; i++) {
                soma += Itens[i].SubTotal();
            }

            return soma;
        }

        public override string ToString() {
            string s = "Pedido: " + this.Codigo
                + ", data: " + this.Data.Day + "/" + this.Data.Month + "/" + this.Data.Year + "\n"
                + "Itens: \n";

            for (int i = 0; i < this.Itens.Count; i++) {
                s += this.Itens[i] + "\n";
            }

            s += "Total do pedido: " + this.ValorTotal().ToString("F2", CultureInfo.InvariantCulture);

            return s;
        }
    }
}
