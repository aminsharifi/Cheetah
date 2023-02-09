namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("M_Attachment", Schema ="Masters")]

    public partial class M_Attachment: BasePSClass
    {
        //Passed 

        #region Basic Prop
        [Description("نام ضمیمه")]
        [StringLength(255)]
        public String? ATC_Name { get; set; }
        [Description("ضمیمه")]
        public byte[]? ATC_Data { get; set; }
        #endregion

    }
}
