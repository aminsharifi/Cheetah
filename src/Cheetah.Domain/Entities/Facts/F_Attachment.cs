namespace Cheetah.Domain.Entities.Facts;

public class F_Attachment : SimpleClass
{
    //Passed 

    #region Basic Prop
    public string? Name { get; set; }
    public byte[]? Data { get; set; }
    #endregion
    public F_Attachment ShallowCopy()
    {
        return (F_Attachment)MemberwiseClone();
    }
}
