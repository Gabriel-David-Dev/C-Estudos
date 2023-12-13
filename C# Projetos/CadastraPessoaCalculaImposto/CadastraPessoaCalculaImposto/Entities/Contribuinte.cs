namespace CadastraPessoaCalculaImposto.Entities
{
    internal abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double GanhosAnuais { get; set; }

        public Contribuinte(string nome, double ganhosAnuais)
        {
            Nome = nome;
            GanhosAnuais = ganhosAnuais;
        }

        public static char ValidaContribuinte(char resposta)
        {
            while(resposta != 'f' && resposta != 'j')
            {
                Console.WriteLine("Opção inválida. Escolha novamente!");
                Console.Write($"Pessoa Fisica ou Juridica (f/j): ");
                resposta = char.Parse(Console.ReadLine().ToLower());
            }

            return resposta;
        }

        public abstract double Imposto();

        public override string ToString()
        {
            return $"{Nome}: R${Imposto().ToString("F2")}";
        }
    }
}
