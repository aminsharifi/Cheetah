namespace Cheetah.Domain.Links;

[Index(nameof(FirstId), IsUnique = false, AllDescending = true)]
[Index(nameof(SecondId), IsUnique = false, AllDescending = true)]
public partial class L_UserLocation : SimpleLinkClass
{
    [Column(Order = 100)]
    [ForeignKey(nameof(FirstId))]
    public virtual D_User? User { get; set; }

    [Column(Order = 101)]
    [ForeignKey(nameof(SecondId))]
    public virtual D_Location? Location { get; set; }

    public L_UserLocation ShallowCopy()
    {
        return (L_UserLocation)this.MemberwiseClone();
    }

}