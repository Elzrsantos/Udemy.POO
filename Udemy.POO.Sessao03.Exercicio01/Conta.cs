using System.Globalization;

namespace Udemy.POO.Sessao03.Exercicio01 {
    class Conta {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        #region Construtores
        public Conta(int numero, string nome) {
            this.Numero = numero;
            this.Nome = nome;
        }

        public Conta(int numero, string nome, double depositoInicial) {
            this.Numero = numero;
            this.Nome = nome;
            this.Saldo = depositoInicial;
        }
        #endregion

        public void Depositar(double valor) {
            this.Saldo += valor;
        }

        public void Sacar(double valor) {
            this.Saldo -= (valor + 5.00);
        }

        public override string ToString() {
            return "Conta "
                + this.Numero
                + ", Titular: "
                + this.Nome
                + ", Saldo: $ "
                + this.Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
