using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Facts;

[Table(nameof(F_Request), Schema = nameof(TableType.Facts))]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
public partial class F_Request : BaseClass<F_Request>
{
    #region S_User
    [Column(Order = 106)]
    public long? RQT_RequestorId { get; set; }
    public virtual D_User? RQT_Requestor { get; set; }

    [Column(Order = 107)]
    public long? RQT_CreatorId { get; set; }
    public virtual D_User? RQT_Creator { get; set; }

    #endregion

    #region Enitty       

    [Description("وضعیت فرآیند")]
    [Column(Order = 110)]
    [DefaultValue(1)]
    public long? RQT_ProcessStateId { get; set; }
    public virtual D_ProcessState? RQT_ProcessState { get; set; }

    [Description("نام فرآیند")]
    [Column(Order = 111)]
    public long? RQT_ProcessId { get; set; }
    public virtual D_Process? RQT_Process { get; set; }

    [Column(Order = 112)]
    public long? RQT_Current_ReviewId { get; set; }
    public virtual F_Review? RQT_Current_Review { get; set; }

    [Column(Order = 113)]
    public long? RQT_SelectedScenarioId { get; set; }
    public virtual F_Scenario? RQT_SelectedScenario { get; set; }

    [Column(Order = 114)]
    public long? RQT_CurrentAssignmentId { get; set; }
    public virtual F_Assignment? RQT_CurrentAssignment { get; set; }
    #endregion

    #region Collection
    public virtual ICollection<F_Condition>? RQT_Conditions { get; set; } = new HashSet<F_Condition>();

    [InverseProperty(nameof(F_Assignment.PRM_Request))]
    public virtual ICollection<F_Assignment>? RQT_Assignments { get; set; } = new HashSet<F_Assignment>();

    [InverseProperty(nameof(F_Review.APV_Request))]
    public virtual ICollection<F_Review>? RQT_Reviews { get; set; } = new HashSet<F_Review>();
    #endregion
}