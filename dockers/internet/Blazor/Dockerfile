#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 1988

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /
COPY ["src/Cheetah.Presentation.Web.Blazor.Server/Cheetah.Presentation.Web.Blazor.Server.csproj", "src/Cheetah.Presentation.Web.Blazor.Server/"]
COPY ["src/Cheetah.Infrastructure.Npgsql/Cheetah.Infrastructure.Providers.Npgsql.csproj", "src/Cheetah.Infrastructure.Providers.Npgsql/"]
COPY ["src/Cheetah.Infrastructure/Cheetah.Infrastructure.csproj", "src/Cheetah.Infrastructure/"]
COPY ["src/Cheetah.UseCases/Cheetah.UseCases.csproj", "src/Cheetah.UseCases/"]
COPY ["src/Cheetah.Core/Cheetah.Core.csproj", "src/Cheetah.Core/"]
COPY ["src/Cheetah.Infrastructure.Providers.SqlServer/Cheetah.Infrastructure.Providers.SqlServer.csproj", "src/Cheetah.Infrastructure.Providers.SqlServer/"]
RUN dotnet restore "src/Cheetah.Presentation.Web.Blazor.Server/Cheetah.Presentation.Web.Blazor.Server.csproj"
COPY . .
WORKDIR "/src/Cheetah.Presentation.Web.Blazor.Server"
RUN dotnet build  -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN chown -R 1988:1988 /app
RUN useradd -u 1988 cheetah
USER cheetah
ENTRYPOINT ["dotnet", "Cheetah.Presentation.Web.Blazor.Server.dll"]
