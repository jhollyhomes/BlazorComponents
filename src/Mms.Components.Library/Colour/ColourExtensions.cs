namespace Mms.Components.Library.Colour;
public static class ColourExtensions
{
    public static string RemoveTailwindPrefix(this string value)
    {
        var index = value.IndexOf("-") + 1;
        return value.Substring(index, value.Length - index);
    }
}
