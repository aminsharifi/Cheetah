#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM docker.repoifb.cmn/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 1991

FROM docker.repoifb.cmn/dotnet/sdk:8.0 AS build
WORKDIR /
COPY ["dockers/local/nuget.config", "."]
COPY ["sample/src/Cheetah.Presentation.Services.WebAPI/Cheetah.Presentation.Services.WebAPI.csproj", "sample/src/Cheetah.Presentation.Services.WebAPI/"]
COPY ["src/Cheetah.Infrastructure/Cheetah.Infrastructure.csproj", "src/Cheetah.Infrastructure/"]
COPY ["src/Cheetah.Infrastructure.Providers.SqlServer/Cheetah.Infrastructure.Providers.SqlServer.csproj", "src/Cheetah.Infrastructure.Providers.SqlServer/"]
COPY ["src/Cheetah.UseCases/Cheetah.UseCases.csproj", "src/Cheetah.UseCases/"]
COPY ["src/Cheetah.Core/Cheetah.Core.csproj", "src/Cheetah.Core/"]

RUN dotnet restore "src/Cheetah.Presentation.Services.WebAPI/Cheetah.Presentation.Services.WebAPI.csproj"  --source "http://repoifb.cmn/artifactory/api/nuget/nuget"

COPY . .
WORKDIR "/sample/src/Cheetah.Presentation.Services.WebAPI"
RUN dotnet build -c Release -o /app/build  --source "http://repoifb.cmn/artifactory/api/nuget/nuget"

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false  --source "http://repoifb.cmn/artifactory/api/nuget/nuget"


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN chown -R 1988:1988 /app
RUN useradd -u 1988 cheetah
USER cheetah
ENTRYPOINT ["dotnet", "Cheetah.Presentation.Services.WebAPI.dll"]