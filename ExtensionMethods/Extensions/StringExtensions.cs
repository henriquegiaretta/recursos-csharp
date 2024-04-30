namespace ExtensionMethods.Extensions;

public static class StringExtensions
{
    /*
     * Classe chama de StringExtensions onde irá cuidar de todos os métodos de extensão referentes a strings. 
     * Aqui podemos criar todos os métodos necessários.
    */
    public static string Revert(this string value)
        => new string(value.ToCharArray().Reverse().ToArray());
}