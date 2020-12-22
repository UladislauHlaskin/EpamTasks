namespace AirCompany.Employees
{
    public class Pilot : Employee
    {
        public SkillLevel SkillLevel { get; set; }
        public Pilot()
        { 
        }
        public Pilot(string name, string info, SkillLevel skillLevel) : base(name, info)
        {
            SkillLevel = skillLevel;
        }
        public override string ToString()
        {
            return $"Name - {Name}, Info - {Info}, Skill level - {SkillLevel.ToString()} ({(int)SkillLevel})";
        }
    }
}
