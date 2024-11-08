using Cheetah.Core.Common;
namespace Cheetah.Core.Aggregates.AIAggregate.Facts;

public partial class F_UserGuide : BaseEntity, IAggregateRoot
{
    public F_UserGuide()
    {

    }

    #region Simple Prob
    public string Subject { get; private set; }
    public string Description { get; private set; }
    public string Keywords { get; private set; }
    public string Body { get; private set; }
    #endregion

    #region Relations

    #endregion

    public F_UserGuide SetSubject(string subject)
    {
        Subject = subject;
        return this;
    }
    public F_UserGuide SetDescription(string description)
    {
        Description = description;
        return this;
    }
    public F_UserGuide SetKeywords(string keywords)
    {
        Keywords = keywords;
        return this;
    }
    public F_UserGuide SetBody(string body)
    {
        Body = body;
        return this;
    }
}