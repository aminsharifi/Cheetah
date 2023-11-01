using Cheetah.Application.Business.Repository;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Resources;
namespace Cheetah.Presentation.Web.Blazor.Server.Resx;

public class Globalization: IGlobalization
{
  
    public String GetValue(String Key, object[]? arg0)
    {
        var currentNameSapce = Assembly.GetExecutingAssembly().GetName().Name;
        var basename = currentNameSapce + "." +
            nameof(Resx) + "." +
            nameof(Resx.Localization);
        ResourceManager resourceManager =
            new ResourceManager(basename,
            Assembly.GetExecutingAssembly());

        string myString =
            String.Format(resourceManager.GetString(Key), arg0);

        return myString;
    }
}