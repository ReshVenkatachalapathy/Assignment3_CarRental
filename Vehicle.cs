using System;

public class Vehicle
{
    public String Model { get; set; }
    public String Manufacturer { get; set; }
    public int Year { get; set; }
    public int RentalPrices { get; set; }


    public Vehicle(string manufacturer, string model, int year, int rentalPrices)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
        RentalPrices = rentalPrices;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Vehicle Make: {this.Manufacturer}");
        Console.WriteLine($"Vehicle Make: {this.Model}");
        Console.WriteLine($"Vehicle Make: {this.Year}");
        Console.WriteLine($"Vehicle Make: {this.RentalPrices}");
    }

}