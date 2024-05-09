namespace Generics.Models;

public class Person
{
    public string Name { get; set; } = String.Empty;
    public int Age { get; set; }

    public bool GetAge()
        => Age >= 18;
}