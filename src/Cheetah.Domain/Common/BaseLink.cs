
namespace Cheetah.Domain.Common;

public abstract class BaseLink : BaseEntity
{
    public BaseLink()
    {

    }

    public Int64? FirstId { get; private set; }

    public Int64? SecondId { get; private set; }

    public Int64? ThirdId { get; private set; }

    public Int64? FourthId { get; private set; }

    public Int64? FifthId { get; private set; }

    public BaseLink SetFirstId(Int64? firstId)
    {
        this.FirstId = firstId;
        return this;
    }
    public BaseLink SetSecondId(Int64? secondId)
    {
        this.SecondId = secondId;
        return this;
    }
    public BaseLink SetThirdId(Int64? thirdId)
    {
        this.ThirdId = thirdId;
        return this;
    }
}