namespace Cheetah.Domain.Entities.Dimentions;
public partial class D_WorkItemState : BaseEntity
{
    public D_WorkItemState()
    {
        
    }
    public D_WorkItemState(Int64 id, String name, String displayName, Int64 sortIndex, Int64 eRPCode) : base(id, name, displayName, sortIndex, eRPCode)
    {

    }
    #region Relations

    #endregion
}