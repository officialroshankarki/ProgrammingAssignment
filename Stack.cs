using System;
namespace Assignment;

public class Stack<T>
{
    public List<T> data;

    public Stack()
    {
        this.data = new List<T>();
    }

    public void Push(T value)
    {
        data.Add(value);
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Here you have empty List");
        }

        int lastIndex = data.Count - 1;

        T value = data[lastIndex];
        data.RemoveAt(data.Count - 1);
        return value;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Empty List!!!");

        }
        return data[data.Count - 1];
    }

    public bool IsEmpty()
    {
        if (data.Count != 0)
        {
            return false;
        }

        return true;
    }
}