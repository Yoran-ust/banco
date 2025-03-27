namespace BancoPOO
{
    public class ContaBancaria
    {
        private string _titular;
        private int _numero;
        private double _saldo;
        protected double _taxaSaque;

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        protected double Taxasaque 
        {
            get { return _taxaSaque; }
            set { _taxaSaque = value; }
        }

        public ContaBancaria(int numeroConta, string Titular, double saldoInicial)
        {
            _numero = numeroConta;
            _titular = Titular;
            _saldo = saldoInicial;
        }
        public double Sacar(double valor)
        {
            if (valor> 0 && valor < Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"saque de {valor} realizado.");
            }
            else
            {
                Console.WriteLine("saque não autorizado");
            }
            return Saldo;
        }
        public double Depositar(double valor)
        {
            if (valor > 0)
            {  
                _saldo += valor;
                Console.WriteLine($"Deposito de R${valor} realizadado com sucesso!");
            }
            else
            {
                Console.WriteLine("valor de déposito invalido");
            }
            return Saldo;
        }
        public void MostrarSaldo() 
        {
            Console.WriteLine("=========================================\n");

            Console.WriteLine($"tudo bem {Titular}? seu saldo é {Saldo}\n");

            Console.WriteLine("==============================================\n");

            Console.WriteLine("ENTER PARA VOLTAR AO MENU");
            Console.ReadLine();
            Console.Clear();

        }




    }

}
