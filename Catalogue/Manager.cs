namespace Catalogue;

public class Manager : Employee
{
    public string Department { get; set; }

    public Manager(DateOnly dayOfEmployment, decimal salary, string department) : base(dayOfEmployment, salary)
    {
        Department = department;
    }

    public override decimal PaySalary()
    {
        // Add bonus
        return 30000m + 12000m;
    }
    
    public new int FireEmployee()
    {
        return 5;
    }
}