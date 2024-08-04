namespace Cheetah.Core.Helpers;

public static class GenerateCacheKey
{
    public static string AsString(this IEnumerable<long?> numbers)
    {
        string asString = string
            .Join(", ", numbers.Select(n => n.Value.ToString(CultureInfo.InvariantCulture)));
        return asString;
    }
    public static string AsString(this IEnumerable<long> numbers)
    {
        string asString = string
            .Join(", ", numbers.Select(n => n.ToString(CultureInfo.InvariantCulture)));
        return asString;
    }

    public static IEnumerable<long> FromString(this string numbers)
    {
        IEnumerable<long> fromString = numbers
            .Split(",")
            .Select(c => long.Parse(c, CultureInfo.InvariantCulture));
        return fromString;
    }

}
