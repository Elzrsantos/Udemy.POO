using System;
using System.Globalization;

namespace Udemy.POO.Sessao02.Exercicio01 {
    class Retangulo {
        public double largura;
        public double altura;

        public double area() {
            return largura * altura;
        }

        public double perimetro() {
            return 2 * (largura + altura);
            
        }

        public double diagonal() {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }
    }
}