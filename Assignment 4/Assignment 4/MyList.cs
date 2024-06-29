namespace Assignment_4;

public class MyList<T>
{
    private List<T> _list = new List<T>();

    public void Add(T element)
    {
        _list.Add(element);
    }

    public T Remove(int index)
    {
        T element = _list[index];
        _list.RemoveAt(index);
        return element;
    }

    public bool Contains(T element)
    {
        if (_list.Contains(element))
        {
            return true;
        }

        return false;
    }

    public void Clear()
    {
        _list.Clear();
    }

    public void InsertAt(T element, int index)
    {
        _list.Insert(index, element);
    }


    public void DeleteAt(int index)
    {
        T element = _list[index];
        _list.RemoveAt(index);
    }


    public T Find(int index)
    {
        return _list[index];
    }
    
}