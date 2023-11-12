namespace Cheetah.Domain.Links;

public partial class L_UserLocation : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual D_User? User { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual D_Location? Location { get; set; }

    public L_UserLocation ShallowCopy()
    {
        return (L_UserLocation)this.MemberwiseClone();
    }

}