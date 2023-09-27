﻿using System.Net;

namespace Cheetah.Domain.Exceptions;
public class InternalServerException : CustomException
{
    public InternalServerException(string message, List<string>? errors = default)
        : base(message, errors, HttpStatusCode.InternalServerError) { }
}