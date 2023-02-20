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
        [Column(Order = 100)]
        public Boolean? PSO_Independent_Location { get; set; } = false;
        [Column(Order = 101)]
        public virtual S_Location? PSO_Default_Location { get; set; }
        public virtual ICollection<S_UserSkill>? PSO_S_UserSkills { get; set; } = new HashSet<S_UserSkill>();
        public virtual ICollection<P_RolePosition>? PSO_P_RolePositions { get; set; } = new HashSet<P_RolePosition>();
        public virtual ICollection<P_EndorsementPosition>? PSO_P_EndorsementPosition { get; set; } = new HashSet<P_EndorsementPosition>();
    }
}
