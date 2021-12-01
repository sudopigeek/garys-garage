using System;

namespace Garage
{
    public class Cessna : IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public int CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. Zzzzoooomm!");
        }
        public void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna banks to the {direction}.");
        }
        public void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after landing on the runway.\n");
        }
        public Cessna()
        {
            MainColor = "white";
            MaximumOccupancy = 4;
            FuelCapacity = 100;
        }
    }
}