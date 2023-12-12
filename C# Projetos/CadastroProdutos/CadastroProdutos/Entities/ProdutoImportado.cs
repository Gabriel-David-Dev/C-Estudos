namespace CadastroProdutos.Entities
{
    internal class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; set; }

        public ProdutoImportado(string nome, double preco, double taxaAlfandega)
            : base(nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public double PrecoTotal()
        {
            return Preco + TaxaAlfandega;
        }

        public override string TagDePreco()
        {
            return $"{Nome} R${PrecoTotal().ToString("F2")}" +
                $" (Taxa Alfandega: R${TaxaAlfandega.ToString("F2")})";
        }
    }
}
