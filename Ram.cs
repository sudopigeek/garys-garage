using System;

namespace Garage
{
    public class Ram : IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public int CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public Ram()
        {
            MainColor = "silver";
            MaximumOccupancy = 5;
            FuelCapacity = 50;
        }
        public void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls by you. Rrrrrrrummmmmmmbbbbble!");
        }
        public void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram turns to the {direction}");
        }
        public void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram rumbles to a stop.\n");
        }
    }
}