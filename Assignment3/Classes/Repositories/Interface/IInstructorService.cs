namespace Classes.Repositories.Interface;

public interface IInstructorService <T> where T: class
{
    
    int Insert(T obj);
    int Update(T obj);
    int Delete(int id);
    T GetById(int id);
    List<T> GetALl();
    
    // public int CalculateYearsOfExperience();
}