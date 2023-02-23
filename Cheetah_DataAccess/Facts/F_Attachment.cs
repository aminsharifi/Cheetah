namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_Attachment", Schema = "Facts")]

    public partial class F_Attachment: BaseDimClass
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
