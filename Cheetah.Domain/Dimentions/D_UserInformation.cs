namespace Cheetah.Domain.Dimentions;

public partial class D_UserInformation : SimpleClass
{
    public String? FirstName { get; set; }
    public String? LastName { get; set; }   
    public Boolean? NotifByEmail { get; set; }
    public Boolean? NotifByMessenger { get; set; }
    public Boolean? NotifByCell { get; set; }
    public String? ContactEmail { get; set; }
    public String? ContactMessenger { get; set; }
    public String? ContactCell { get; set; }
    public Byte[]? UserPicture { get; set; }  
    public String? NationalCode { get; set; }
    public DateTime? Birthdate { get; set; }
    public String? InternalPhone { get; set; }   
    public String? Address { get; set; }
    public String? RegistrationNumber { get; set; }

    public D_UserInformation ShallowCopy()
    {
        return (D_UserInformation)this.MemberwiseClone();
    }
}