﻿using System;
using Aula206.Entities;
using System.Globalization;
using Aula206.Services;

namespace Aula206
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter rental data");
                Console.Write("Car model: ");
                string model = Console.ReadLine();
                Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
                DateTime start = DateTime.ParseExact(Console.ReadLine(),
                    "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                Console.Write("Return (dd/MM/yyyy hh:mm): ");
                DateTime finish = DateTime.ParseExact(Console.ReadLine(),
                    "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                Console.Write("Enter price per hour: ");
                double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter price per day: ");
                double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                CarRental carRental = new CarRental(start, finish, new Vehicle(model));
                RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());

                rentalService.ProcessInvoice(carRental);

                Console.WriteLine();
                Console.WriteLine("INVOICE:");
                Console.WriteLine(carRental.Invoice);
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
            
        }
    }
}
