using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var myCar = new Car
            {
                NumberOfWheels = 3,
                FuelType = "EV",
                MaximumSpeed = 200,
                IsElectric = true,
                CompanyName = "Aptera",
                Logo = "A leaf",
                HasTrunk = true,
                NumberOfDoors = 2
            };


            var myTruck = new Truck
            {
                NumberOfWheels = 8,
                FuelType = "Diesel",
                MaximumSpeed = 120,
                IsElectric = false,
                CompanyName = "Detroit Diesel",
                Logo = "Spinning arrows",
                CargoCapacity = 10000,
                HasTrailer = true
            };


            var mySUV = new SUV
            {
                NumberOfWheels = 4,
                FuelType = "Hybrid",
                MaximumSpeed = 180,
                IsElectric = false,
                CompanyName = "Toyota",
                Logo = "Overlapping circle with T",
                NumberOfSeats = 8,
                HasSunroof = true
            };

            myCar.DisplayDetails();
            myTruck.DisplayDetails();
            mySUV.DisplayDetails();
        }
    }
}
