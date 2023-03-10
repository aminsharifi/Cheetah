using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cheetah_DataAccess.Data
{ 
    public abstract class SimpleLinkClass : SimpleClass
    {
        [Column(Order = 50)]
        [Required]
        public Int64 FirstId { get; set; }

        [Column(Order = 51)]
        public Int64 SecondId { get; set; }
    }
}
