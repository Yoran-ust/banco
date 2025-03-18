using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BancoPOO
{
    public class ContaBancaria
    {
        private string _Titular { set; get; }
        private int _NumeroConta {set; get; }
        private double _Saldo { set; get; }
        
        public ContaBancaria(int numeroConta, string titular, double saldo)
        {
            _NumeroConta = numeroConta;
            _Titular = titular;
            _Saldo = saldo;
        }
        public double Sacar(double valor)
        {
      
            // ExibirSaldo(): exibe o saldo atual.
            Console.WriteLine($"Saldo {_Saldo}");
            //Criar duas classes filhas que herdam de ContaBancaria e possuem regras
            return _Saldo;
        }
        public double Depositar() 
        {
            return 0; 
        } 
       
    }
    
}
