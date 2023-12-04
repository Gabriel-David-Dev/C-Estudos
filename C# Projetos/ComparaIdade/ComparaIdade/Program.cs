using ComparaIdade.Entities;
using ComparaIdade.Services;

namespace ComparaIdade
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<Pessoa> pessoas = new List<Pessoa>();
                for (int contador = 1; contador <= 2; contador++)
                {
                    Console.Write($"Digite o nome da {contador}° pessoa: ");
                    string nome = Console.ReadLine();
                    Console.Write($"Digite a idade da {contador}° pessoa: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Pessoa pessoa = new Pessoa(nome, idade);
                    pessoas.Add(pessoa);

                }

                string resultado = VerificaIdadeServices.MaisVelha(pessoas[0], pessoas[1]);

                Console.WriteLine($"Pessoa mais velha: {resultado}");
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro: {erro.Message}");
            }
        }
    }
}
