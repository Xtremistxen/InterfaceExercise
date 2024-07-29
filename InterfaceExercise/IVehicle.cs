namespace InterfaceExercise;

public interface IVehicle

{
    int NumberOfWheels { get; set; }
    string FuelType { get; set; }
    int MaximumSpeed { get; set; }
    bool IsElectric { get; set; }
    
    
    void DisplayDetails();
}