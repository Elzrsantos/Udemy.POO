using System;
using System.Globalization;

namespace Udemy.POO.Sessao02.Exercicio02 {
    class Funcionario {

        public string nome;
        public double salarioBruto;
        public double desconto;

        public double salarioLiquido() {
            return this.salarioBruto - this.desconto;
        }

        public void aumentarSalario(double porcentagem) {
            this.salarioBruto += salarioBruto * (porcentagem / 100);
        }

        public override string ToString() {
            return nome
                + ", R$ "
                + this.salarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}