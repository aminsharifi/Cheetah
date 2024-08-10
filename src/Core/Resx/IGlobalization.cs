namespace Cheetah.Core.Resx;
public interface IGlobalization
{
    public string GetValue(string Key, object[]? arg0);
    public string GetValue(string Key);
}