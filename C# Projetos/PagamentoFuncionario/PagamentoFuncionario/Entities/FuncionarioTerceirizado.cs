namespace PagamentoFuncionario.Entities
{
    internal class FuncionarioTerceirizado : Funcionario
    {
        public double PagamentoAdicional { get; set; }

        public FuncionarioTerceirizado(string nome, int horas, double valorPorHora, double pagamentoAdicional)
            : base(nome, horas, valorPorHora)
        {
            PagamentoAdicional = pagamentoAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + PagamentoAdicional;
        }
    }
}
