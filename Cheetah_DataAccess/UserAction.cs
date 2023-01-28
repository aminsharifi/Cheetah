namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserAction")]
    public partial class UserAction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserAction()
        {
            Approves = new HashSet<Approve>();
            CurrentProcessEndorsemen = new HashSet<CurrentProcessEndorseman>();
        }

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idUserAction { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Simple Prob
        public byte? UserAction_Code { get; set; }

        [StringLength(50)]
        public string UserAction_Name { get; set; }

        public int? UserAction_SortIndex { get; set; }


        public int? ERPCode { get; set; }

        [StringLength(50)]
        public string UserAction_ValidActions { get; set; }

        [StringLength(200)]
        public string UserAction_Abbreviation { get; set; }
        #endregion

        #region Relations
        #region Entity
        public long? UserActionGroup { get; set; }
        public virtual UserActionGroup UserActionGroup1 { get; set; }
        #endregion
        #region Collections
        public virtual ICollection<Approve> Approves { get; set; }
        public virtual ICollection<CurrentProcessEndorseman> CurrentProcessEndorsemen { get; set; }
        #endregion
        #endregion

    }
}
