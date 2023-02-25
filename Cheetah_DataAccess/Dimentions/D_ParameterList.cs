namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_ParameterList", Schema = "Dimentions")]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class D_ParameterList : BaseClass<D_ParameterList>
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
