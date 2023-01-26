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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idUserAction { get; set; }

        public int? finalEnt { get; set; }

        public Guid guidUserAction { get; set; }

        public bool dsblUserAction { get; set; }

        public byte dplyUserAction { get; set; }

        public byte? UserAction_Code { get; set; }

        [StringLength(50)]
        public string UserAction_Name { get; set; }

        public int? UserAction_SortIndex { get; set; }

        public long? UserActionGroup { get; set; }

        public int? ERPCode { get; set; }

        [StringLength(50)]
        public string UserAction_ValidActions { get; set; }

        [StringLength(200)]
        public string UserAction_Abbreviation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Approve> Approves { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurrentProcessEndorseman> CurrentProcessEndorsemen { get; set; }

        public virtual UserActionGroup UserActionGroup1 { get; set; }
    }
}
