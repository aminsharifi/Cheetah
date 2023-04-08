using Cheetah_DataAccess.Parameters;

namespace Cheetah_DataAccess.Links
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Dimentions;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    [Table("L_UserArea", Schema = "Links")]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(FirstId), IsUnique = false, AllDescending = true)]
    [Index(nameof(SecondId), IsUnique = false, AllDescending = true)]
    public partial class L_UserArea : SimpleLinkClass
    {
        private D_User? _UA_User;

        #region Simple Prob
        [Column(Order = 100)]
        [ForeignKey("FirstId")]
        public virtual D_User? UA_User
        {
            get
            {
                return _UA_User;
            }
            set
            {
                _UA_User = value;
            }
        }


        private D_Area? _UA_Area;

        [Column(Order = 101)]
        [ForeignKey("SecondId")]
        public virtual D_Area? UA_Area
        {
            get
            {
                return _UA_Area;
            }
            set
            {
                _UA_Area = value;
            }
        }

        #endregion

        #region Collection

        #endregion

    }
}
