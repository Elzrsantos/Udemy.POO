using System.Globalization;

namespace Udemy.POO.Sessao03.Exercicio04 {
    class Funcionario {
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int cpf, string nome, double salario) {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Salario = salario;
        }

        public void aumentarSalario(double porcentagem) {
            this.Salario += this.Salario * (porcentagem / 100);
        }

        public override string ToString() {
            return this.Cpf.ToString()
                + ", "
                + this.Nome
                + ", "
                + this.Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
