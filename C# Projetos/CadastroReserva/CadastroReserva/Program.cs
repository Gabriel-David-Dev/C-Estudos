using CadastroReserva.Entities;
using Course.Entities.Exceptions;

namespace CadastroReserva
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número do quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                Console.Write("Data de CheckIn (dd/MM/aaaa): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de CheckOut (dd/MM/aaaa): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(numeroQuarto, checkIn, checkOut);

                Console.WriteLine(reserva);
                Console.WriteLine();


                Console.Write("Deseja atualizar a reserva (s/n): ");
                char resposta = char.Parse(Console.ReadLine().ToLower());
                Console.WriteLine();
                if (resposta == 's')
                {
                    Console.WriteLine("Entre com os dados para atualizar a reserva:");
                    Console.Write("Data de CheckIn (dd/MM/aaaa): ");
                    checkIn = DateTime.Parse(Console.ReadLine());
                    Console.Write("Data de CheckOut (dd/MM/aaaa): ");
                    checkOut = DateTime.Parse(Console.ReadLine());
                }

                reserva.AtualizarReserva(checkIn, checkOut);
                Console.WriteLine(reserva);

            }
            catch (FormatException erro) 
            {
                Console.WriteLine("Erro no formato: " + erro.Message);
            }
            catch (DomainException erro)
            {
                Console.WriteLine("Erro na reserva: " + erro.Message);
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro inesperado: " + erro.Message);
            }
        }
    }
}
