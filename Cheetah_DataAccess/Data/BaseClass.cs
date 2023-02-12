using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheetah_DataAccess.Data
{
    public abstract class BaseClass
    {
        [Key]
        public long IdRecord { get; set; }
        public DateTime? CreateTimeRecord { get; set; } = DateTime.Now;
        public DateTime? LastUpdatedRecord { get; set; } = DateTime.Now;
        public Guid? GuidRecord { get; set; } = Guid.NewGuid();
        [DefaultValue(false)]
        public bool? DsblRecord { get; set; } = false;

        //public ICollection<BaseClass>? ChildBaseClass = new List<BaseClass>();
    }
}
