using Classes.Repositories.Interface;

namespace Classes.Abstraction;

public abstract class ManagePerson
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    
    public decimal HourlyPay { get; set; }
    
    public DateTime DOB { get; set; }
    
    public List<string> Address { get; set; }

    public abstract int CalculateAge();

    public abstract decimal CalculateSalary();
    
    public abstract List<string> GetAddress();
    
}