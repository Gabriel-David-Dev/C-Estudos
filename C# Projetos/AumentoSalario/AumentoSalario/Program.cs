using System.Globalization;
using AumentoSalario.Entities;

namespace AumentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nome do funcionário: ");
                string nome = Console.ReadLine();
                Console.Write("Salário bruto: ");
                double salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Imposto: ");
                double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);

                Console.WriteLine(funcionario);

                Console.Write("Digite a porcentagem para aumentar o salário: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionario.AumentarSalario(porcentagem);

                Console.WriteLine($"Dados atualizados: {funcionario.Nome}, $ " +
                    $"{funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro: {erro.Message}");
            }
            
        }
    }
}
