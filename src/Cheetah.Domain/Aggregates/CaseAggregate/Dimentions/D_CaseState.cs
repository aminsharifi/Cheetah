namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_CaseState : BaseEntity
{
    #region Relations
    public D_CaseState()
    {

    }
    public D_CaseState(Int64 id, String name, String displayName, Int64 sortIndex, Int64 eRPCode) : base(id, name, displayName, sortIndex, eRPCode)
    {

    }
    #endregion
}