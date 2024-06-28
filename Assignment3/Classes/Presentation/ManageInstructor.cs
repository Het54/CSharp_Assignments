using Classes.Repositories;
using Classes.Repositories.Interface;

namespace Classes.Abstraction;

public class ManageInstructor
{

    private InstructorRepository _instructorRepository = new InstructorRepository();
    
    
    private void AddInstructor()
    {
        Instructor i = new Instructor();
        Console.WriteLine("Enter Id: ");
        i.Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Name: ");
        i.Name = Console.ReadLine();
        Console.WriteLine("Enter Email: ");
        i.Email = Console.ReadLine();
        Console.WriteLine("Enter Date of Birth: ");
        i.DOB = Convert.ToDateTime(Console.ReadLine());

        i.Address = new List<string>();
        Console.WriteLine("How many addresses you have: ");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int x = 0; x < a; x++)
        {
            Console.WriteLine($"Enter Adresses {x+1}: ");
            string tempaddress = Console.ReadLine();
            i.Address.Add(tempaddress);
        }
        
        Console.WriteLine("What is your hourly pay: ");
        i.HourlyPay = Convert.ToDecimal(Console.ReadLine());

        Department d = new Department();
        Console.WriteLine("WWhich Department do you belong: ");
        d.departmentName = Console.ReadLine();
        i.Department = d;
        
        Console.WriteLine($"Are you head of the {d.departmentName} department (y/n): ");
        char yn = Convert.ToChar(Console.ReadLine());
        if (yn == 'y' || yn == 'Y')
        {
            i.IsHeadOfDepartment = true;
        }
        else
        {
            i.IsHeadOfDepartment = false;
        }
        
        Console.WriteLine("What was your Joining Date: ");
        i.joinDate = Convert.ToDateTime(Console.ReadLine());

        if (_instructorRepository.Insert(i) == 1)
        {
            Console.WriteLine("Instructor has been added successfully");
        }
        else
        {
            Console.WriteLine("Some Error has occured");
        }

    }
    
    
    private void PrintAllInstructors()
    {
        List<Instructor> i = new List<Instructor>();
        i = _instructorRepository.GetALl();
        foreach (var inst in i)
        {
            Console.WriteLine(inst.Id + "\t" + inst.Name +"\t" + inst.Email + "\t" + inst.DOB.ToString() + "\t" + inst.HourlyPay + "\t" + inst.Department.departmentName +"\t" + inst.IsHeadOfDepartment + "\t" + inst.joinDate.ToString());
            Console.WriteLine("Addresses:");
            for (int x = 0; x < inst.Address.Count; x++)
            {
                Console.WriteLine(inst.Address[x]);
            }
        }
    }
    
    
    
    private void DeleteInstructor()
    {
        Console.WriteLine("Enter Id: ");
        int Id = int.Parse(Console.ReadLine());
        if (_instructorRepository.Delete(Id) == 1)
        {
            Console.WriteLine("Instructor has been removed");
        }
        else
        {
            Console.WriteLine("Some error has occured");
        }
    }
    
    public void GetAge()
    {
        Console.WriteLine("Enter Id: ");
        int Id = int.Parse(Console.ReadLine());
        if (_instructorRepository.CalculateAge(Id) != 0)
        {
            Console.WriteLine($"Age: {_instructorRepository.CalculateAge(Id)}");
        }
        else
        {
            Console.WriteLine($"Enter a valid Id");
        }

    }
    
    public void GetSalary()
    {
        Console.WriteLine("Enter Id: ");
        int Id = int.Parse(Console.ReadLine());
        if (_instructorRepository.CalculateSalary(Id) != 0)
        {
            Console.WriteLine($"Salary: {_instructorRepository.CalculateSalary(Id)}");
        }
        else
        {
            Console.WriteLine($"Enter a valid Id");
        }

    }
    
    public void GetYearsOfExperience()
    {
        Console.WriteLine("Enter Id: ");
        int Id = int.Parse(Console.ReadLine());
        if (_instructorRepository.CalculateYearsOfExp(Id) != 0)
        {
            Console.WriteLine($"Year Of Experience: {_instructorRepository.CalculateYearsOfExp(Id)}");
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
        Console.WriteLine("Press 4 to Print Age of the Instructor");
        Console.WriteLine("Press 5 to Print Annual Salary of the Instructor");
        Console.WriteLine("Press 6 to Print Years of experience of the Instructor");
        Console.WriteLine("Press 9 to Exit");

        int choice = int.Parse(Console.ReadLine());

        while (choice != 9)
        {
            switch (choice)
            {
                case 1: 
                    AddInstructor();
                    break;
                case 2:
                    PrintAllInstructors();
                    break;
                case 3: 
                    DeleteInstructor();
                    break;
                case 4:
                    GetAge();
                    break;
                case 5:
                    GetSalary();
                    break;
                case 6:
                    GetYearsOfExperience();
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