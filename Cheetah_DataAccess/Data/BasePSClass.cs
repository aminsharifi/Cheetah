using Cheetah_DataAccess.Systems;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheetah_DataAccess.Data
{
    public abstract class BasePSClass : BaseClass
    {
        [Description("کد پارامتر")]
        [Required]
        public long PCode { get; set; }

        [StringLength(50)]
        [Description("نام پارامتر")]
        [Required]
        public string PName { get; set; }

        [Description("اندیس سورت")]
        public long PIndex { get; set;}

        [Description("کد در سیستم ERP")]
        public long? PERPCode { get; set; }

        [StringLength(512)]
        [Description("نام پارامتر")]
        public string? PDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PCost { get; set; }

        #region PParentchilds
        //public long? PidParent { get; set; }
        //[ForeignKey("PidParent")]
        //public virtual BasePSClass? PParent { get; set; }
        //public virtual ICollection<BasePSClass>? PChilds { get; set; }
        #endregion
    }
}
