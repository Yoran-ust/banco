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

        }
    }
}
