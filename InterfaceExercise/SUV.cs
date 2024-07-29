using System;

namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    
    public int NumberOfWheels { get; set; }
    public string FuelType { get; set; }
    public int MaximumSpeed { get; set; }
    public bool IsElectric { get; set; }

    
    public string CompanyName { get; set; }
    public string Logo { get; set; }

   
    public int NumberOfSeats { get; set; }
    public bool HasSunroof { get; set; }

  
    public void DisplayDetails()
    {
        Console.WriteLine($"SUV Details:");
        Console.WriteLine($"Company: {CompanyName}");
        Console.WriteLine($"Logo: {Logo}");
        Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        Console.WriteLine($"Fuel Type: {FuelType}");
        Console.WriteLine($"Maximum Speed: {MaximumSpeed} km/h");
        Console.WriteLine($"Electric: {IsElectric}");
        Console.WriteLine($"Number of Seats: {NumberOfSeats}");
        Console.WriteLine($"Has Sunroof: {HasSunroof}");
        Console.WriteLine();
    }
}


