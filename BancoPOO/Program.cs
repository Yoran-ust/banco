using BancoPOO;
using System;
class Program
{
    static void Main(string[] args)
    {
        int op = -1;
        Console.WriteLine("escolha o tipo da conta ");
        Console.WriteLine("1 - conta corrente");
        Console.WriteLine("2 - conta poupança");
        int tipoConta = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("pressione ENTER");
        Console.ReadLine();

        ContaBancaria contaAtual;
        if (tipoConta == 1)
        {
            contaAtual = new ContaCorrente(1234, "João", 200);
            Console.WriteLine("Conta Corrente criada.");
        }
        else if (tipoConta == 2)
        {
            contaAtual = new ContaPoupança(8546, "Maria", 300);
            Console.WriteLine("Conta Poupança criada.");
        }
        else
        {
            Console.WriteLine("Opção inválida. Programa encerrado.");
            return;
        }

        #region MENU DO BANCO
        while (op != 0)
        {
            Console.WriteLine("======================== MENU BANCO ====================\n");
            Console.WriteLine("1 - fazer saque");
            Console.WriteLine("2 - fazer deposito");
            Console.WriteLine("3 - ver saldo");
            Console.WriteLine("0 - sair");

            Console.WriteLine("======================== POO ====================\n");

            Console.WriteLine("escolha uma opção");


            if (int.TryParse(Console.ReadLine(), out op))
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine("digite o valor para sacar:");
                        double valorSaque = double.Parse(Console.ReadLine());
                        double saldoposSaque = contaAtual.Sacar(valorSaque);
                        Console.WriteLine($"seu saldo atual é {saldoposSaque}");

                        Console.WriteLine($"pressione ENTER");
                        Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine($"seu saldo atual: {saldoposSaque}");

                        Console.WriteLine($"pressione ENTER");
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case 2:

                        Console.WriteLine("digite um valor para depositar");
                        double valorDepositado = double.Parse(Console.ReadLine());
                        double saldoAtualizado = contaAtual.Depositar(valorDepositado);

                        Console.WriteLine($"pressione ENTER");
                        Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine($"seu saldo é {saldoAtualizado}");
                        Console.WriteLine($"pressione ENTER para voltar ao menu");
                        Console.ReadLine();

                        break;
                    case 3:
                        contaAtual.MostrarSaldo();
                        break;
                    case 0:
                        Console.WriteLine("saindo");
                        break;
                }
            }
        }
        #endregion
    }
}
