using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public Tesla()
        {
            MainColor = "burgundy";
            MaximumOccupancy = 5;
            BatteryKWh = 300;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes by you. MMMmmmmmmmmmmm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla turns to the {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla humms to a stop.\n");
        }
    }
}