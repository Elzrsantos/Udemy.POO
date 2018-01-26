using System;
using System.Globalization;

namespace Udemy.POO.Sessao03.Exercicio01 {
    class Program {
        public static NumberStyles Cul { get; private set; }

        static void Main(string[] args) {

            Conta conta;

            Console.Write("Digite o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string nomeDoTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?: ");
            string haveraDepositoInicial = Console.ReadLine();

            if (haveraDepositoInicial == "s") {
                Console.Write("Digite o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new Conta(numeroDaConta, nomeDoTitular, depositoInicial);
            }
            else {
                conta = new Conta(numeroDaConta, nomeDoTitular);
            }
            
            Console.WriteLine();

            Console.WriteLine("Conta criada:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Digite um valor para depósito: ");
            conta.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Conta atualizada:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Digite um valor para saque: ");
            conta.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Conta atualizada:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
