using System;
using System.Globalization;

namespace AirCompany.Planes
{
    public class PassengerPlane : Plane
    {
        public PassengerPlane()
        {
        }

        public PassengerPlane(string uniqueNumber, PlaneModel planeModel) : base(uniqueNumber, planeModel)
        {
            PlaneType = PlaneType.Passenger;
        }
        public override string ToString()
        {
            return
                $"Passenger plane - {PlaneModel}, max fly distance = {MaxFlyDistance}, fuel consumption = " +
                $"{PlaneSpecification.FuelConsumption.ToString(CultureInfo.InvariantCulture)}";
        }
    }
}
