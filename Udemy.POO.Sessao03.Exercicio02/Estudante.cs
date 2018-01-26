using System;
using System.Globalization;

namespace Udemy.POO.Sessao03.Exercicio02 {
    class Estudante {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante(string nome, string email) {
            this.Nome = nome;
            this.Email = email;
        }
    }
}
