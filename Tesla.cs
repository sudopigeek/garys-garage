using System;


namespace Garage
{
    public class Tesla : IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public int CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public Tesla()
        {
            MainColor = "burgundy";
            MaximumOccupancy = 5;
            BatteryKWh = 300;
        }
        public void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes by you. MMMmmmmmmmmmmm!");
        }
        public void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla turns to the {direction}.");
        }
        public void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla humms to a stop.\n");
        }
    }
}