namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ProcessState
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcessState()
        {

        }


        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idProcessState { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Simple Prob
        [Description("کد وضعیت فرآیند")]
        public int? PS_Code { get; set; }

        [StringLength(50)]
        [Description("وضعیت فرآیند")]
        public string PS_Name { get; set; }

        [Description("کد ERP")]
        public int? PS_ERP { get; set; }

        #endregion
        #region Relations

        #endregion
    }
}
