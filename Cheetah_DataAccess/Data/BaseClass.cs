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
    public abstract class BaseClass
    {
        [Key]
        [Column(Order = 0)]
        public long IdRecord { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public DateTime? CreateTimeRecord { get; set; } = DateTime.Now;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(Order = 2)]
        public DateTime? LastUpdatedRecord { get; set; } = DateTime.Now;
        [Column(Order = 3)]
        public Guid? GuidRecord { get; set; } = Guid.NewGuid();
        [DefaultValue(false)]
        [Column(Order = 4)]
        public bool? DsblRecord { get; set; } = false;

        //public ICollection<BaseClass>? ChildBaseClass = new List<BaseClass>();
    }
}
