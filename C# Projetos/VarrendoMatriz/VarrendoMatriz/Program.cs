using VarrendoMatriz.Services;

namespace VarrendoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                // Entrada de dados, criação e preenchimento da matriz
                Console.Write("Entre com a quantidade de linhas da matriz: ");
                int linhas = int.Parse(Console.ReadLine());
                Console.Write("Entre com a quantidade de colunas da matriz: ");
                int colunas = int.Parse(Console.ReadLine());

                int[,] matriz = Matriz.CriaMatriz(linhas, colunas);

                //  Exibir a matriz formatada
                Matriz.ExibirMatriz(matriz);

            }
            catch (Exception erro)
            {
                Console.WriteLine($"Aconteceu um erro: {erro.Message}");
            }
        }
    }
}
