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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idUserActionGroup { get; set; }

        public int? finalEnt { get; set; }

        public Guid guidUserActionGroup { get; set; }

        public bool dsblUserActionGroup { get; set; }

        public byte dplyUserActionGroup { get; set; }

        public byte? UserActionGroup_Code { get; set; }

        [StringLength(50)]
        public string UserActionGroup_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAction> UserActions { get; set; }
    }
}
