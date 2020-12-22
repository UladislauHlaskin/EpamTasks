namespace AirCompany.Employees
{
    public class Employee
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public Employee()
        { 
        }
        public Employee(string name, string info)
        {
            Name = name;
            Info = info;
        }

        public override string ToString()
        {
            return $"Name - {Name}, Info - {Info}";
        }
    }
}
