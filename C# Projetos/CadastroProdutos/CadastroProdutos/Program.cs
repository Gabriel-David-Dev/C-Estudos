using CadastroProdutos.Entities;

namespace CadastroProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Recebe a quantidade de produtos a serem cadastros e cria uma lista
                Console.Write("Entre com a quantidade de produtos: ");
                int qtdProdutos = int.Parse(Console.ReadLine());
                Console.WriteLine();

                List<Produto> produtos = new List<Produto>();

                // Recebe dados dos produtos a serem cadastrados
                for (int contador = 1; contador <= qtdProdutos; contador++)
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"Dados do {contador}° produto:");
                    Console.Write("Comum, usado ou importado (c/u/i): ");
                    char resposta = char.Parse(Console.ReadLine().ToLower());
                    resposta = Produto.ValidaTipoProduto(resposta); // Método que valida a escolha do produto
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço: R$");
                    double preco = double.Parse(Console.ReadLine());
                    // Verifica qual o "tipo do produto" e cadastra corretamente
                    switch (resposta)
                    {
                        case 'c':
                            produtos.Add(new Produto(nome, preco));
                            break;
                        case 'u':
                            Console.Write("Data de Fabricação (DD/MM/AAAA): ");
                            DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                            produtos.Add(new ProdutoUsado(nome, preco, dataFabricacao));
                            break;
                        case 'i':
                            Console.Write("Taxa Alfandega: R$");
                            double taxaAlfandega = double.Parse(Console.ReadLine());
                            produtos.Add(new ProdutoImportado(nome, preco, taxaAlfandega));
                            break;
                    }
                    Console.WriteLine("----------------------------------");

                }

                // Exibe os produtos cadastrados, informação conforme seu tipo e o preço
                Console.WriteLine();
                Console.WriteLine("TAGS DE PREÇO:");
                foreach (Produto produto in produtos)
                {
                    Console.WriteLine(produto.TagDePreco());
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Aconteceu um ERRO: {erro.Message}");
            }
        }
    }
}
