using RepositoryImplementation.DataModel;
using RepositoryImplementation.Repository;

namespace RepositoryImplementation.Presentation;

public class ManageStudent
{
    private GenericRepository _genericRepository = new GenericRepository();
    
    
    private void AddStudentId()
    {
        Student s = new Student();
        Console.WriteLine("Enter Id: ");
        s.Id = int.Parse(Console.ReadLine());
        _genericRepository.Add(s);

    }
    
    private void DeleteStudentsID()
{
    Console.WriteLine("Enter Id that you want to remove: ");
    int idToRemove = int.Parse(Console.ReadLine());
    
    Student studentToRemove = _genericRepository.GetById(idToRemove);
    
    if (studentToRemove != null)
    {
        _genericRepository.Remove(studentToRemove);
        Console.WriteLine($"Student with Id {idToRemove} removed successfully.");
    }
    else
    {
        Console.WriteLine($"Student with Id {idToRemove} not found.");
    }
}
    
    
    private void GetAllId()
    {
        IEnumerable<Student> s = new List<Student>();
        s = _genericRepository.GetAll();

        foreach (var id in s)
        {
            Console.WriteLine($"Id: {id.Id}");
        }
        
    }


    private void GetById()
    {
        Console.WriteLine("Enter Id that you want to get it from the database: ");
        int i = Convert.ToInt32(Console.ReadLine());

        Student s = new Student();
        try
        {
            s = _genericRepository.GetById(i);
            Console.Write($"Id was there in the list: {s.Id}");
            Console.WriteLine();
        }
        catch(Exception ex)
        {
            Console.WriteLine("Id not present in the database");
        }
        
        
        
        
    }


    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Press 1 to Add Student Id");
        Console.WriteLine("Press 2 to Remove Student Id");
        Console.WriteLine("Press 3 to Get All Student Id");
        Console.WriteLine("Press 4 to find whether the student Id exists in the database or not");
        Console.WriteLine("Press 9 to Exit");

        int choice = int.Parse(Console.ReadLine());

        while (choice != 9)
        {
            switch (choice)
            {
                case 1:
                    AddStudentId();
                    break;
                case 2:
                    DeleteStudentsID();
                    break;
                case 3:
                    GetAllId();
                    break;
                case 4:
                    GetById();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

            Console.WriteLine("Press number to continue");
            choice = int.Parse(Console.ReadLine());
        }


    }




}