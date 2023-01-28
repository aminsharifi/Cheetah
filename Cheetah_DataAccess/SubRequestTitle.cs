namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class SubRequestTitle
    {

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idSubRequestTitles { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Simple Prob
        [Description("کد زیرفرآیند")]
        public int? SRT_Code { get; set; }

        [StringLength(200)]
        [Description("نام زیرفرآیند")]
        public string SRT_Name { get; set; }
        #endregion

        #region Relations
        [Description("نام فرآیند")]
        public virtual RequestTitle RequestTitles { get; set; } 
        #endregion
    }
}
