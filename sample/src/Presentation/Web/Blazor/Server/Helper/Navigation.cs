using Cheetah.Core.Resx;
using Localization = Cheetah.Sample.Presentation.Web.Blazor.Server.Resx.Localization;
namespace Cheetah.Sample.Presentation.Web.Blazor.Server.Helper;
public enum CNavigationEnum
{
    complete,
    current,
    future
}
public class CNavigationStruct(long? id, string address, string displayName, string Reference)
{
    public long? Id { get; set; } = id;
    public string Address { get; set; } = address;
    public string DisplayName { get; set; } = displayName;
    public CNavigationEnum? _CNavigationEnum { get; set; } = CNavigationEnum.current;
    public string Reference { get; set; } = Reference;

}
public class CNavigation
{
    public List<CNavigationStruct> NavigationList { get; set; }

    public IGlobalization iGlobalization =
        new Globalization(nameof(Cheetah) + "." + nameof(Cheetah.Sample) + "." +
            nameof(Presentation) + "." + nameof(Web) + "." +
            nameof(Blazor) + "." + nameof(Server));

    public CNavigation()
    {
        NavigationList = new();
    }
    public void AddNavigation(CNavigationStruct navigationStruct)
    {
        NavigationList.ForEach(x => x._CNavigationEnum = CNavigationEnum.complete);
        NavigationList.Add(
            new CNavigationStruct(
                id: navigationStruct.Id,
                address: navigationStruct.Address,
                displayName: navigationStruct.DisplayName,
                Reference: navigationStruct.Reference)
            );
    }
    public void BackNavigation(NavigationManager _NavigationManager)
    {
        var LastRecord = NavigationList.SkipLast(1).Last();

        RemoveNavigation();

        _NavigationManager.NavigateTo($"{LastRecord.Address}/{LastRecord.Reference}");
    }
    public void RemoveNavigation()
    {
        NavigationList.RemoveAt(NavigationList.Count - 1);
        NavigationList.RemoveAt(NavigationList.Count - 1);
    }
    public string Serialize()
    {
        return Convert.ToBase64String(
         Encoding.UTF8.GetBytes(JsonSerializer
         .Serialize(NavigationList)));
    }
    public void Deserialize(string jsonString)
    {
        NavigationList =
        JsonSerializer
         .Deserialize<List<CNavigationStruct>>
             (Convert.FromBase64String(jsonString));
    }
    public string LoadNavigation(string Address, string RowDescription, long? RowId, string Reference)
    {
        var ttt = iGlobalization.GetValue(nameof(Localization.BlazorServer_InsertRow));

        if (!string.IsNullOrEmpty(Reference))
            Deserialize(Reference);

        var PDescription = RowId > 0 ?
            iGlobalization.GetValue(nameof(Localization.BlazorServer_RowDescId), new[] { RowDescription }) :
            Address.StartsWith("List/") ?
            iGlobalization.GetValue(nameof(Localization.BlazorServer_Tablelist)) :
            iGlobalization.GetValue(nameof(Localization.BlazorServer_InsertRow));

        if (!RowId.HasValue)
            PDescription = iGlobalization.GetValue(nameof(Localization.BlazorServer_TableDescription), new string[] { RowDescription });

        AddNavigation(new CNavigationStruct(
        id: RowId,
        address: Address,
        displayName: PDescription,
        Reference: Reference
        ));

        return Serialize();
    }

}