namespace Cheetah.Domain.Entities.Dimentions;

public class D_Process : SimpleClass
{
    #region Simple Prob

    #region Others
    public bool? ShowSupport { get; set; } = true;
    public bool? ERP { get; set; } = true;
    public bool? RemoveRequestorApproval { get; set; } = true;

    #endregion

    #endregion

    #region Relations
    public virtual ICollection<L_ProcessScenario>? ProcessScenario { get; set; } = new HashSet<L_ProcessScenario>();
    #endregion

    #region Values
    public static readonly D_Process SampleProcess =
          new D_Process
          {
              Id = 1,
              ERPCode = 1,
              SortIndex = 1,
              Name = nameof(SampleProcess),
              DisplayName = "فرآیند نمونه",
          };
    #endregion
}