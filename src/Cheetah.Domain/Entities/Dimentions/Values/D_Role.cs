namespace Cheetah.Domain.Entities.Dimentions;
public partial class D_Role
{
    #region Values

    public static readonly Dimentions.D_Role Requestor =
           new Dimentions.D_Role
           {
               Id = 100,
               ERPCode = 100,
               SortIndex = 100,
               Name = nameof(Requestor),
               DisplayName = "درخواست کننده",
               FixedRole = true
           };

    public static readonly Dimentions.D_Role RequestorManager =
         new Dimentions.D_Role
         {
             Id = 101,
             ERPCode = 101,
             SortIndex = 101,
             Name = nameof(RequestorManager),
             DisplayName = "مدیر درخواست کننده",
             FixedRole = true
         };
    #endregion
}