using System.Net.NetworkInformation;

namespace Catalogue;

public class CEO : Manager
{
    public string SignAuthority { get; set; }
    
    public CEO(DateOnly dayOfEmployment, decimal salary, string department) : base(dayOfEmployment, salary, department)
    {
        
    }
    
    public CEO(DateOnly dayOfEmployment, decimal salary, string department, string signAuthority) : base(dayOfEmployment, salary, department)
    {
        SignAuthority = signAuthority;
    }
}