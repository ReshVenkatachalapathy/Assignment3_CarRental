// See https://aka.ms/new-console-template for more information

/* Developer: Reshma Venkatachalapathy
 * Date:27-06-2024
 * Description: This task is the main class used for calling the other classes and passing the respective values*/


using System;
using System.Diagnostics;
using System.Threading;
using System.Xml.Linq;


class Program
{
   public static void Main(string[] args)
    {   // Example usage
        // Creating instances of vehicles
        Car car1 = new Car("Model S", "Tesla", 2023, 150.00m, 5, "Electric", "Automatic", true);
        Truck truck1 = new Truck("F-150", "Ford", 2022, 100.00m, 4, "Pickup", true);
        Motorcycle bike1 = new Motorcycle("Ninja 300", "Kawasaki", 2021, 50.00m, 300, "Gasoline", true);

        // Creating rental agency and adding vehicles
        RentalAgency agency = new RentalAgency();
        agency.AddVehicle(car1);
        agency.AddVehicle(truck1);
        agency.AddVehicle(bike1);

        // Displaying fleet details
        Console.WriteLine("Current Fleet:");
        agency.DisplayFleet();

        // Renting a vehicle
        Console.WriteLine("\nRenting a vehicle...");
        agency.RentVehicle(car1);

        // Displaying fleet details after renting
        Console.WriteLine("\nUpdated Fleet:");
        agency.DisplayFleet();

        // Displaying total revenue
        Console.WriteLine($"\nTotal Revenue: {agency.TotalRevenue:C}");
    }

}

