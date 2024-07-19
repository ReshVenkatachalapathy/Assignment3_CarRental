/* Developer: Reshma Venkatachalapathy
 * Date:27-06-2024
 * Description: This task is the rental agency class used for storing the available vehicles, add/ remove vehicle and calculate the revenues*/



using System;

public class RentalAgency
{
    // Properties
    private List<Vehicle> Fleet { get; set; }
    public decimal TotalRevenue { get; private set; }

    // Constructor
    public RentalAgency()
    {
        Fleet = new List<Vehicle>();
        TotalRevenue = 0;
    }

    // Method to add vehicles to the fleet
    public void AddVehicle(Vehicle vehicle)
    {
        Fleet.Add(vehicle);
    }

    // Method to remove vehicles from the fleet
    public void RemoveVehicle(Vehicle vehicle)
    {
        Fleet.Remove(vehicle);
    }

    // Method to rent a vehicle
    public void RentVehicle(Vehicle vehicle)
    {
        Fleet.Remove(vehicle); // Simulate renting by removing from fleet
        TotalRevenue += vehicle.RentalPrice; // Increase total revenue
    }

    // Method to display all vehicles in the fleet
    public void DisplayFleet()
    {
        foreach (var vehicle in Fleet)
        {
            vehicle.DisplayDetails();
            Console.WriteLine();
        }
    }
}
