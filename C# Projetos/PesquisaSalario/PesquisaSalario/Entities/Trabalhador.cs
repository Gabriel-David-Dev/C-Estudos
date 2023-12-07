using PesquisaSalario.Enums;

namespace PesquisaSalario.Entities
{
    internal class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador NivelTrabalhador { get; set; }
        public double BaseSalary { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoHoras> Contratos { get; private set; } = new List<ContratoHoras>();

        public Trabalhador(string nome, NivelTrabalhador nivelTrabalhador, double baseSalary, Departamento departamento)
        {
            Nome = nome;
            NivelTrabalhador = nivelTrabalhador;
            BaseSalary = baseSalary;
            Departamento = departamento;
        }

        public void AddContrato(ContratoHoras contrato)
        {
            Contratos.Add(contrato);
        }

        public void removeContrato(ContratoHoras contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Renda(int mes, int ano)
        {
            double soma = BaseSalary;
            foreach (ContratoHoras contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }

            return soma;
        }
    }
}
