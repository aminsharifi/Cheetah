using Microsoft.AspNetCore.Components;
using System.Text;
using System.Web;
using System.Xml.Linq;

namespace Cheetah_Common
{
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
        public CNavigationEnum? CNavigationEnum { get; set; }

        public CNavigationStruct(Int64? id, String address, String displayName)
        {
            this.Id = id;
            this.Address = address;
            this.DisplayName = displayName;
            this.CNavigationEnum = Cheetah_Common.CNavigationEnum.current;
        }
    }
    public class CNavigation
    {
        public List<CNavigationStruct> NavigationList { get; set; }
        public CNavigation()
        {
            NavigationList = new();
        }
        public void AddNavigation(CNavigationStruct navigationStruct)
        {
            NavigationList.ForEach(x => x.CNavigationEnum = CNavigationEnum.complete);
            this.NavigationList.Add(
                new CNavigationStruct(
                    id: navigationStruct.Id,
                    address: navigationStruct.Address,
                    displayName: navigationStruct.DisplayName)
                );
        }
        public void BackNavigation(NavigationManager _NavigationManager, String Name)
        {
            RemoveNavigation();

            _NavigationManager.NavigateTo(Name + (NavigationList.Any() ? @"\" +Serialize() : ""));
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
        public void LoadNavigation(String TableName, String RowDescription, Int64? RowId, String reference)
        {
            if (!string.IsNullOrEmpty(reference))
                Deserialize(reference);

            var PDescription = (RowId > 0) ? $"ردیف '{RowDescription}'" : "ایجاد ردیف";

            if (!RowId.HasValue)
                PDescription = $"جدول {TableName}";

            this.AddNavigation(new CNavigationStruct(
            id: RowId,
            address: TableName,
            displayName: PDescription
       ));
        }

    }
}
