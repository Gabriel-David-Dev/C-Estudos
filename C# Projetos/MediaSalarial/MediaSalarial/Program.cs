using MediaSalarial.Entities;
using MediaSalarial.Services;
using System.Globalization;

namespace MediaSalarial
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Funcionario> funcionarios = new List<Funcionario>();

            try
            {
                for (int contador = 1; contador <= 2; contador++)
                {
                    Console.Write($"Digite o nome do {contador}° funcionário: ");
                    string nome = Console.ReadLine();
                    Console.Write($"Digite o salário do {contador}° funcionário: ");
                    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();

                    Funcionario funcionario = new Funcionario(nome, salario);
                    funcionarios.Add(funcionario);
                }

                double media = MediaSalario.Media(funcionarios[0].Salario, funcionarios[1].Salario);

                Console.WriteLine($"Salário médio: {media.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro: {erro.Message}");
            }

        }
    }
}
