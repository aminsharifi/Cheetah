﻿using Cheetah.Core.Common.DTOs;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.EntityManager.Queries;

public class GetAllByNameRequest
{
    public const string Route = "/EntityManager/Queries/GetAllByName";
    public BaseClassWithNameDTO? TableInput { get; set; }
}
