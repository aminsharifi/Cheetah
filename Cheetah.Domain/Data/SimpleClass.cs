using HotChocolate;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cheetah.Domain.Data;

public abstract class SimpleClass
{
    [Key]
    [Description("شناسه")]
    [Column(Order = 0)]
    [DefaultValue(0)]
    public Int64? Id { get; set; }

    [Description("اندیس مرتب‌سازی")]
    [Column(Order = 2)]
    [DefaultValue(0)]
    public Int64? SortIndex { get; set; }


    [StringLength(512)]
    [Description("نام")]
    [DefaultValue("")]
    [Column(Order = 3)]    
    public String? Name { get; set; }

    [StringLength(512)]
    [Description("نام نمایشی")]
    [DefaultValue("")]
    [Column(Order = 4)]
    public String? DisplayName { get; set; }

    [StringLength(512)]
    [Description("توضیحات")]
    [Column(Order = 5)]
    public String? Description { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(Order = 6)]
    public DateTime? CreateTimeRecord { get; set; } = DateTime.Now;

    [Column(Order = 7)]
    [ConcurrencyCheck]
    public DateTime? LastUpdatedRecord { get; set; }

    [Column(Order = 8)]
    public Guid? GuidRecord { get; set; } = Guid.NewGuid();

    [DefaultValue(true)]
    [Column(Order = 9)]
    [Description("فعال")]
    public bool? EnableRecord { get; set; } = true;

    [Description("کد در ERP")]
    [Column(Order = 10)]
    public Int64? ERPCode { get; set; }

    public virtual void SetName()
    {

    }
}