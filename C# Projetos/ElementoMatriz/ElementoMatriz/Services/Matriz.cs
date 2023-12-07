namespace ElementoMatriz.Services
{
    internal class Matriz
    {
        // Metodo para criar e preencher a matriz
        public static int[,] CriaMatriz(int linhas, int colunas)
        {
            int[,] matriz = new int[linhas, colunas];

            for (int contador = 0; contador < linhas; contador++)
            {
                string[] numeros = Console.ReadLine().Split(' ');

                for (int cont = 0; cont < colunas; cont++)
                {
                    matriz[contador, cont] = int.Parse(numeros[cont]);
                }
            }

            return matriz;
        }

        // Metodo para mostrar os elementos dado a escolha do usuario
        public static void ExibeEscolha(int[,] matriz, int escolha)
        {

            for (int contador = 0; contador < matriz.GetLength(0); contador++)
            {
                for (int cont = 0; cont < matriz.GetLength(1); cont++)
                {
                    if (matriz[contador, cont] == escolha)
                    {
                        Console.WriteLine($"Posição - Linha {contador}, Coluna {cont}:");
                        if (cont > 0)
                        {
                            Console.WriteLine($"Elemento a esquerda: {matriz[contador, cont - 1]}");
                        }
                        if (cont < matriz.GetLength(1) - 1)
                        {
                            Console.WriteLine($"Elemento a direita: {matriz[contador, cont + 1]}");
                        }
                        if (contador > 0)
                        {
                            Console.WriteLine($"Elemento acima: {matriz[contador - 1, cont]}");
                        }
                        if (contador < matriz.GetLength(0) - 1)
                        {
                            Console.WriteLine($"Elemento abaixo: {matriz[contador + 1, cont]}");
                        }

                        Console.WriteLine();
                    }

                }
            }
        }
    }
}
