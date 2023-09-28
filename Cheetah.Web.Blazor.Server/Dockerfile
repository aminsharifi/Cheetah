#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 1988

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Cheetah.Web.Blazor.Server/Cheetah.Web.Blazor.Server.csproj", "Cheetah.Web.Blazor.Server/"]
COPY ["Cheetah.Infrastructure.Persistence.Providers.Npgsql/Cheetah.Infrastructure.Persistence.Providers.Npgsql.csproj", "Cheetah.Infrastructure.Persistence.Providers.Npgsql/"]
COPY ["Cheetah.Infrastructure.Persistence/Cheetah.Infrastructure.Persistence.csproj", "Cheetah.Infrastructure.Persistence/"]
COPY ["Cheetah.Application.Business/Cheetah.Application.Business.csproj", "Cheetah.Application.Business/"]
COPY ["Cheetah.Domain/Cheetah.Domain.csproj", "Cheetah.Domain/"]
COPY ["Cheetah.Infrastructure.Persistence.Providers.SqlServer/Cheetah.Infrastructure.Persistence.Providers.SqlServer.csproj", "Cheetah.Infrastructure.Persistence.Providers.SqlServer/"]
RUN dotnet restore "Cheetah.Web.Blazor.Server/Cheetah.Web.Blazor.Server.csproj"
COPY . .
WORKDIR "/src/Cheetah.Web.Blazor.Server"
RUN dotnet build "Cheetah.Web.Blazor.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cheetah.Web.Blazor.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cheetah.Web.Blazor.Server.dll"]