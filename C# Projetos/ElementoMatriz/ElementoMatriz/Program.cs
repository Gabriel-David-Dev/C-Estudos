using ElementoMatriz.Services;

namespace ElementoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                // Cria e preenche matriz
                Console.Write("Entre com a quantidade de linhas: ");
                int linhas = int.Parse(Console.ReadLine());
                Console.Write("Entre com a quantidade de colunas: ");
                int colunas = int.Parse(Console.ReadLine());

                int[,] matriz = Matriz.CriaMatriz(linhas, colunas);

                // Exibe matriz e elementos próximos á um elemento informado
                Console.WriteLine();
                Console.Write("Escolha um dos elementos: ");
                int escolha = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Matriz.ExibeEscolha(matriz, escolha);

            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }


        }
    }
}
