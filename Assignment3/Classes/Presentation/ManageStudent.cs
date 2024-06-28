using Classes.Repositories;
using Classes.Repositories.Interface;

namespace Classes.Abstraction;

public class ManageStudent
{
    private StudentRepository _studentRepository = new StudentRepository();


    private void AddStudent()
    {
        Student s = new Student();
        Console.WriteLine("Enter Id: ");
        s.Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Name: ");
        s.Name = Console.ReadLine();
        Console.WriteLine("Enter Email: ");
        s.Email = Console.ReadLine();
        Console.WriteLine("Enter Date of Birth: ");
        s.DOB = Convert.ToDateTime(Console.ReadLine());

        s.Address = new List<string>();
        Console.WriteLine("How many addresses you have: ");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < a; i++)
        {
            Console.WriteLine($"Enter Adresses {i+1}: ");
            string tempaddress = Console.ReadLine();
            s.Address.Add(tempaddress);
        }

        s.Courses = new List<Course>();
        Console.WriteLine("How many courses are you taking: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Courses and Grades one by one (Grade should be from this List [A,B,C,D,F]): ");
        for (int i = 0; i < n; i++)
        {
            try
            {
                Course c = new Course();
                Console.WriteLine("Enter Course Name: ");
                c.courseName = Console.ReadLine();
                Console.WriteLine("Enter Grade: ");
                c.grade = Console.ReadLine();
                s.Courses.Add(c);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        if (_studentRepository.Insert(s) == 1)
        {
            Console.WriteLine("Student has been added successfully");
        }
        else
        {
            Console.WriteLine("Some Error has occured");
        }

    }
    
    
    private void PrintAllStudents()
    {
        List<Student> s = new List<Student>();
        s = _studentRepository.GetALl();
        foreach (var stud in s)
        {
            Console.WriteLine(stud.Id + "\t" + stud.Name +"\t" + stud.Email + "\t" + stud.DOB.ToString());
            Console.WriteLine("Addresses:");
            for (int i = 0; i < stud.Address.Count; i++)
            {
                Console.WriteLine(stud.Address[i]);
            }
            Console.WriteLine("Courses:");
            for (int i = 0; i < stud.Courses.Count; i++)
            {
                Console.Write($"CourseName: {stud.Courses[i].courseName}       Grade: {stud.Courses[i].grade}");
                Console.WriteLine();
            }
        }
    }
    
    
    private void DeleteStudents()
    {
        Console.WriteLine("Enter Id: ");
        int Id = int.Parse(Console.ReadLine());
        if (_studentRepository.Delete(Id) == 1)
        {
            Console.WriteLine("Student has been removed");
        }
        else
        {
            Console.WriteLine("Some error has occured");
        }
    }

    public void CalculateGPA()
    {
        Console.WriteLine("Enter Id: ");
        int Id = int.Parse(Console.ReadLine());
        if (_studentRepository.GetGPA(Id) != null)
        {
            Console.WriteLine($"GPA: {_studentRepository.GetGPA(Id)}");
        }
        else
        {
            Console.WriteLine($"No record found for ID: {Id}");
        }
        
            
    }

    public void GetAge()
    {
        Console.WriteLine("Enter Id: ");
        int Id = int.Parse(Console.ReadLine());
        if (_studentRepository.CalculateAge(Id) != 0)
        {
            Console.WriteLine($"Age: {_studentRepository.CalculateAge(Id)}");
        }
        else
        {
            Console.WriteLine($"Enter a valid Id");
        }
        


    }
    
    
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Press 1 to Add");
        Console.WriteLine("Press 2 to Print All");
        Console.WriteLine("Press 3 to Print Delete");
        Console.WriteLine("Press 4 to Print GPA");
        Console.WriteLine("Press 5 to Print Age of the Student");
        Console.WriteLine("Press 9 to Exit");

        int choice = int.Parse(Console.ReadLine());

        while (choice != 9)
        {
            switch (choice)
            {
                case 1: 
                    AddStudent();
                    break;
                case 2:
                    PrintAllStudents();
                    break;
                case 3: 
                    DeleteStudents();
                    break;
                case 4:
                    CalculateGPA();
                    break;
                case 5:
                    GetAge();
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