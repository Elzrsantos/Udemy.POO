
namespace Udemy.POO.Sessao03.Exercicio02 {
    class Quarto {

        public int QuartoNum { get; set; }
        public Estudante Estudante { get; set; }

        public Quarto(int quartoNum) {
            this.QuartoNum = quartoNum;
        }

        public override string ToString() {
            return this.QuartoNum
                + ": "
                + this.Estudante.Nome
                + ", "
                + this.Estudante.Email;
        }
    }
}
