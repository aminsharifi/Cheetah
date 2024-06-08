namespace Cheetah.Domain.Common;

public abstract class SimpleLinkClass : BaseEntity
{
    public SimpleLinkClass()
    {

    }
    public SimpleLinkClass(Int64? secondId)
    {
        SecondId = secondId;
    }
    public SimpleLinkClass(Int64? firstId, Int64? secondId)
    {
        SetFirstAndSecond(firstId, secondId);
    }

    public SimpleLinkClass(Int64? firstId, Int64? secondId, long? eRPCode, bool enableRecord)
        : base(eRPCode, enableRecord)
    {
        SetFirstAndSecond(firstId, secondId);
    }
    public void SetFirstAndSecond(Int64? firstId, Int64? secondId)
    {
        FirstId = firstId;
        SecondId = secondId;
    }
    public void SetFirstId(Int64? firstId)
    {
        FirstId = firstId;
    }
    public void SetSecondId(Int64? secondId)
    {
        SecondId = secondId;
    }
    public SimpleLinkClass(Int64? firstId, Int64? secondId, Int64? thirdId)
    {
        FirstId = firstId;
        SecondId = secondId;
        ThirdId = thirdId;
    }
    public SimpleLinkClass(Int64 id, String? name, String? displayName, Int64? sortIndex, Int64? eRPCode,
        Int64? firstId, Int64? secondId)
        : base(id, name, displayName, sortIndex, eRPCode)
    {
        FirstId = firstId;
        SecondId = secondId;
    }

    public Int64? FirstId { get; private set; }

    public Int64? SecondId { get; private set; }

    public Int64? ThirdId { get; private set; }

    public Int64? FourthId { get; private set; }

    public Int64? FifthId { get; private set; }
}