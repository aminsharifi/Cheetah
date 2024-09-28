using Cheetah.Core.Common;
using Cheetah.Core.Enums;

namespace Cheetah.Core.Aggregates.Common.Dimentions;

public partial class D_Entity : BaseEntity
{
    public D_Entity()
    {
    }
    public D_Entity SetDisplay(Boolean display)
    {
        this.Read = display;
        return this;
    }
    public D_Entity SetSync(Boolean sync)
    {
        this.Sync = sync;
        return this;
    }
    public bool? Create { get; private set; } = false;
    public bool? Read { get; private set; } = false;
    public bool? Update { get; private set; } = false;
    public bool? Delete { get; private set; } = false;
    public bool? Sync { get; private set; } = false;
}
public partial class D_Entity
{
    #region Values

    public static readonly D_Entity D_TagType =
        (D_Entity)new D_Entity()
        .SetDisplay(false)
        .SetId(101)
        .SetERPCode(101)
        .SetSortIndex(101)
        .SetName(nameof(D_TagType))
        .SetDisplayName(new StringBuilder()
            .Append("نوع تگ‌ها").Append($"({TableType.Dimentions})")
            .ToString());

    public static readonly D_Entity D_Operand =
        (D_Entity)new D_Entity()
        .SetDisplay(false)
        .SetId(102)
        .SetERPCode(102)
        .SetSortIndex(102)
        .SetName(nameof(D_Operand))
        .SetDisplayName(new StringBuilder()
            .Append("عملگرها").Append($"({TableType.Dimentions})").ToString());

    public static readonly D_Entity D_Tag =
        (D_Entity)new D_Entity()
        .SetDisplay(false)
        .SetId(103)
        .SetERPCode(103)
        .SetSortIndex(103)
        .SetName(nameof(D_Tag))
        .SetDisplayName(new StringBuilder()
            .Append("تگ‌ها").Append($"({TableType.Dimentions})").ToString());

    public static readonly D_Entity D_CaseState =
        (D_Entity)new D_Entity()
        .SetDisplay(false)
        .SetId(104)
        .SetERPCode(104)
        .SetSortIndex(104)
        .SetName(nameof(D_CaseState))
        .SetDisplayName(new StringBuilder()
            .Append("وضعیت فرآیندها").Append($"({TableType.Dimentions})").ToString());

    public static readonly D_Entity D_Process =
        (D_Entity)new D_Entity()
        .SetDisplay(true)
        .SetId(105)
        .SetERPCode(105)
        .SetSortIndex(105)
        .SetName(nameof(D_Process))
        .SetDisplayName(new StringBuilder()
            .Append("فرآیند‌ها").Append($"({TableType.Dimentions})").ToString());

    public static readonly D_Entity D_User =
        (D_Entity)new D_Entity()
        .SetDisplay(false)
        .SetId(106)
        .SetERPCode(106)
        .SetSortIndex(106)
        .SetName(nameof(D_User))
        .SetDisplayName(new StringBuilder()
            .Append("کاربران").Append($"({TableType.Dimentions})").ToString());

    public static readonly D_Entity D_UserInformation =
        (D_Entity)new D_Entity()
        .SetDisplay(false)
        .SetId(107)
        .SetERPCode(107)
        .SetSortIndex(107)
        .SetName(nameof(D_UserInformation))
        .SetDisplayName(new StringBuilder()
            .Append("اطلاعات کاربرها").Append($"({TableType.Dimentions})").ToString());

    public static readonly D_Entity F_WorkItem =
        (D_Entity)new D_Entity()
        .SetDisplay(false)
        .SetId(108)
        .SetERPCode(108)
        .SetSortIndex(108)
        .SetName(nameof(F_WorkItem))
        .SetDisplayName(new StringBuilder()
            .Append("تمام تاییدها").Append($"({TableType.Facts})").ToString());

    public static readonly D_Entity F_Attachment =
        (D_Entity)new D_Entity()
        .SetDisplay(false)
        .SetId(109)
        .SetERPCode(109)
        .SetSortIndex(109)
        .SetName(nameof(F_Attachment))
        .SetDisplayName(new StringBuilder()
            .Append("ضمیمه‌ها").Append($"({TableType.Facts})").ToString());

    public static readonly D_Entity F_Task =
        (D_Entity)new D_Entity()
        .SetDisplay(false)
        .SetId(110)
        .SetERPCode(110)
        .SetSortIndex(110)
        .SetName(nameof(F_Task))
        .SetDisplayName(new StringBuilder()
            .Append("لیست تخصیص‌ها").Append($"({TableType.Facts})").ToString());

    public static readonly D_Entity F_Condition =
      (D_Entity)new D_Entity()
        .SetDisplay(true)
        .SetId(111)
        .SetERPCode(111)
        .SetSortIndex(111)
        .SetName(nameof(F_Condition))
        .SetDisplayName(new StringBuilder()
          .Append("لیست شرط‌ها").Append($"({TableType.Facts})").ToString());


    public static readonly D_Entity F_Case =
        (D_Entity)new D_Entity()
        .SetDisplay(false)
        .SetId(112)
        .SetERPCode(112)
        .SetSortIndex(112)
        .SetName(nameof(F_Case))
        .SetDisplayName(new StringBuilder()
            .Append("اطلاعات درخواست‌ها").Append($"({TableType.Dimentions})").ToString());


    public static readonly D_Entity F_Scenario =
        (D_Entity)new D_Entity()
        .SetDisplay(true)
        .SetId(113)
        .SetERPCode(113)
        .SetSortIndex(113)
        .SetName(nameof(F_Scenario))
        .SetDisplayName(new StringBuilder()
            .Append("سناریوها").Append($"({TableType.Dimentions})").ToString());

    public static readonly D_Entity L_ProcessScenario =
        (D_Entity)new D_Entity()
        .SetSync(false)
        .SetDisplay(false)
        .SetId(114)
        .SetERPCode(114)
        .SetSortIndex(114)
        .SetName(nameof(L_ProcessScenario))
        .SetDisplayName(new StringBuilder()
            .Append("سناریوها").Append($"({TableType.Links})").ToString());


    public static readonly D_Entity F_Form =
        (D_Entity)new D_Entity()
        .SetSync(true)
        .SetDisplay(false)
        .SetId(115)
        .SetERPCode(115)
        .SetSortIndex(115)
        .SetName(nameof(F_Form))
        .SetDisplayName(new StringBuilder()
            .Append("فرم‌ها").Append($"({TableType.Facts})").ToString());

    #endregion
}