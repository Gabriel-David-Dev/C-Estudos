using ContaBancaria.Entities;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número da conta: ");
                int numeroConta = int.Parse(Console.ReadLine());
                Console.Write("Titular da conta: ");
                string titularConta = Console.ReadLine();
                Console.Write("Haverá depósito inicial (s/n): ");
                char resposta = char.Parse(Console.ReadLine().ToLower());

                double depositoInicial = 0.0;
                if (resposta == 's')
                {
                    Console.Write("Valor de depósito inicial: ");
                    depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                Cliente cliente = new Cliente(numeroConta, titularConta, depositoInicial);

                cliente.ExibirDados("Dados da conta", cliente);

                Console.Write("Valor para depósito: ");
                double depositar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cliente.Deposito(depositar);

                cliente.ExibirDados("Dados da conta atualizados", cliente);

                Console.Write("Valor para saque: ");
                double sacar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cliente.Saque(sacar);

                cliente.ExibirDados("Dados da conta atualizados", cliente);
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro: {erro.Message}");
            }
            

        }
    }
}
