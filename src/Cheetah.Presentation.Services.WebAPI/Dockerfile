#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Cheetah.Presentation.Services.WebAPI/Cheetah.Presentation.Services.WebAPI.csproj", "src/Cheetah.Presentation.Services.WebAPI/"]
COPY ["src/Cheetah.Infrastructure.Persistence.Providers.Npgsql/Cheetah.Infrastructure.Persistence.Providers.Npgsql.csproj", "src/Cheetah.Infrastructure.Persistence.Providers.Npgsql/"]
COPY ["src/Cheetah.Infrastructure.Persistence/Cheetah.Infrastructure.Persistence.csproj", "src/Cheetah.Infrastructure.Persistence/"]
COPY ["src/Cheetah.Application.Business/Cheetah.Application.Business.csproj", "src/Cheetah.Application.Business/"]
COPY ["src/Cheetah.Domain/Cheetah.Domain.csproj", "src/Cheetah.Domain/"]
COPY ["src/Cheetah.Infrastructure.Persistence.Providers.SqlServer/Cheetah.Infrastructure.Persistence.Providers.SqlServer.csproj", "src/Cheetah.Infrastructure.Persistence.Providers.SqlServer/"]
RUN dotnet restore "./src/Cheetah.Presentation.Services.WebAPI/Cheetah.Presentation.Services.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/Cheetah.Presentation.Services.WebAPI"
RUN dotnet build "./Cheetah.Presentation.Services.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Cheetah.Presentation.Services.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cheetah.Presentation.Services.WebAPI.dll"]