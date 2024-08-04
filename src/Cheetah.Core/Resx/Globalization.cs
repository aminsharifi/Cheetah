namespace Cheetah.Core.Resx;
public class Globalization : IGlobalization
{
    public string AssemblyName { get; set; }
    public Globalization(string _AssemblyName)
    {
        AssemblyName = _AssemblyName;
    }

    private ResourceManager GetResourceManager()
    {
        var StartTime = DateTime.Now;

        var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.GetName().Name == AssemblyName).First();

        var currentNameSapce = assembly.GetName().Name;
        var basename = currentNameSapce + ".Resx.Localization";
        ResourceManager resourceManager =
        new(basename, assembly);
        return resourceManager;
    }

    public string GetValue(string Key)
    {
        var resourceManager = GetResourceManager();

        var ReturnValue = resourceManager.GetString(Key);

        return ReturnValue;
    }

    public string GetValue(string Key, object[]? arg0)
    {
        var resourceManager = GetResourceManager();

        var ReturnValue =
              string.Format(resourceManager.GetString(Key), arg0);
        return ReturnValue;
    }
}

