using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPOO
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numeroConta, string Titular, double saldoInicial) : base(numeroConta, Titular, saldoInicial)
        {
            Taxasaque = 5.00;
        }
        public override double Sacar(double valor)
        {
            if (valor > 0 && valor + Taxasaque <= Saldo)
            {
                Saldo -= (valor + Taxasaque);
                Console.WriteLine($"Saque de R${valor} realizado. Taxa de R${Taxasaque} aplicada.");
            }
            else
            {
                Console.WriteLine("Saque não autorizado. Verifique saldo e taxa.");
            }
            return Saldo;
        }

    }
}
