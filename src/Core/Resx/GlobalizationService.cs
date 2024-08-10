namespace Cheetah.Core.Resx;

public class GlobalizationService
{
    public static IGlobalization GetIGlobalization()
    {
        IGlobalization iGlobalization = new Globalization(nameof(Cheetah) + "." + nameof(Core));
        return iGlobalization;
    }
    public static string GetValue(string Key, object[]? arg0)
    {

        return GetIGlobalization().GetValue(Key, arg0);
    }
    public static string GetValue(string Key)
    {
        return GetIGlobalization().GetValue(Key);
    }
}
