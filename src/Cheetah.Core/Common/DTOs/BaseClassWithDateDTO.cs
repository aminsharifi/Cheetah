﻿namespace Cheetah.Core.Common.DTOs;

public class BaseClassWithDateDTO : BaseClassDTO
{
    public DateTimeOffset? Created { get; set; }
    public DateTimeOffset? LastModified { get; set; }
}
