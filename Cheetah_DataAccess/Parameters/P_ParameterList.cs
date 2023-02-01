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

               
        #endregion        

        #region Collection
        public virtual ICollection<P_ParameterType> PL_ParameterType { get; set; } = new List<P_ParameterType>();
        #endregion

        #endregion
    }
}
