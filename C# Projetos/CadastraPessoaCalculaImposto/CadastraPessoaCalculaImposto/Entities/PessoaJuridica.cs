namespace CadastraPessoaCalculaImposto.Entities
{
    internal class PessoaJuridica : Contribuinte
    {
        public int QuantidadeFuncionarios { get; set; }

        public PessoaJuridica(string nome, double ganhosAnuais, int quantidadeFuncionarios)
            : base(nome, ganhosAnuais)
        {
            QuantidadeFuncionarios = quantidadeFuncionarios;
        }

        public override double Imposto()
        {
            if (QuantidadeFuncionarios < 10)
            {
                return GanhosAnuais * 0.16;
            }
            else
            {
                return GanhosAnuais * 0.14;
            }
        }
    }
}
