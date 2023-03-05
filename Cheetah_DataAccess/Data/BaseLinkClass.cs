using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cheetah_DataAccess.Data
{
    public abstract class BaseLinkClass<I> : BaseClass<I>
    {
        [Description("شناسه اول")]
        [Column(Order = 50)]
        [Required]
        public Int64 FirstId { get; set; }

        [Description("شناسه دوم")]
        [Column(Order = 51)]
        public Int64 SecondId { get; set; }
    }
}
