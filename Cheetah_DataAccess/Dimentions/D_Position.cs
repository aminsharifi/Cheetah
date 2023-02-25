namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Facts;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_Position", Schema = "Dimentions")]
    public partial class D_Position : BaseClass<D_Position>
    {
        [Column(Order = 100)]
        public Boolean? PSO_Independent_Location { get; set; } = false;
        [Column(Order = 101)]
        public virtual D_Location? PSO_Default_Location { get; set; }
        public virtual ICollection<F_UserSkill>? PSO_UserSkills { get; set; } = new HashSet<F_UserSkill>();
        public virtual ICollection<F_RolePosition>? PSO_RolePositions { get; set; } = new HashSet<F_RolePosition>();
        public virtual ICollection<F_EndorsementPosition>? PSO_EndorsementPosition { get; set; } = new HashSet<F_EndorsementPosition>();
    }
}