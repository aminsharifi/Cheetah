using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheetah_DataAccess
{
    public  class CopyProduct
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public String Name { get; set; }
        public int idRole { get; set; }
        [ForeignKey("idRole")]
        public virtual CopyROLE? copyROLE { get; set; }
    }
}
