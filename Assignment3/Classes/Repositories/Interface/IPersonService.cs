namespace Classes.Repositories.Interface;

public interface IPersonService
{
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    
    
    public DateTime DOB { get; set; }
    
    public List<string> Address { get; set; }
    // int CalculateAge();
    // decimal CalculateSalary();
    // List<string> GetAddress();
}