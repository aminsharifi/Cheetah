namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_ParameterList", Schema = "Dimentions")]
    public partial class D_ParameterList : BaseDimClass
    {
        #region Relation

        #region Entity
        [Column(Order = 100)]
        public virtual D_ParameterType? PL_ParameterType { get; set; }

        #endregion

        #region Collection
        #endregion

        #endregion
    }
}
