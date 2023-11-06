namespace Cheetah.Domain.Data;

public abstract class SimpleLinkClass : SimpleClass
{
    [Column(Order = 50)]
    public Int64? FirstId { get; set; }

    [Column(Order = 51)]
    public Int64? SecondId { get; set; }
}