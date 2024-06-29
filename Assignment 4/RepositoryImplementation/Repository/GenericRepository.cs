using RepositoryImplementation.DataModel;
using RepositoryImplementation.Repository.Interface;

namespace RepositoryImplementation.Repository;

public class GenericRepository:IRepository<Student>
{
    private List<Student> _students = new List<Student>();
    
    
    public void Add(Student item)
    {
        if (GetById(item.Id) == null) //here a student with same Id can't exist but this was not mentioned in the assignment. We can just remove the if condition if we want the students to exist with same id.
        {
            _students.Add(item);
        }

    }

    public void Remove(Student item)
    {
        _students.Remove(item);
    }

    public void Save()
    {
        //I am not sure what is Save() supposed to do here. I guess we can implement commit() in save() if we are working with the real database.
    }

    public IEnumerable<Student> GetAll()
    {
        return _students;
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
}