using Classes.Abstraction;
using Classes.Repositories.Interface;

namespace Classes.Repositories;

public class StudentRepository: IStudentService<Student>
{

    private List<Student> _students = new List<Student>();
    
    
    public int Insert(Student obj)
    {
        if (GetById(obj.Id) == null)
        {
            _students.Add(obj);
            return 1;
        }

        return 0;
    }

    public int Update(Student obj)
    {
        Student s = GetById(obj.Id);
        if (s != null)
        {
            s.Id = obj.Id;
            s.Name = obj.Name;
            s.Email = obj.Email;
            s.DOB = obj.DOB;
            s.Address.Add(obj.Address.ToString());
            s.Courses = obj.Courses;
            return 1;
        }

        return 0;
    }

    public int Delete(int id)
    {
        Student s = GetById(id);
        if (s != null)
        {
            _students.Remove(s);
            return 1;
        }

        return 0;
    }

    public Student GetById(int id)
    {
        for (int i = 0; i < _students.Count; i++)
        {
            if (_students[i].Id == id)
            {
                return _students[i];
            }
        }

        return null;
    }

    public List<Student> GetALl()
    {
        return _students;
    }

    public string GetGPA(int id)
    {
        Student s = GetById(id);
        if (s != null)
        {
            Dictionary<string, double> dictionary = new Dictionary<string, double>
            {
                {"A", 4.0},
                {"B", 3.0},
                {"C", 2.0},
                {"D", 1.0},
                {"F", 0.0}
            
            };
            double grades = 0.0;
            for (int i = 0; i < s.Courses.Count; i++)
            {
                grades += dictionary[s.Courses[i].grade];
            }

            double averagegrade = grades / s.Courses.Count;
        
            if (averagegrade % 1 >= 0.5)
            {
                grades = Math.Ceiling(averagegrade);
            }
            else
            {
                grades = Math.Floor(averagegrade);
            }

            foreach (var kvp in dictionary)
            {
                if (kvp.Value == grades)
                {
                    return kvp.Key;
                }
            }
        }
        return null;
    }
    
    public int CalculateAge(int id)
    {
        Student s = GetById(id);
        if (s != null)
        {
            var today = DateTime.Today;
            var age = today.Year - s.DOB.Year;
            return age;
        }

        return 0;

    }
}