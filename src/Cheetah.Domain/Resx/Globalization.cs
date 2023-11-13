namespace Cheetah.Resx;
public class Globalization : IGlobalization
{
    public String AssemblyName { get; set; }
    public Globalization(String _AssemblyName)
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
        new ResourceManager(basename, assembly);
        return resourceManager;
    }

    public String GetValue(String Key)
    {
        var resourceManager = GetResourceManager();

        var ReturnValue = resourceManager.GetString(Key);

        return ReturnValue;
    }

    public String GetValue(String Key, object[]? arg0)
    {
        var resourceManager = GetResourceManager();

        var ReturnValue =
              String.Format(resourceManager.GetString(Key), arg0);
        return ReturnValue;
    }
}

