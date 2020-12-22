using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Planes
{
    /// <summary>
    /// https://medium.com/@martinstm/fluent-builder-pattern-c-4ac39fafcb0b
    /// </summary>
    public class PlaneBuilder
    {
        private Plane _plane;
        public PlaneBuilder(PlaneType planeType)
        {
            switch (planeType)
            {
                case PlaneType.Cargo:
                    _plane = new CargoPlane();
                    break;
                case PlaneType.Light:
                    _plane = new LightPlane();
                    break;
                case PlaneType.Passenger:
                    _plane = new PassengerPlane();
                    break;
                case PlaneType.Training:
                    _plane = new TrainingPlane();
                    break;
            }
        }
        public PlaneBuilder SetModel(PlaneModel model)
        {
            _plane.PlaneModel = model;
            return this;
        }
        public PlaneBuilder SetSpecification(PlaneSpecification specification)
        {
            _plane.PlaneSpecification = specification;
            return this;
        }
        public PlaneBuilder SetUniqueNumber(string uniqueNumber)
        {
            _plane.UniqueNumber = uniqueNumber;
            return this;
        }
        public Plane Build()
        {
            return _plane;
        }
    }
}
