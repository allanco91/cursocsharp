using System.Globalization;

namespace Course2
{
    class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int conta, string titular, double depositoInicial) : this(conta, titular)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return $"Conta {Conta}, Titular {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
