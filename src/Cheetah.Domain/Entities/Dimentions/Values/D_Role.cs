namespace Cheetah.Domain.Entities.Dimentions;
public partial class D_Role
{
    #region Values

    public static readonly D_Role Requestor =
           new()
           {
               Id = 100,
               ERPCode = 100,
               SortIndex = 1,
               Name = nameof(Requestor),
               DisplayName = "درخواست کننده",
               FixedRole = true
           };

    public static readonly D_Role RequestorManager =
         new()
         {
             Id = 101,
             ERPCode = 101,
             SortIndex = 2,
             Name = nameof(RequestorManager),
             DisplayName = "مدیر درخواست کننده",
             FixedRole = true
         };
    #endregion
}