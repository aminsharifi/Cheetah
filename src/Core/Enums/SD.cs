using Cheetah.Core.Resx;

namespace Cheetah.Core.Enums;

public class UpsertStatus
{
    public IGlobalization iGlobalization = new Globalization(nameof(Cheetah) + "." + nameof(Core));

    public KeyValuePair<CrudOperation, string> GetPageTitle(long? id)
    {
        if (id == 0)
        {
            return new KeyValuePair<CrudOperation, string>(CrudOperation.Create, GlobalizationService.GetValue(Localization.Core_Create));
        }
        else
        {
            return new KeyValuePair<CrudOperation, string>(CrudOperation.Update, GlobalizationService.GetValue(Localization.Core_Update));
        }
    }
}