﻿using Cheetah.Core.Common.DTOs;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.EntityManager.Commands;

public class UpdateEntityRequest
{
    public BaseClassWithNameDTO? Base { get; set; }
    public List<BaseClassWithNameAndDateDTO>? Records { get; set; }
    public long? Crud { get; set; }
}
