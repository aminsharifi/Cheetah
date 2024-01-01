namespace Cheetah.Domain.Entities.Dimentions;
public class D_Position : SimpleClass
{
    public virtual ICollection<L_UserPosition>? UserPositions { get; set; } = new HashSet<L_UserPosition>();

    public virtual ICollection<L_RolePosition>? RolePositions { get; set; } = new HashSet<L_RolePosition>();

    #region Values

    public static readonly D_Position Expert =
         new D_Position
         {
             Id = 1,
             ERPCode = 1,
             SortIndex = 1,
             Name = nameof(Expert),
             DisplayName = "کارشناس"
         };

    #endregion
}