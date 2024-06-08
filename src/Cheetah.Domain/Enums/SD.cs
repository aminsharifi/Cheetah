namespace Cheetah.Domain.Enums;

public class UpsertStatus
{
    public IGlobalization iGlobalization = new Globalization(nameof(Cheetah) + "." + nameof(Domain));

    public KeyValuePair<CrudOperation, string> GetPageTitle(long? id)
    {
        if (id == 0)
        {
            return new KeyValuePair<CrudOperation, string>(CrudOperation.Create, GlobalizationService.GetValue(Localization.Domain_Create));
        }
        else
        {
            return new KeyValuePair<CrudOperation, string>(CrudOperation.Update, GlobalizationService.GetValue(Localization.Domain_Update));
        }
    }
}