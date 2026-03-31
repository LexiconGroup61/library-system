namespace Catalogue;

public class Manager : Employee
{
    public string Department { get; set; }

    public Manager(DateOnly dayOfEmployment, decimal salary, string department) : base(dayOfEmployment, salary)
    {
        Department = department;
    }
    
    public new int FireEmployee()
    {
        return 5;
    }
}