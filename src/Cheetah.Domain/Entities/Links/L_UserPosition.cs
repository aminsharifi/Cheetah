namespace Cheetah.Domain.Entities.Links;

public partial class L_UserPosition : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual D_User? User { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual D_Position? Position { get; set; }

    public L_UserPosition ShallowCopy()
    {
        return (L_UserPosition)MemberwiseClone();
    }
}