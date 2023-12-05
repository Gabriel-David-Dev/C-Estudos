using AprovaAluno.Entidades;
using AprovaAluno.Services;
using System.Globalization;

namespace AprovaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nome do aluno: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite as três notas do aluno:");

                List<double> notas = new List<double>();

                for (int contador = 1; contador <= 3; contador++)
                {
                    Console.Write($"{contador}° nota: ");
                    double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    notas.Add(nota);
                }

                Aluno aluno = new Aluno(nome, notas[0], notas[1], notas[2]);

                double media = MediaNotaServices.Media(aluno.PrimeiraNota, aluno.SegundaNota, aluno.TerceiraNota);

                Console.WriteLine($"Nota final: {media.ToString("F2", CultureInfo.InvariantCulture)}");
                if (media >= 6)
                {
                    Console.WriteLine("APROVADO");
                }
                else
                {
                    double pontosFaltantes = 6 - media;
                    Console.WriteLine("REPROVADO");
                    Console.WriteLine($"FALTARAM: {pontosFaltantes.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro: {erro.Message}");
            }

        }
    }
}
