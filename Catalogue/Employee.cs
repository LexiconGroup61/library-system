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

    public string FireEmployee()
    {
        return "You have 3 months payment";
    }
}