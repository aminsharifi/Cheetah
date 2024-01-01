namespace Cheetah.Domain.Entities.Dimentions;

public class D_UserInformation : SimpleClass
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public bool? NotifByEmail { get; set; }
    public bool? NotifByMessenger { get; set; }
    public bool? NotifByCell { get; set; }
    public string? ContactEmail { get; set; }
    public string? ContactMessenger { get; set; }
    public string? ContactCell { get; set; }
    public byte[]? UserPicture { get; set; }
    public string? NationalCode { get; set; }
    public DateTime? Birthdate { get; set; }
    public string? InternalPhone { get; set; }
    public string? Address { get; set; }
    public string? RegistrationNumber { get; set; }

    public D_UserInformation ShallowCopy()
    {
        return (D_UserInformation)MemberwiseClone();
    }
}