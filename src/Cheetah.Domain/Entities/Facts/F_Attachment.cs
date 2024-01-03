﻿namespace Cheetah.Domain.Entities.Facts;

public partial class F_Attachment : BaseEntity
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
