using System;
using System.Collections.Generic;
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
        public long TimeRecord { get; set; } = DateTime.Now.Ticks;
        public Guid GuidRecord { get; set; } = Guid.NewGuid();
        public bool DsblRecord { get; set; } = false;
    }
}
