namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_ParameterList")]
    public partial class P_ParameterList : BasePSClass
    {
        #region Relation

        #region Entity

        #region PL_ParameterType
        public long PL_idParameterType { get; set; }
        [ForeignKey("PL_idParameterType")]
        public virtual P_ParameterType? PL_ParameterType { get; set; }
        #endregion

        #endregion

        #region Collection

        #endregion

        #endregion
    }
}
