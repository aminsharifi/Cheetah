namespace Cheetah.Application.Business.Helper;

public static class GenerateCacheKey
{
    public static String AsString(this IEnumerable<long?> numbers)
    {
        String asString = String
            .Join(", ", numbers.Select(n => n.Value.ToString(CultureInfo.InvariantCulture)));
        return asString;
    }
    public static String AsString(this IEnumerable<long> numbers)
    {
        String asString = String
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
