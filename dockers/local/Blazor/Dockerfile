#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM docker.repoifb.cmn/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5000

FROM docker.repoifb.cmn/dotnet/sdk:8.0 AS build
WORKDIR /
COPY ["dockers/local/nuget.config", "."]
COPY ["src/Cheetah.Presentation.Web.Blazor.Server/Cheetah.Presentation.Web.Blazor.Server.csproj", "src/Cheetah.Presentation.Web.Blazor.Server/"]
COPY ["src/Cheetah.Infrastructure.Persistence.Providers.Npgsql/Cheetah.Infrastructure.Persistence.Providers.Npgsql.csproj", "src/Cheetah.Infrastructure.Persistence.Providers.Npgsql/"]
COPY ["src/Cheetah.Infrastructure.Persistence/Cheetah.Infrastructure.Persistence.csproj", "src/Cheetah.Infrastructure.Persistence/"]
COPY ["src/Cheetah.Application.Business/Cheetah.Application.Business.csproj", "src/Cheetah.Application.Business/"]
COPY ["src/Cheetah.Domain/Cheetah.Domain.csproj", "src/Cheetah.Domain/"]
COPY ["src/Cheetah.Infrastructure.Persistence.Providers.SqlServer/Cheetah.Infrastructure.Persistence.Providers.SqlServer.csproj", "src/Cheetah.Infrastructure.Persistence.Providers.SqlServer/"]
RUN dotnet restore "src/Cheetah.Presentation.Web.Blazor.Server/Cheetah.Presentation.Web.Blazor.Server.csproj"  --source "http://repoifb.cmn/artifactory/api/nuget/nuget"
COPY . .
WORKDIR "/src/Cheetah.Presentation.Web.Blazor.Server"
RUN dotnet build  -c Release -o /app/build  --source "http://repoifb.cmn/artifactory/api/nuget/nuget"

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false  --source "http://repoifb.cmn/artifactory/api/nuget/nuget"

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN chown -R 1988:1988 /app
RUN useradd -u 1988 cheetah
USER cheetah
ENTRYPOINT ["dotnet", "Cheetah.Presentation.Web.Blazor.Server.dll"]