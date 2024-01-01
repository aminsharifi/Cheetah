using System.Collections.Generic;

namespace Cheetah.Domain.Entities.Dimentions;

public class D_Tag : SimpleClass
{
    #region Relation

    #region Entity
    public long? TagTypeId { get; set; }
    public virtual D_TagType? TagType { get; set; }

    #endregion

    #region Collection
    #endregion

    #endregion

    #region Values

    public static readonly D_Tag D_Location =
        new D_Tag
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(D_Location),
            DisplayName = "مرکز",
            Description = "عددی",
            TagTypeId = 1
        };

    public static readonly D_Tag Approve =
        new D_Tag
        {
            Id = 201,
            ERPCode = 201,
            SortIndex = 201,
            Name = nameof(Approve),
            DisplayName = "تایید",
            Description = "پارامتریک",
            TagTypeId = 2
        };

    public static readonly D_Tag Reject =
        new D_Tag
        {
            Id = 202,
            ERPCode = 202,
            SortIndex = 202,
            Name = nameof(Reject),
            DisplayName = "عدم تایید",
            Description = "پارامتریک",
            TagTypeId = 2
        };

    public static readonly D_Tag Edit =
        new D_Tag
        {
            Id = 203,
            ERPCode = 203,
            SortIndex = 203,
            Name = nameof(Edit),
            DisplayName = "بازنگری",
            Description = "پارامتریک",
            TagTypeId = 2
        };

    public static readonly D_Tag Price =
        new D_Tag
        {
            Id = 301,
            ERPCode = 301,
            SortIndex = 301,
            Name = nameof(Price),
            DisplayName = "مبلغ",
            Description = "عددی",
            TagTypeId = 1
        };

    #endregion
}