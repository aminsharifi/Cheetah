namespace Cheetah.Domain.Facts;

public partial class F_Attachment : SimpleClass
{
    //Passed 

    #region Basic Prop
    public String? Name { get; set; }
    public byte[]? Data { get; set; }
    #endregion
    public F_Attachment ShallowCopy()
    {
        return (F_Attachment)this.MemberwiseClone();
    }
}
