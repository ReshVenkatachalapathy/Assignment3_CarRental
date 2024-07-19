/* Developer: Reshma Venkatachalapathy
 * Date:27-06-2024
 * Description: This task is the car class used for storing the basic properties of car like total no of seates, engine details, automatic or manual etc */



using System;

public class Car : Vehicle
{
    public int Seats { get; set; }
    public string EngineType { get; set; }
    public string Transmission { get; set; }
    public bool Convertible { get; set; }

    public Car(string manufacturer, string model, int year, decimal rentalPrices, 
		int seats, string engineType, string transmission, bool convertible) : base(model, manufacturer, year, rentalPrices)

	{
        Seats = seats;
        EngineType = engineType;
        Transmission = transmission;
        Convertible = convertible;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Total seats: {Seats}");
        Console.WriteLine($"Engine Type: {EngineType}");
        Console.WriteLine($"Transmission details: {Transmission}");
        Console.WriteLine($"Is it convertible: {(Convertible ? "Yes" : "No")}");
    }






}
