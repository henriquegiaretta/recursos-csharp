namespace Generics.Generics;

public class BaseGeneric<T>
{
    private readonly T _item;

    public BaseGeneric(T item)
        => _item = item;
    
    public T GetItem()
        => _item;
}