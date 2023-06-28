using Cheetah_Business.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cheetah_Business.Dimentions;

[Table(nameof(D_Entity), Schema = nameof(TableType.Dimentions))]
[Index(nameof(PName), IsUnique = true, AllDescending = true)]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
[Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
public partial class D_Entity : BaseClass<D_Entity>
{
    [Column(Order = 100)]
    [DefaultValue(true)]
    public bool? Display { get; set; }
}