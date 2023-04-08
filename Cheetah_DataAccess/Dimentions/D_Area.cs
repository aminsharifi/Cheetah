namespace Cheetah_DataAccess.Dimentions
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Links;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_Area", Schema = "Dimentions")] 
   
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class D_Area : BaseClass<D_Area>
    {
        public long Area_UnitTypeId { get; set; }
        [Column(Order = 100)]
        [ForeignKey("Area_UnitTypeId")]
        public virtual D_UnitType Area_UnitType { get; set; }
        #region Relations
        public virtual ICollection<L_UserArea>? Area_UserAreas { get; set; } = new HashSet<L_UserArea>();
        #endregion
    }
}