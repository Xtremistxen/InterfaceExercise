using System;

namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    // Implement IVehicle members
    public int NumberOfWheels { get; set; }
    public string FuelType { get; set; }
    public int MaximumSpeed { get; set; }
    public bool IsElectric { get; set; }

    // Implement ICompany members
    public string CompanyName { get; set; }
    public string Logo { get; set; }

    // Truck-specific properties
    public int CargoCapacity { get; set; }
    public bool HasTrailer { get; set; }

    // Implement the DisplayDetails method from IVehicle
    public void DisplayDetails()
    {
        Console.WriteLine($"Truck Details:");
        Console.WriteLine($"Company: {CompanyName}");
        Console.WriteLine($"Logo: {Logo}");
        Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        Console.WriteLine($"Fuel Type: {FuelType}");
        Console.WriteLine($"Maximum Speed: {MaximumSpeed} km/h");
        Console.WriteLine($"Electric: {IsElectric}");
        Console.WriteLine($"Cargo Capacity: {CargoCapacity} kg");
        Console.WriteLine($"Has Trailer: {HasTrailer}");
        Console.WriteLine();
    }
}
