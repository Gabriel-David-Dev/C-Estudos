using System;
using AlugaQuarto.Entities;

namespace AlugaQuarto
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Estudante> estudantes = new List<Estudante>();

            int[] quartos = new int[10];

            try
            {
                Console.Write("Quantos quartos serão alugados: ");
                int qtdQuartos = int.Parse(Console.ReadLine());

                for (int contador = 1; contador <= qtdQuartos; contador++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Aluguel #{contador}:");
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Quarto: ");
                    int quarto = int.Parse(Console.ReadLine());
                    quartos[quarto] = quarto;

                    Estudante estudante = new Estudante(nome, email, quartos[quarto]);
                    estudantes.Add(estudante);
                }

                estudantes.Sort((a, b) => a.Quarto.CompareTo(b.Quarto));

                Console.WriteLine();
                Console.WriteLine("Quartos ocupados:");
                foreach (Estudante estudante in estudantes)
                {
                    Console.WriteLine(estudante);
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Ocorreu um ERRO: {erro.Message}");
            }
        }
    }
}
