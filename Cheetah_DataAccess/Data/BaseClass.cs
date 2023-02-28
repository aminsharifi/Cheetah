using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cheetah_DataAccess.Data
{
    public abstract class BaseClass<I>
    {
        [Key]
        [Description("شناسه")]
        [Column(Order = 0)]
        public Int64 Id { get; set; }
        
        [Description("کد")]
        [Required(ErrorMessage ="کد اجباری است")]
        [Column(Order = 1)]
        public Int64 PCode { get; set; }

        [Description("اندیس مرتب‌سازی")]
        [Column(Order = 2)]
        [Required(ErrorMessage = "اندیس سورت اجباری است")]
        public Int64? PIndex { get; set; }


        [StringLength(50)]
        [Description("نام")]
        [Column(Order = 3)]
        [Required(ErrorMessage = "نام اجباری است")]
        public String? PName { get; set; }

        [StringLength(512)]
        [Description("نام نمایشی")]
        [Required(ErrorMessage = "نام نمایشی اجباری است")]
        [Column(Order = 9)]
        public String? PDescription { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 4)]
        public DateTime? CreateTimeRecord { get; set; } = DateTime.Now;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(Order = 5)]
        [ConcurrencyCheck]
        public DateTime? LastUpdatedRecord { get; set; } = DateTime.Now;

        [Column(Order = 6)]
        public Guid? GuidRecord { get; set; } = Guid.NewGuid();
        [DefaultValue(false)]
        [Column(Order = 7)]
        public bool? DsblRecord { get; set; } = false;

        [Description("کد در ERP")]
        [Column(Order = 8)]
        public Int64? PERPCode { get; set; }

        [Column(Order = 10)]
        public long? Parent_Id { get; set; }
        [ForeignKey("Parent_Id")]
        [Column(Order = 11)]
        public virtual I? ParentId { get; set; }

        [InverseProperty("ParentId")]
        public virtual ICollection<I>? RI_ListOfParameters { get; set; } = new HashSet<I>();

    }
}
