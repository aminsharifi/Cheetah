namespace Cheetah.Domain.Links;

[Index(nameof(FirstId), IsUnique = false, AllDescending = true)]
[Index(nameof(SecondId), IsUnique = false, AllDescending = true)]
public partial class L_UserPosition : SimpleLinkClass
{
    [Column(Order = 101)]
    [ForeignKey(nameof(FirstId))]
    public virtual D_User? User { get; set; }

    [Column(Order = 100)]
    [ForeignKey(nameof(SecondId))]
    public virtual D_Position? Position { get; set; }

    public L_UserPosition ShallowCopy()
    {
        return (L_UserPosition)this.MemberwiseClone();
    }
}