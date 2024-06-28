using Classes.Repositories.Interface;

namespace Classes.Abstraction;

public abstract class Person:IPersonService
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    
    public DateTime DOB { get; set; }
    
    public List<string> Address { get; set; }
    
    
}