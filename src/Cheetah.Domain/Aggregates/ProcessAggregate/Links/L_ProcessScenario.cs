namespace Cheetah.Domain.Entities.Links;

public partial class L_ProcessScenario : SimpleLinkClass
{
    public L_ProcessScenario()
    {
        
    }
    public L_ProcessScenario(Int64 id, String name, String displayName,
        Int64 sortIndex, Int64 eRPCode, Int64 firstId, Int64 secondId) : base(id, name, displayName, sortIndex, eRPCode, firstId, secondId)
    {
    }

    public virtual D_Process? Process { get; private set; }

    public virtual F_Scenario? Scenario { get; private set; }

    public L_ProcessScenario ShallowCopy()
    {
        return (L_ProcessScenario)MemberwiseClone();
    }
}