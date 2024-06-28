using Classes.Abstraction;

namespace Classes.Repositories.Interface;

public interface IDepartmentService
{
    decimal CalculateBudget(DateTime startDate, DateTime endDate);
    
}