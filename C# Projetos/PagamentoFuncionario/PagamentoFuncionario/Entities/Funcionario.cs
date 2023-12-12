namespace PagamentoFuncionario.Entities
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public Funcionario(string nome, int horas, double valorPorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        public static char ValidaTerceirizado(char resposta)
        {
            while (resposta != 's' && resposta != 'n')
            {
                Console.WriteLine("Opção inválida, tente novamente!");
                Console.Write("Terceirizado (s/n): ");
                resposta = char.Parse(Console.ReadLine().ToLower());
            }

            return resposta;
        }

        public virtual double Pagamento()
        {
            return ValorPorHora * Horas;
        }

        public override string ToString()
        {
            return $"{Nome} - R${Pagamento().ToString("F2")}";
        }
    }
}
