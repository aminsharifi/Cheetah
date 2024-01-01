namespace Cheetah.Domain.Entities.Dimentions;
public class D_Role : SimpleClass
{
    public bool Independent { get; set; } = false;
    public bool FixedRole { get; set; } = false;

    #region Collection
    public virtual ICollection<L_RolePosition>? RolePositions { get; set; } = new HashSet<L_RolePosition>();

    #endregion

    #region Values

    public static readonly D_Role Requestor =
           new D_Role
           {
               Id = 100,
               ERPCode = 100,
               SortIndex = 100,
               Name = nameof(Requestor),
               DisplayName = "درخواست کننده",
               FixedRole = true
           };

    public static readonly D_Role RequestorManager =
         new D_Role
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