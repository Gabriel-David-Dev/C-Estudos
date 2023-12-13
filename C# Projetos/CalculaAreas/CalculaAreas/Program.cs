using CalculaAreas.Entities.Enums;
using CalculaAreas.Entities;

namespace CalculaAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Recebe a quantidade de formas a serem criadas e cria uma lista
                Console.Write("Entre com a quantidade de formas: ");
                int qtdFormas = int.Parse(Console.ReadLine());
                Console.WriteLine();

                List<Forma> formas = new List<Forma>();

                // Preenche a lista com as formas e seus respectivos dados
                for (int contador = 1; contador <= qtdFormas; contador++)
                {
                    Console.WriteLine($"Dados da {contador}° forma:");
                    Console.Write("Retangulo ou Circulo (r/c): ");
                    char resposta = char.Parse(Console.ReadLine().ToLower());
                    resposta = Forma.ValidaForma(resposta); // Metodo que faz a validação da forma escolhida
                    Console.Write("Cor (Preto/Azul/Vermelho): ");
                    Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                    // Verifica qual a forma, cria um objeto e adiciona na lista geral
                    switch (resposta)
                    {
                        case 'r':
                            Console.Write("Largura: ");
                            double largura = double.Parse(Console.ReadLine());
                            Console.Write("Altura: ");
                            double altura = double.Parse(Console.ReadLine());
                            formas.Add(new Retangulo(cor, largura, altura));
                            break;

                        case 'c':
                            Console.Write("Raio: ");
                            double raio = double.Parse(Console.ReadLine());
                            formas.Add(new Circulo(cor, raio));
                            break;
                    }
                    Console.WriteLine();
                }

                // Exibe as formas e suas areas
                Console.WriteLine("AREA DAS FORMAS:");
                foreach (Forma forma in formas)
                {
                    Console.WriteLine(forma);
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Aconteceu um ERRO: {erro.Message}");
            }
            
        }
    }
}
