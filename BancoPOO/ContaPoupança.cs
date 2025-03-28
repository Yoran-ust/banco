using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPOO
{

    public class ContaPoupança : ContaBancaria
    {
        private const double BonusDeposito = 0.005; 
        public ContaPoupança(int numeroConta, string Titular, double saldoInicial) : base(numeroConta, Titular, saldoInicial)
        {
        }
        public override double Depositar(double valor)
        {
            double valorComBonus = valor + (valor * BonusDeposito);
            Saldo += valorComBonus;
            Console.WriteLine($"Depósito de R${valor} realizado com bônus de 0.5%. Valor total com bônus: R${valorComBonus}");
            return Saldo;
        }

    }
}
