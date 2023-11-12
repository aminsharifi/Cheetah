#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Cheetah.Presentation.Web.Blazor.Server/Cheetah.Presentation.Web.Blazor.Server.csproj", "src/Cheetah.Presentation.Web.Blazor.Server/"]
COPY ["src/Cheetah.Infrastructure.Persistence.Providers.Npgsql/Cheetah.Infrastructure.Persistence.Providers.Npgsql.csproj", "src/Cheetah.Infrastructure.Persistence.Providers.Npgsql/"]
COPY ["src/Cheetah.Infrastructure.Persistence/Cheetah.Infrastructure.Persistence.csproj", "src/Cheetah.Infrastructure.Persistence/"]
COPY ["src/Cheetah.Application.Business/Cheetah.Application.Business.csproj", "src/Cheetah.Application.Business/"]
COPY ["src/Cheetah.Domain/Cheetah.Domain.csproj", "src/Cheetah.Domain/"]
COPY ["src/Cheetah.Infrastructure.Persistence.Providers.SqlServer/Cheetah.Infrastructure.Persistence.Providers.SqlServer.csproj", "src/Cheetah.Infrastructure.Persistence.Providers.SqlServer/"]
RUN dotnet restore "src/Cheetah.Presentation.Web.Blazor.Server/Cheetah.Presentation.Web.Blazor.Server.csproj"
COPY . .
WORKDIR "/src/src/Cheetah.Presentation.Web.Blazor.Server"
RUN dotnet build "Cheetah.Presentation.Web.Blazor.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cheetah.Presentation.Web.Blazor.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cheetah.Presentation.Web.Blazor.Server.dll"]