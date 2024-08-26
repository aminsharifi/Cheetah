namespace Cheetah.Core.Aggregates.ProcessAggregate.Facts;
public partial class F_Form
{
    #region Values

    public static readonly F_Form ExpertForm =
        ((F_Form)new F_Form()
        .SetId(1)
        .SetSortIndex(1)
        .SetERPCode(-1)
        .SetName(nameof(ExpertForm))
        .SetDisplayName("اقدام کارشناسی"));

    public static readonly F_Form ReviewForm =
     ((F_Form)new F_Form()
     .SetId(2)
     .SetSortIndex(2)
     .SetERPCode(-2)
     .SetName(nameof(ReviewForm))
     .SetDisplayName("بررسی درخواست"));

    #endregion
}