namespace Cheetah.Domain.Entities.Links;

public class L_ProcessScenario : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual D_Process? Process { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Scenario? Scenario { get; set; }

    public L_ProcessScenario ShallowCopy()
    {
        return (L_ProcessScenario)MemberwiseClone();
    }
    #region Values
    public static readonly L_ProcessScenario SampleProcess_SampleScenario =
        new L_ProcessScenario
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(SampleProcess_SampleScenario),
            DisplayName = "فرآیند نمونه-سناریو نمونه",
            FirstId = 1,
            SecondId = 1
        };
    #endregion
}