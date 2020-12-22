using AirCompany.Employees;

namespace AirCompany.Planes
{
    public class PlaneModel
    {
        public string Manufacturer { get; }
        public string Name { get; }
        public SkillLevel SkillLevelRequired { get; }
        public PlaneModel()
        { 
        }
        public PlaneModel(string manufacturer, string name, SkillLevel skillLevelRequired)
        {
            Manufacturer = manufacturer;
            Name = name;
            SkillLevelRequired = skillLevelRequired;
        }
        public override string ToString()
        {
            return $"{Manufacturer} - {Name}";
        }
    }
}
