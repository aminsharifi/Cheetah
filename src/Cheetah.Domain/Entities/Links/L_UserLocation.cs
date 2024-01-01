namespace Cheetah.Domain.Entities.Links;

public class L_UserLocation : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual D_User? User { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual D_Location? Location { get; set; }

    public L_UserLocation ShallowCopy()
    {
        return (L_UserLocation)MemberwiseClone();
    }
    #region Values

    public static readonly L_UserLocation m_sharifi__Fars =
        new L_UserLocation
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(m_sharifi__Fars),
            DisplayName = "محمد شریفی-فارس",
            FirstId = 1,
            SecondId = 1
        };

    public static readonly L_UserLocation a_sharifi__Fars =
        new L_UserLocation
        {
            Id = 2,
            ERPCode = 2,
            SortIndex = 2,
            Name = nameof(a_sharifi__Fars),
            DisplayName = "امین شریفی-فارس",
            FirstId = 2,
            SecondId = 1
        };
    #endregion
}