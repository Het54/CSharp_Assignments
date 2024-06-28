namespace Classes.Abstraction;

public class Instructor: Person
{
    public decimal HourlyPay { get; set; }
    
    public DateTime joinDate { get; set; }
    
    public Department Department { get; set; }
    
    public bool IsHeadOfDepartment { get; set; }
    
}