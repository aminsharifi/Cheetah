namespace Cheetah.Core.Common;

public abstract class BaseLink : BaseEntity
{
    public BaseLink()
    {

    }

    public long? FirstId { get; private set; }

    public long? SecondId { get; private set; }

    public long? ThirdId { get; private set; }

    public long? FourthId { get; private set; }

    public long? FifthId { get; private set; }

    public BaseLink SetFirstId(long? firstId)
    {
        FirstId = firstId;
        return this;
    }
    public BaseLink SetSecondId(long? secondId)
    {
        SecondId = secondId;
        return this;
    }
    public BaseLink SetThirdId(long? thirdId)
    {
        ThirdId = thirdId;
        return this;
    }
}