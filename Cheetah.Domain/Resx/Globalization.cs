using System.Reflection;
using System.Resources;

namespace Cheetah.Resx;
public class Globalization : IGlobalization
{
    public String AssemblyName { get; set; }
    public Globalization(String _AssemblyName)
    {
        AssemblyName = _AssemblyName;
    }
    public String GetValue(String Key, object[]? arg0)
    {
        var StartTime = DateTime.Now;

        var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.GetName().Name == AssemblyName).First();

        var currentNameSapce = assembly.GetName().Name;
        var basename = currentNameSapce + ".Resx.Localization";
        var ReturnValue = String.Empty;
        ResourceManager resourceManager =
        new ResourceManager(basename, assembly);
        ReturnValue =
                String.Format(resourceManager.GetString(Key), arg0);
        return ReturnValue;


    }
}

