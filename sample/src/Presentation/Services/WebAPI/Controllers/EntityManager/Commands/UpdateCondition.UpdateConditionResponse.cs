﻿using Cheetah.Core.Common.DTOs;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.EntityManager.Commands;

public class UpdateConditionResponse
{
    public BaseClassWithNameDTO? Result { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
