namespace CadastroPedido.Entities
{
    internal class ItemPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public ItemPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            return $"{Produto.Nome}, ${Produto.Preco.ToString("F2")}, " +
                   $"Quantidade: {Quantidade}, SubTotal: ${SubTotal().ToString("F2")}";
        }
    }
}
