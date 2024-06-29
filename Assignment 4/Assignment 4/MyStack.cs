namespace Assignment_4;

public class MyStack<T>
{
    Stack<T> items = new Stack<T>();

    public int Count()
    {
            return items.Count;
    }

    public T Pop()
    {
        if (items.Count > 0)
        {
            T removedItem = items.Peek();
            items.Pop();
            return removedItem;
        }
        else
        {
            throw new InvalidOperationException("Stack is Empty");
        }

    }


    public void Push(T item)
    {
        items.Push(item);
    }
    

}