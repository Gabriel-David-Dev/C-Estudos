using System.Globalization;

namespace ContaBancaria.Entities
{
    internal class Cliente
    {
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }

        public Cliente(int numeroConta, string titularConta, double saldo) 
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        // É permitido ficar com saldo negativo apenas contando com a taxa de saque.
        public void Saque(double valor)
        {
            double taxa = 5.0;
            if (valor <= Saldo)
            {
                Saldo -= (valor + taxa);
            }
            else
            {
                Console.WriteLine("Valor Insuficiente !");
            }
        }

        public void ExibirDados(string mensagem, Cliente cliente)
        {
            Console.WriteLine();
            Console.WriteLine(mensagem);
            Console.WriteLine(cliente);
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {TitularConta}, " +
                $"Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
