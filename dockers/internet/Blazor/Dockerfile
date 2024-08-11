#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 1988

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /

COPY ["src/Core/Cheetah.Core.csproj", "src/Core/"]
COPY ["src/UseCases/Cheetah.UseCases.csproj", "src/UseCases/"]
COPY ["src/Infrastructure/Main/Cheetah.Infrastructure.csproj", "src/Infrastructure/"]
COPY ["src/Infrastructure/Providers/Npgsql/Cheetah.Infrastructure.Providers.Npgsql.csproj", "src/Infrastructure/Providers/Npgsql/"]
COPY ["src/Infrastructure/Providers/SqlServer/Cheetah.Infrastructure.Providers.SqlServer.csproj", "src/Infrastructure/Providers/SqlServer/"]

COPY ["sample/src/Presentation/Web/Blazor/Server/Cheetah.Sample.Presentation.Web.Blazor.Server.csproj", "sample/src/Presentation/Web/Blazor/Server/"]
COPY ["sample/src/Infrastructure/Main/Cheetah.Sample.Infrastructure.csproj", "sample/src/Infrastructure/"]

RUN dotnet restore "sample/src/Presentation/Web/Blazor/Server/Cheetah.Sample.Presentation.Web.Blazor.Server.csproj"
COPY . .
WORKDIR "sample/src/Presentation/Web/Blazor/Server/"
RUN dotnet build  -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN chown -R 1988:1988 /app
RUN useradd -u 1988 cheetah
USER cheetah
ENTRYPOINT ["dotnet", "Cheetah.Sample.Presentation.Web.Blazor.Server.dll"]
