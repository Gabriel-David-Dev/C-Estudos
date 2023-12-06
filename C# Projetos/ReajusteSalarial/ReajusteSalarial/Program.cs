using ReajusteSalarial.Entities;

namespace ReajusteSalarial
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Quantos funcionários vão ser registrados: ");
                int qtdFuncionario = int.Parse(Console.ReadLine());

                List<Funcionario> funcionarios = new List<Funcionario>();
                List<int> ids = new List<int>();

                for (int contador = 1; contador <= qtdFuncionario; contador++)
                {
                    Console.WriteLine($"Funcionário #{contador}");
                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine());
                    while (true)
                    {
                        if (ids.Contains(id))
                        {
                            Console.WriteLine("Esse ID já está registrado. Cadastre um ID diferente!");
                            Console.Write("Id: ");
                            id = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            ids.Add(id);
                            break;
                        }
                    }

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Salário: ");
                    double salario = double.Parse(Console.ReadLine());

                    funcionarios.Add(new Funcionario(id, nome, salario));
                    Console.WriteLine();
                }
                funcionarios.Sort((a, b) => a.Id.CompareTo(b.Id));

                Console.Write("Digite o ID do funcionário que vai receber o aumento: ");
                int idFunc = int.Parse(Console.ReadLine());
                if (!ids.Contains(idFunc))
                {
                    Console.WriteLine("Esse ID não existe !");
                }
                else
                {
                    Console.Write("Porcentagem de aumento: ");
                    double porcentagem = double.Parse(Console.ReadLine());
                    foreach (Funcionario funcionario in funcionarios)
                    {
                        if (idFunc == funcionario.Id)
                        {
                            funcionario.AumentarSalario(porcentagem);
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Lista atualizada de funcionários: ");
                foreach (Funcionario funcionario in funcionarios)
                {
                    Console.WriteLine(funcionario);
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Ocorreu um erro: {erro.Message}");
            }

        }
    }
}
