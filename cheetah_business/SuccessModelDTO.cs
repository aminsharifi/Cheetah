﻿namespace Cheetah.Domain;

public class SuccessModelDTO
{
    public Int32? StatusCode { get; set; }
    public String? ErorrMessage { get; set; }
    public object Data { get; set; }
}