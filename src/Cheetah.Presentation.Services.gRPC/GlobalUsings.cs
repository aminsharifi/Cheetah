﻿global using Ardalis.Result;
global using Ardalis.SharedKernel;
global using Cheetah.Application.Business.Interfaces;
global using Cheetah.Application.Services.gRPC.Middleware;
global using Cheetah.Application.Services.gRPC.Services;
global using Cheetah.Domain.Entities.Dimentions;
global using Cheetah.Domain.Entities.Facts;
global using Cheetah.Infrastructure.Persistence.Data;
global using Cheetah_GrpcService;
global using Grpc.Core;
global using Grpc.Core.Interceptors;
global using MediatR;
global using Microsoft.AspNetCore.Server.Kestrel.Core;
global using Newtonsoft.Json;
global using Serilog;
global using Serilog.Context;
