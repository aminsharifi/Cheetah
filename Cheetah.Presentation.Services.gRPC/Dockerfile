#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 1989

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Cheetah.Presentation.Services.gRPC/Cheetah.Presentation.Services.gRPC.csproj", "Cheetah.Presentation.Services.gRPC/"]
COPY ["Cheetah.Application.Business/Cheetah.Application.Business.csproj", "Cheetah.Application.Business/"]
COPY ["Cheetah.Domain/Cheetah.Domain.csproj", "Cheetah.Domain/"]
COPY ["Cheetah.Infrastructure.Persistence/Cheetah.Infrastructure.Persistence.csproj", "Cheetah.Infrastructure.Persistence/"]
COPY ["Cheetah.Infrastructure.Persistence.Providers.Npgsql/Cheetah.Infrastructure.Persistence.Providers.Npgsql.csproj", "Cheetah.Infrastructure.Persistence.Providers.Npgsql/"]
COPY ["Cheetah.Infrastructure.Persistence.Providers.SqlServer/Cheetah.Infrastructure.Persistence.Providers.SqlServer.csproj", "Cheetah.Infrastructure.Persistence.Providers.SqlServer/"]
RUN dotnet restore "Cheetah.Presentation.Services.gRPC/Cheetah.Presentation.Services.gRPC.csproj"
COPY . .
WORKDIR "/src/Cheetah.Presentation.Services.gRPC"
RUN dotnet build "Cheetah.Presentation.Services.gRPC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cheetah.Presentation.Services.gRPC.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN chown -R 1988:1988 /app
RUN useradd -u 1988 cheetah
USER cheetah
ENTRYPOINT ["dotnet", "Cheetah.Presentation.Services.gRPC.dll"]