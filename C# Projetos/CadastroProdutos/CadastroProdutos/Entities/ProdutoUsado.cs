namespace CadastroProdutos.Entities
{
    internal class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao)
            : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string TagDePreco()
        {
            return $"{Nome} (usado) R${Preco.ToString("F2")}" +
                $" (Data de fabricação: {DataFabricacao.ToString("dd/MM/yyyy")})";
        }
    }
}
