using PagamentoFuncionario.Entities;
using System;

namespace PagamentoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Cria uma lista de funcionários
                Console.Write("Entre com o número de funcionários: ");
                int qtdFuncionarios = int.Parse(Console.ReadLine());

                List<Funcionario> funcionarios = new List<Funcionario>();
                Console.WriteLine();

                // Preenche a lista com os dados dos funcionários
                for (int contador = 1; contador <= qtdFuncionarios; contador++)
                {
                    Console.WriteLine($"Dados do {contador}° funcionário:");
                    Console.Write("Terceirizado (s/n): ");
                    char resposta = char.Parse(Console.ReadLine().ToLower());
                    resposta = Funcionario.ValidaTerceirizado(resposta); // Metodo que válida a resposta
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Horas: ");
                    int horas = int.Parse(Console.ReadLine());
                    Console.Write("Valor por hora: R$");
                    double valorPorHora = double.Parse(Console.ReadLine());

                    // Verifica se o funcionário é terceirizado ou não e o adiciona a lista de funcionários
                    double pagamentoAdicional = 0;
                    if (resposta == 's')
                    {
                        Console.Write("Pagamento adicional: R$");
                        pagamentoAdicional = double.Parse(Console.ReadLine());
                        funcionarios.Add(new FuncionarioTerceirizado(nome, horas, valorPorHora, pagamentoAdicional));
                    }
                    else
                    {
                        funcionarios.Add(new Funcionario(nome, horas, valorPorHora));
                    }
                    Console.WriteLine("-----------------------------------------");
                }

                // Exibe os funcionários na lista e o respectivo pagamento
                Console.WriteLine("PAGAMENTOS:");
                foreach (Funcionario funcionario in funcionarios)
                {
                    Console.WriteLine(funcionario);
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Ocorreu um ERRO: {erro.Message}");
            }
        }
    }
}