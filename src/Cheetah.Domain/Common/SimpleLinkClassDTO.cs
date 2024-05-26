namespace Cheetah.Domain.Common;

public class SimpleLinkClassDTO : SimpleLinkClass
{
    public SimpleLinkClassDTO(long? firstId, long? secondId) : base(firstId: firstId, secondId: secondId)
    {

    }
    public SimpleLinkClassDTO(long? firstId, long? secondId, long? eRPCode,bool enableRecord) :
        base(firstId: firstId, secondId: secondId, eRPCode: eRPCode,enableRecord: enableRecord)
    {

    }
}