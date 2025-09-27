using Cheetah.Core.Common;
namespace Cheetah.Core.Aggregates.AIAggregate.Facts;

public partial class F_UserGuide : BaseEntity, IAggregateRoot
{
    public F_UserGuide()
    {

    }

    #region Simple Prob
    public string Body { get; private set; }
    public byte[] VectorBody { get; set; } // Store as VARBINARY
    public string JsonData { get; private set; }
    public virtual F_PageTable? PageTable { get; private set; }
    public long? PageTableId { get; private set; }

    #endregion

    #region Relations

    #endregion

    public F_UserGuide SetJsonData(string jsonData)
    {
        JsonData = jsonData;
        return this;
    }
    public F_UserGuide SetPageTableId(long pageTableId)
    {
        PageTableId = pageTableId;
        return this;
    }
    public F_UserGuide SetBody(string body)
    {
        Body = body;
        return this;
    }
}