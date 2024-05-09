using System.Reflection;

namespace Generics.Generics;

public static class ClassGeneric<T> where T: class
{
    public static MethodInfo? GetMethodByName(string name)
        => typeof(T)
            .GetMethods()
            .FirstOrDefault(p => p.Name.Equals(name, System.StringComparison.InvariantCultureIgnoreCase));
}