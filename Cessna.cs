using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. Zzzzoooomm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna banks to the {direction}.");
        }
        public override void Stop()
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