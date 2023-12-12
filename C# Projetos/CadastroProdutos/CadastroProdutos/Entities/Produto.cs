namespace CadastroProdutos.Entities
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public static char ValidaTipoProduto(char resposta)
        {
            while (resposta != 'c' && resposta != 'u' && resposta != 'i')
            {
                Console.WriteLine("Opção INVÁLIDA! Tente novamente:");
                Console.Write("Comum, usado ou importado (c/u/i): ");
                resposta = char.Parse(Console.ReadLine().ToLower());
            }
            return resposta;
        }

        public virtual string TagDePreco()
        {
            return $"{Nome} R${Preco.ToString("F2")}";
        }
    }
}
