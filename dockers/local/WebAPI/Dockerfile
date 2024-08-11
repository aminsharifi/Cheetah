#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM docker.repoifb.cmn/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 1991

FROM docker.repoifb.cmn/dotnet/sdk:8.0 AS build
WORKDIR /
COPY ["dockers/local/nuget.config", "."]
COPY ["src/Core/Cheetah.Core.csproj", "src/Core/"]
COPY ["src/UseCases/Cheetah.UseCases.csproj", "src/UseCases/"]
COPY ["src/Infrastructure/Main/Cheetah.Infrastructure.csproj", "src/Infrastructure/Main/"]
COPY ["src/Infrastructure/Providers/SqlServer/Cheetah.Infrastructure.Providers.SqlServer.csproj", "src/Infrastructure/Providers/SqlServer/"]

COPY ["sample/src/Infrastructure/Main/Cheetah.Sample.Infrastructure.csproj", "sample/src/Infrastructure/Main/"]
COPY ["sample/src/Presentation/Services/WebAPI/Cheetah.Sample.Presentation.Services.WebAPI.csproj", "sample/src/Presentation/Services/WebAPI/"]

RUN dotnet restore "src/Presentation/Services/WebAPI/Cheetah.Sample.Presentation.Services.WebAPI.csproj"  --source "http://repoifb.cmn/artifactory/api/nuget/nuget"

COPY . .
WORKDIR "/sample/src/Presentation/Services/WebAPI"
RUN dotnet build -c Release -o /app/build  --source "http://repoifb.cmn/artifactory/api/nuget/nuget"

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false  --source "http://repoifb.cmn/artifactory/api/nuget/nuget"


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN chown -R 1988:1988 /app
RUN useradd -u 1988 cheetah
USER cheetah
ENTRYPOINT ["dotnet", "Cheetah.Sample.Presentation.Services.WebAPI.dll"]