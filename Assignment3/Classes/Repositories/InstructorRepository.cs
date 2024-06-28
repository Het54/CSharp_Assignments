using Classes.Abstraction;
using Classes.Repositories.Interface;

namespace Classes.Repositories;

public class InstructorRepository: IInstructorService<Instructor>
{

    public List<Instructor> _instructors = new List<Instructor>();
    
    public int Insert(Instructor obj)
    {
        if (GetById(obj.Id) == null)
        {
            _instructors.Add(obj);
            return 1;
        }

        return 0;
    }

    public int Update(Instructor obj)
    {
        Instructor i = GetById(obj.Id);
        if (i != null)
        {
            i.Id = obj.Id;
            i.Name = obj.Name;
            i.Email = obj.Email;
            i.DOB = obj.DOB;
            i.Address = obj.Address;
            i.HourlyPay = obj.HourlyPay;
            i.Department = obj.Department;
            i.IsHeadOfDepartment = obj.IsHeadOfDepartment;
            i.joinDate = obj.joinDate;
            return 1;
        }

        return 0;
    }

    public int Delete(int id)
    {
        Instructor i = GetById(id);
        if (i != null)
        {
            _instructors.Remove(i);
            return 1;
        }

        return 0;
    }

    public Instructor GetById(int id)
    {
        for (int i = 0; i < _instructors.Count; i++)
        {
            if (_instructors[i].Id == id)
            {
                return _instructors[i];
            }
        }

        return null;
    }

    public List<Instructor> GetALl()
    {
        return _instructors;
    }
    
    public int CalculateAge(int id)
    {
        Instructor i = GetById(id);
        if (i != null)
        {
            var today = DateTime.Today;
            var age = today.Year - i.DOB.Year;
            return age;
        }

        return 0;

    }
    
    public decimal CalculateSalary(int id)
    {
        Instructor i = GetById(id);
        if (i != null)
        {
            return i.HourlyPay * 40 * 52;
        }
        return 0;
        
    }
    
    
    public int CalculateYearsOfExp(int id)
    {
        Instructor i = GetById(id);
        if (i != null)
        {
            var today = DateTime.Today;
            var yearsOfExperience = today.Year - i.joinDate.Year;
            return yearsOfExperience;
        }

        return 0;

    }

}