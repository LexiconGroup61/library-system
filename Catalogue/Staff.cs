namespace Catalogue;

public class Staff : Employee
{
    public string AreaOfExpertese { get; set; }
    
    public Staff(DateOnly dayOfEmployment, decimal salary) : base(dayOfEmployment, salary)
    {
        
    }
    
    public override decimal PaySalary()
    {
        return 30000m;
    }
}