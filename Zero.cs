using System;

namespace Garage
{
    public class Zero : IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public int CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public Zero()
        {
            MainColor = "yellow";
            MaximumOccupancy = 1;
            BatteryKWh = 140;
        }
        public void Drive()
        {
            Console.WriteLine($"the {MainColor} Zero zips by you. Yeeeeeeoooooowwwww!");
        }
        public void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero turns to the {direction}.");
        }
        public void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero glides to a stop.\n");
        }
    }
}