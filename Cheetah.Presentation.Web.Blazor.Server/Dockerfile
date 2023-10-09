#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Cheetah.Presentation.Web.Blazor.Server/Cheetah.Presentation.Web.Blazor.Server.csproj", "Cheetah.Presentation.Web.Blazor.Server/"]
COPY ["Cheetah.Infrastructure.Persistence.Providers.Npgsql/Cheetah.Infrastructure.Persistence.Providers.Npgsql.csproj", "Cheetah.Infrastructure.Persistence.Providers.Npgsql/"]
COPY ["Cheetah.Infrastructure.Persistence/Cheetah.Infrastructure.Persistence.csproj", "Cheetah.Infrastructure.Persistence/"]
COPY ["Cheetah.Application.Business/Cheetah.Application.Business.csproj", "Cheetah.Application.Business/"]
COPY ["Cheetah.Domain/Cheetah.Domain.csproj", "Cheetah.Domain/"]
COPY ["Cheetah.Infrastructure.Persistence.Providers.SqlServer/Cheetah.Infrastructure.Persistence.Providers.SqlServer.csproj", "Cheetah.Infrastructure.Persistence.Providers.SqlServer/"]
RUN dotnet restore "Cheetah.Presentation.Web.Blazor.Server/Cheetah.Presentation.Web.Blazor.Server.csproj"
COPY . .
WORKDIR "/src/Cheetah.Presentation.Web.Blazor.Server"
RUN dotnet build "Cheetah.Presentation.Web.Blazor.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cheetah.Presentation.Web.Blazor.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN chown -R 1988:1988 /app
RUN useradd -u 1988 cheetah
USER cheetah
ENTRYPOINT ["dotnet", "Cheetah.Presentation.Web.Blazor.Server.dll"]