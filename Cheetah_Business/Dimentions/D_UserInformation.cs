using Cheetah_Business.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Dimentions;

[Table(nameof(D_UserInformation), Schema = nameof(TableType.Dimentions))]
[Index(nameof(Name), IsUnique = true, AllDescending = true)]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(ERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
[Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
public partial class D_UserInformation : BaseClass<D_UserInformation>
{
    [StringLength(50)]
    [Column(Order = 100)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    [Column(Order = 101)]
    public string? LastName { get; set; }
    [Column(Order = 102)]
    public bool? NotifByEmail { get; set; }
    [Column(Order = 103)]
    public bool? NotifByMessenger { get; set; }
    [Column(Order = 104)]
    public bool? NotifByCell { get; set; }

    [StringLength(100)]
    [Column(Order = 105)]
    public string? ContactEmail { get; set; }

    [StringLength(100)]
    [Column(Order = 106)]
    public string? ContactMessenger { get; set; }

    [StringLength(20)]
    [Column(Order = 107)]
    public string? ContactCell { get; set; }
    [Column(Order = 108)]
    public byte[]? UserPicture { get; set; }
    [StringLength(20)]
    [Column(Order = 109)]
    public string? NationalCode { get; set; }
    [Column(Order = 110)]
    public DateTime? Birthdate { get; set; }

    [StringLength(50)]
    [Column(Order = 111)]
    public string? InternalPhone { get; set; }
    [StringLength(512)]
    [Column(Order = 112)]
    public string? Address { get; set; }
    [StringLength(215)]
    [Column(Order = 113)]
    public string? RegistrationNumber { get; set; }
}