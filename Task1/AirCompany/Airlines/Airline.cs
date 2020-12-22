using System.Collections.Generic;
using System.Linq;
using AirCompany.Planes;
using AirCompany.Employees;
using System.Text;

namespace AirCompany.Airlines
{
    public class Airline
    {
        public string Name { get; set; }
        public List<Plane> Planes { get; set; }
        public List<Employee> Employees { get; set; }
        public Airline(string name)
        {
            Name = name;
            Planes = new List<Plane>();
            Employees = new List<Employee>();
        }
        public Airline(string name, List<Plane> planes, List<Employee> employees)
        {
            Name = name;
            Planes = planes;
            Employees = employees;
        }

        public int TotalPassengerCapacity => Planes.Sum(p => p.PlaneSpecification.PassengerCapacity);
        public double TotalCargoCapacity => Planes.Sum(p => p.PlaneSpecification.CargoCapacity);
        public List<Plane> PlanesByMaxFlyDistance => Planes.OrderBy(p => p.MaxFlyDistance).ToList();
        public List<Plane> GetPlanesByFuelConsumption(double fuelConsumptionMin, double fuelConsumptionMax)
        {
            return Planes
                .Where(p => p.PlaneSpecification.FuelConsumption >= fuelConsumptionMin)
                .Where(p => p.PlaneSpecification.FuelConsumption <= fuelConsumptionMax)
                .OrderBy(p => p.PlaneSpecification.FuelConsumption)
                .ToList();
        }
        public Plane GetSinglePlanesByFuelConsumption(double fuelConsumptionMin, double fuelConsumptionMax)
        {
            return Planes
                .Where(p => p.PlaneSpecification.FuelConsumption >= fuelConsumptionMin)
                .Where(p => p.PlaneSpecification.FuelConsumption <= fuelConsumptionMax)
                .OrderBy(p => p.PlaneSpecification.FuelConsumption)
                .FirstOrDefault();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name - {Name}\n");
            foreach (var p in Planes)
            {
                sb.Append(p);
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
