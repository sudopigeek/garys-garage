namespace Garage
{
    public interface IVehicle
    {
        string MainColor { get; set; }
        int MaximumOccupancy { get; set; }
        void Drive();
        void Turn(string direction);
        void Stop();
    }
    public interface IElectricVehicle : IVehicle
    {
        double BatteryKWh { get; set; }
        int CurrentChargePercentage { get; set; }
        void ChargeBattery();
    }
    public interface IGasVehicle : IVehicle
    {
        double FuelCapacity { get; set; }
        void RefuelTank();
        int CurrentTankPercentage { get; set; }
    }
}