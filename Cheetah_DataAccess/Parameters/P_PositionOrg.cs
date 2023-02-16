namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Masters;
    using Cheetah_DataAccess.Systems;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_PositionOrg", Schema = "Parameters")]
    public partial class P_PositionOrg : BasePSClass
    {
        public Boolean? PSO_Independent_Location { get; set; } = false;
        public virtual S_Location? PSO_Default_Location { get; set; }
        public virtual ICollection<S_User>? PSO_Users { get; set; }= new HashSet<S_User>();
        public virtual ICollection<S_Role>? PSO_Role { get; set; } = new HashSet<S_Role>();
    }
}
