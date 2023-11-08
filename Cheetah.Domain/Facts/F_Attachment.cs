namespace Cheetah.Domain.Facts;

public partial class F_Attachment : SimpleClass
{
    //Passed 

    #region Basic Prop
    [Description("نام ضمیمه")]
    [StringLength(255)]
    [Column(Order = 100)]
    public String? Name { get; set; }

    [Description("ضمیمه")]
    [Column(Order = 101)]
    public byte[]? Data { get; set; }
    #endregion
    public F_Attachment ShallowCopy()
    {
        return (F_Attachment)this.MemberwiseClone();
    }
}
