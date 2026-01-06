// Интерфейс итератора
public interface Iterator<T>
{
    bool HasNext();
    T Next();
}

// Конкретный итератор
public class ArrayIterator<T> : Iterator<T>
{
    private T[] items;
    private int position;

    public ArrayIterator(T[] items)
    {
        this.items = items;
        this.position = 0;
    }

    public bool HasNext() => position < items.Length;

    public T Next()
    {
        if (HasNext())
            return items[position++];

        throw new InvalidOperationException();
    }
}