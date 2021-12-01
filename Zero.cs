using System;

namespace Garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public Zero()
        {
            MainColor = "yellow";
            MaximumOccupancy = 1;
            BatteryKWh = 140;
        }
        public override void Drive()
        {
            Console.WriteLine($"the {MainColor} Zero zips by you. Yeeeeeeoooooowwwww!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero turns to the {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero glides to a stop.\n");
        }
    }
}