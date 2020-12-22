namespace AirCompany.Planes
{
    public class PlaneSpecification
    {
        public int PassengerCapacity { get; }
        public double CargoCapacity { get; }
        public double FuelConsumption { get; }
        public double TankCapacity { get; }
        public PlaneSpecification(int passengerCapacity, double cargoCapacity, double fuelConsumption, double tankCapacity)
        {
            PassengerCapacity = passengerCapacity;
            CargoCapacity = cargoCapacity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }
    }
}
