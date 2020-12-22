using System;
using System.Globalization;

namespace AirCompany.Planes
{
    public class TrainingPlane : Plane
    {
        public TrainingPlane()
        {
        }

        public TrainingPlane(string uniqueNumber, PlaneModel planeModel) : base(uniqueNumber, planeModel)
        {
            PlaneType = PlaneType.Training;
        }
        public override string ToString()
        {
            return 
                $"Training plane - {PlaneModel}, max fly distance = {MaxFlyDistance}, fuel consumption = " +
                $"{PlaneSpecification.FuelConsumption.ToString(CultureInfo.InvariantCulture)}";
        }
    }
}
