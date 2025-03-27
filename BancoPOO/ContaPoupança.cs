using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPOO
{

    public class ContaPoupança : ContaBancaria
    {
        public ContaPoupança(int numeroConta, string Titular, double saldoInicial) : base(numeroConta, Titular, saldoInicial)
        {
        }

    }
}
