using System;

namespace Garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public Ram()
        {
            MainColor = "silver";
            MaximumOccupancy = 5;
            FuelCapacity = 50;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls by you. Rrrrrrrummmmmmmbbbbble!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram turns to the {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram rumbles to a stop.\n");
        }
    }
}