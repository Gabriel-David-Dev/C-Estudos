namespace CadastraPessoaCalculaImposto.Entities
{
    internal class PessoaFisica : Contribuinte
    {
        public double GastosMedicos { get; set; }

        public PessoaFisica(string nome, double ganhosAnuais, double gastosMedicos)
            : base(nome, ganhosAnuais)
        {
            GastosMedicos = gastosMedicos;
        }

        public override double Imposto()
        {

            double pagamento = 0;

            if (GanhosAnuais < 20000)
            {
                pagamento = GanhosAnuais * 0.15;
                if (GastosMedicos > 0)
                {
                    pagamento += - GastosMedicos / 2;
                    return pagamento;
                }
                else
                {
                    return pagamento;
                }
            }
            else
            {
                pagamento = GanhosAnuais * 0.25;
                if (GastosMedicos > 0)
                {
                    pagamento += - GastosMedicos / 2;
                    return pagamento;
                }
                else
                {
                    return pagamento;
                }
            }
        }
    }
}
