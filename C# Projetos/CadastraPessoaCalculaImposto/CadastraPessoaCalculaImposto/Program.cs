using CadastraPessoaCalculaImposto.Entities;

namespace CadastraPessoaCalculaImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Recebe a quantidade de contribuintes a serem cadastrados
                // E cria uma lista
                Console.Write("Quantidade de contribuintes: ");
                int qtdContribuintes = int.Parse(Console.ReadLine());
                Console.WriteLine();

                List<Contribuinte> contribuintes = new List<Contribuinte>();

                // Recebe os dados dos contribuintes
                for (int contador = 1; contador <= qtdContribuintes; contador++)
                {
                    Console.WriteLine($"Dados do {contador}° contribuinte:");
                    Console.Write($"Pessoa Fisica ou Juridica (f/j): ");
                    char resposta = char.Parse(Console.ReadLine().ToLower());
                    resposta = Contribuinte.ValidaContribuinte(resposta); // Metodo que valida o tipo de contribuinte
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Ganhos Anuais: R$");
                    double ganhosAnuais = double.Parse(Console.ReadLine());

                    // Verifica o tipo de contribuinte e preenche a lista
                    switch (resposta)
                    {
                        case 'f':
                            Console.Write("Gastos Médicos: R$");
                            double gastosMedicos = double.Parse(Console.ReadLine());
                            contribuintes.Add(new PessoaFisica(nome, ganhosAnuais, gastosMedicos));
                            break;

                        case 'j':
                            Console.Write("Quantidade de funcionários: ");
                            int qtdFuncionarios = int.Parse(Console.ReadLine());
                            contribuintes.Add(new PessoaJuridica(nome, ganhosAnuais, qtdFuncionarios));
                            break;
                    }
                    Console.WriteLine();

                }

                // Exibe quanto o contribuinte tem a pagar de imposto
                // E o total de imposto juntando todos contribuintes
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Imposto a ser pago:");
                double impostoTotal = 0;
                foreach (Contribuinte contribuinte in contribuintes)
                {
                    Console.WriteLine(contribuinte);
                    impostoTotal += contribuinte.Imposto();
                }
                Console.WriteLine($"Imposto total: R${impostoTotal.ToString("F2")}");
            }

            catch (Exception erro)
            {
                Console.WriteLine($"Ocorreu um erro: {erro.Message}");
            }
        }
    }
}
