namespace Cheetah.Resx;
public interface IGlobalization
{
    public String GetValue(String Key, object[]? arg0);
    public String GetValue(String Key);
}