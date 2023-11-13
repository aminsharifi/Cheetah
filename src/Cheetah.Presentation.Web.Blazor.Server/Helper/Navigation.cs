using System.Text;

namespace Cheetah.Presentation.Web.Blazor.Server.Helper;
public enum CNavigationEnum
{
    complete,
    current,
    future
}
public class CNavigationStruct
{
    public Int64? Id { get; set; }
    public String Address { get; set; }
    public String DisplayName { get; set; }
    public String Reference { get; set; }
    public CNavigationEnum? _CNavigationEnum { get; set; }

    public CNavigationStruct(Int64? id, String address, String displayName, String Reference)
    {
        this.Id = id;
        this.Address = address;
        this.DisplayName = displayName;
        this._CNavigationEnum = CNavigationEnum.current;
        this.Reference = Reference;
    }
}
public class CNavigation
{
    public List<CNavigationStruct> NavigationList { get; set; }

    public IGlobalization iGlobalization = 
        new Globalization(nameof(Cheetah) + "." + nameof(Presentation) + "." + nameof(Web) +
            "." + nameof(Blazor) + "." + nameof(Server));

    public CNavigation()
    {
        NavigationList = new();
    }
    public void AddNavigation(CNavigationStruct navigationStruct)
    {
        NavigationList.ForEach(x => x._CNavigationEnum = CNavigationEnum.complete);
        this.NavigationList.Add(
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
    public String Serialize()
    {
        return System.Convert.ToBase64String(
         Encoding.UTF8.GetBytes(System.Text.Json.JsonSerializer
         .Serialize(NavigationList)));
    }
    public void Deserialize(String jsonString)
    {
        NavigationList =
        System.Text.Json.JsonSerializer
         .Deserialize<List<CNavigationStruct>>
             (System.Convert.FromBase64String(jsonString));
    }
    public String LoadNavigation(String Address, String RowDescription, Int64? RowId, String Reference)
    {
        var ttt = iGlobalization.GetValue(nameof(Localization.BlazorServer_InsertRow) );

        if (!string.IsNullOrEmpty(Reference))
            Deserialize(Reference);

        var PDescription = (RowId > 0) ?
            iGlobalization.GetValue(nameof(Localization.BlazorServer_RowDescId), new[] { RowDescription }) :
            (Address.StartsWith("List/")) ?
            iGlobalization.GetValue(nameof(Localization.BlazorServer_Tablelist) ) :
            iGlobalization.GetValue(nameof(Localization.BlazorServer_InsertRow) );

        if (!RowId.HasValue)
            PDescription = iGlobalization.GetValue(nameof(Localization.BlazorServer_TableDescription), new string[] { RowDescription });

        this.AddNavigation(new CNavigationStruct(
        id: RowId,
        address: Address,
        displayName: PDescription,
        Reference: Reference
        ));

        return this.Serialize();
    }

}