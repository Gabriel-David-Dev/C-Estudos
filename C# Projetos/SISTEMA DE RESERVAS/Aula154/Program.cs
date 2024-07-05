using Aula154.Entities;
using Aula154.Entities.Exceptions;

namespace Aula154
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number:");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy):");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy):");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy):");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy):");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");
            }
            catch (DomainException error)
            {
                Console.WriteLine($"Domain error: {error.Message}");
            }
            catch (FormatException error)
            {
                Console.WriteLine($"Format error: {error.Message}");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Unexpected error: {error.Message}");
            }

        }

    }
}
