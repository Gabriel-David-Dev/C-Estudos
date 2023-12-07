namespace VarrendoMatriz.Services
{
    internal class Matriz
    {
        // Metódo para criação e preenchimento da matriz
        public static int[,] CriaMatriz(int numero1, int numero2)
        {
            int[,] matriz = new int[numero1, numero2];

            for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int colunas = 0; colunas < matriz.GetLength(1); colunas++)
                {
                    matriz[linhas, colunas] = int.Parse(valores[colunas]);
                }
            }
            return matriz;
        }
        
        // Metódo para saída de dados, exibindo a diagonal principal e os números negativos
        public static void ExibirMatriz(int[,] matriz)
        {
            Console.WriteLine();
            int somaNegativos = 0;
            Console.WriteLine("Main diagonal:");

            for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < matriz.GetLength(1); colunas++)
                {
                    if (linhas == colunas)
                    {
                        Console.Write($"{matriz[linhas, colunas]} ");
                    }
                    if (matriz[linhas, colunas] < 0)
                    {
                        somaNegativos++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Negative numbers: {somaNegativos}");

        }
    }
}
