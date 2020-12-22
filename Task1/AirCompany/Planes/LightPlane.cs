using System;
using System.Globalization;

namespace AirCompany.Planes
{
    public class LightPlane : Plane
    {
        public LightPlane()
        {
        }

        public LightPlane(string uniqueNumber, PlaneModel planeModel) : base(uniqueNumber, planeModel)
        {
            PlaneType = PlaneType.Light;
        }
        public override string ToString()
        {
            return
                $"Light plane - {PlaneModel}, max fly distance = {MaxFlyDistance}, fuel consumption = " +
                $"{PlaneSpecification.FuelConsumption.ToString(CultureInfo.InvariantCulture)}";
        }
    }
}
