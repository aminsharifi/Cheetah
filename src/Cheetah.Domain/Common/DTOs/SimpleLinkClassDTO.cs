namespace Cheetah.Domain.Common.DTOs;

public class SimpleLinkClassDTO : SimpleClassDTO
{
    public BaseClassDTO? First { get; set; }
    public BaseClassDTO? Second { get; set; }
    public long? FirstId { get; set; }
    public long? SecondId { get; set; }
    public long? ThirdId { get; set; }
    public long? FourthId { get; set; }
    public long? FifthId { get; set; }
}