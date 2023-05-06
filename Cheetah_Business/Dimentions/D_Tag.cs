using Cheetah_Business.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Dimentions
{
    [Table(nameof(D_Tag), Schema = nameof(TableType.Dimentions))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class D_Tag : BaseClass<D_Tag>
    {
        #region Relation

        #region Entity
        [Column(Order = 100)]
        public long? TG_TagTypeId { get; set; }
        public virtual D_TagType TG_TagType { get; set; }

        #endregion

        #region Collection
        #endregion

        #endregion
    }
}
