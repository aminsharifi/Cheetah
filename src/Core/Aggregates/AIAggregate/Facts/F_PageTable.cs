using Cheetah.Core.Common;
namespace Cheetah.Core.Aggregates.AIAggregate.Facts;

public partial class F_PageTable : BaseEntity, IAggregateRoot
{
    public F_PageTable()
    {

    }

    #region Simple Prob
    public string Policy { get; private set; }
    public string Icon { get; private set; }
    public string JsonData { get; private set; }
    #endregion

    #region Relations
    public virtual ICollection<F_UserGuide>? UserGuides { get; set; } = new HashSet<F_UserGuide>();
    #endregion

    public F_PageTable SetJsonData(string? jsonData)
    {
        JsonData = jsonData;
        return this;
    } 
    public F_PageTable SetPolicy(string? policy)
    {
        Policy = policy;
        return this;
    }
    public F_PageTable SetIcon(string? icon)
    {
        Icon = icon;
        return this;
    }
}