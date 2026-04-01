namespace Catalogue;

public class Employee
{
    public DateOnly DayOfEmployment { get; set; }
    public decimal Salary { get; set; }

    public Employee(DateOnly dayOfEmployment, decimal salary)
    {
        DayOfEmployment = dayOfEmployment;
        Salary = salary;
    }

    public virtual decimal PaySalary()
    {
        return 30000m;
    }
    
    public string FireEmployee()
    {
        return "You have 3 months payment";
    }
}