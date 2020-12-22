using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Planes
{
    public class CargoPlane : Plane
    {
        public CargoPlane()
        {
        }

        public CargoPlane(string uniqueNumber, PlaneModel planeModel) : base(uniqueNumber, planeModel)
        {
            PlaneType = PlaneType.Cargo;
        }
        public override string ToString()
        {
            return
                $"Cargo plane - {PlaneModel}, max fly distance = {MaxFlyDistance}, fuel consumption = " +
                $"{PlaneSpecification.FuelConsumption.ToString(CultureInfo.InvariantCulture)}";
        }
    }
}
