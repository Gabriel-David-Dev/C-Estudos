using CadastroPedido.Entities;
using CadastroPedido.Entities.Enums;

namespace CadastroPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Recebe os dados do cliente e cria um cliente
                Console.WriteLine("Entre com os dados do cliente:");
                Console.WriteLine("--------------------------------");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Data Nascimento (DD/MM/AAAA): ");
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------");

                Cliente cliente = new Cliente(nome, email, dataNascimento);

                // Recebe os dados do pedido e cria uma lista de itens
                Console.WriteLine("Entre com os dados do pedido:");
                Console.Write("Status: ");
                StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());
                Console.Write("Quantos produtos para esse pedido: ");
                int qtdProdutos = int.Parse(Console.ReadLine());
                Console.WriteLine();

                List<ItemPedido> itens = new List<ItemPedido>();

                // Cadastra os produtos e armazena na lista
                for (int contador = 1; contador <= qtdProdutos; contador++)
                {
                    Console.WriteLine($"Entre com os dados do #{contador}° produto:");
                    Console.Write("Nome produto: ");
                    string nomeProduto = Console.ReadLine();
                    Console.Write("Preço produto: R$");
                    double precoProduto = double.Parse(Console.ReadLine());

                    Produto produto = new Produto(nomeProduto, precoProduto);

                    Console.Write("Quantidade: ");
                    int qtdProduto = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    itens.Add(new ItemPedido(qtdProduto, precoProduto, produto));

                }

                // Cria um pedido com os produtos cadastrados, a hora da compra e os dados do cliente
                Pedido pedido = new Pedido(DateTime.Now, status, cliente);

                foreach (ItemPedido item in itens)
                {
                    pedido.AddItem(item);
                }

                // Exibe um recibo
                Console.WriteLine("--------------------------------");
                Console.WriteLine(pedido);
                Console.WriteLine("Itens do pedido:");
                foreach (ItemPedido item in itens)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Preço total: R${pedido.Total().ToString("F2")}");
                Console.WriteLine("--------------------------------");
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Aconteceu um ERRO: {erro.Message}");
            }    
        }
    }
}
