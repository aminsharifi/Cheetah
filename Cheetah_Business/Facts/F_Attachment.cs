using Cheetah_Business.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Facts
{

    [Table(nameof(F_Attachment), Schema = nameof(TableType.Facts))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class F_Attachment: BaseClass<F_Attachment>
    {
        //Passed 

        #region Basic Prop
        [Description("نام ضمیمه")]
        [StringLength(255)]
        [Column(Order = 100)]
        public String? ATC_Name { get; set; }

        [Description("ضمیمه")]
        [Column(Order = 101)]
        public byte[]? ATC_Data { get; set; }
        #endregion

    }
}
