namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserActionGroup")]
    public partial class UserActionGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserActionGroup()
        {
            UserActions = new HashSet<UserAction>();
        }

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idUserActionGroup { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        public byte? UserActionGroup_Code { get; set; }

        [StringLength(50)]
        public string UserActionGroup_Name { get; set; }


        #region Relations
        public virtual ICollection<UserAction> UserActions { get; set; } 
        #endregion
    }
}
