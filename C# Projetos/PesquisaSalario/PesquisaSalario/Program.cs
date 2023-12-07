using PesquisaSalario.Entities;
using PesquisaSalario.Enums;

namespace PesquisaSalario
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o nome do departamento: ");
            string departamentoNome = Console.ReadLine();

            Departamento departamento = new Departamento(departamentoNome);

            Console.WriteLine("Dados do funcionário: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nivel (Junior/MidLevel/Senior): ");
            NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
            Console.Write("Salário base: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Trabalhador trabalhador = new Trabalhador(nome, nivel, salario, departamento);

            Console.Write("Quantos contratos esse trabalhador tem: ");
            int quantidadeContratos = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= quantidadeContratos; contador++)
            {
                Console.WriteLine($"Entre com os dados do {contador}° contrato: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Value por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("Duração (horas): ");
                int totalHoras = int.Parse(Console.ReadLine());

                trabalhador.AddContrato(new ContratoHoras(data, valorPorHora, totalHoras));
                Console.WriteLine();
            }

            Console.Write("Digite o mês e o ano para calcular o salário (MM/YYYY): ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));
            Console.WriteLine($"Nome: {trabalhador.Nome}");
            Console.WriteLine($"Departamento: {departamento.Nome}");
            Console.WriteLine($"Renda na data: {mesAno}: {trabalhador.Renda(mes, ano).ToString("F2")}");

        }
    }
}
