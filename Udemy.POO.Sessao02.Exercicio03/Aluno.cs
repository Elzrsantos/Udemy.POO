using System;
using System.Globalization;

namespace Udemy.POO.Sessao02.Exercicio03 {
    class Aluno {

        public string nome { get; private set; }
        public double nota1 { get; private set; }
        public double nota2 { get; private set; }
        public double nota3 { get; private set; }

        public Aluno(string nome, double nota1, double nota2, double nota3) {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public double NotaFinal() {
            return this.nota1 + this.nota2 + this.nota3;
        }

        public bool Aprovado() {
            if (this.NotaFinal() >= 60.00) {
                return true;
            }

            return false;
        }
        public double Diferenca() {
            return 60.00 - this.NotaFinal();
        }
    }
}
