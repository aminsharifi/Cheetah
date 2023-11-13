namespace Cheetah.Domain.Resx;

public class GlobalizationService
{
    public static IGlobalization GetIGlobalization()
    {
        IGlobalization iGlobalization = new Globalization(nameof(Cheetah) + "." + nameof(Cheetah.Domain));
        return iGlobalization;
    }
    public static string GetValue(String Key, object[]? arg0)
    {

        return GetIGlobalization().GetValue(Key, arg0);
    }
    public static string GetValue(String Key)
    {
        return GetIGlobalization().GetValue(Key);
    }
}
