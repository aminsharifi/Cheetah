#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 1991
EXPOSE 1992

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Cheetah.Presentation.Services.WebAPI/Cheetah.Presentation.Services.WebAPI.csproj", "src/Cheetah.Presentation.Services.WebAPI/"]
COPY ["src/Cheetah.Domain/Cheetah.Domain.csproj", "src/Cheetah.Domain/"]
COPY ["src/Cheetah.Application.Business/Cheetah.Application.Business.csproj", "src/Cheetah.Application.Business/"]
COPY ["src/Cheetah.Infrastructure.Persistence/Cheetah.Infrastructure.Persistence.csproj", "src/Cheetah.Infrastructure.Persistence/"]
COPY ["src/Cheetah.Infrastructure.Persistence.Providers.Npgsql/Cheetah.Infrastructure.Persistence.Providers.Npgsql.csproj", "src/Cheetah.Infrastructure.Persistence.Providers.Npgsql/"]
COPY ["src/Cheetah.Infrastructure.Persistence.Providers.SqlServer/Cheetah.Infrastructure.Persistence.Providers.SqlServer.csproj", "src/Cheetah.Infrastructure.Persistence.Providers.SqlServer/"]

RUN dotnet restore "./Cheetah.Presentation.Services.WebAPI/./Cheetah.Presentation.Services.WebAPI.csproj"
COPY . .
WORKDIR "/src/Cheetah.Presentation.Services.WebAPI"
RUN dotnet build  -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN chown -R 1988:1988 /app
RUN useradd -u 1988 cheetah
USER cheetah
ENTRYPOINT ["dotnet", "Cheetah.Presentation.Services.WebAPI.dll"]