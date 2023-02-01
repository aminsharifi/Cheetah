namespace Cheetah_DataAccess.Systems
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OrgPosition")]
    public partial class S_OrgPosition: BasePSClass
    {
        #region Simple Prop


        #endregion

        #region Relation

        #region Entity
        public long? POS_idOrg { get; set; }

        #endregion

        #region Collection
        
        #endregion

        #endregion

    }
}
