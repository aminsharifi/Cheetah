#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 1991
EXPOSE 1992

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /
COPY ["src/Core/Cheetah.Core.csproj", "src/Core/"]
COPY ["src/UseCases/Cheetah.UseCases.csproj", "src/UseCases/"]
COPY ["src/Infrastructure/Main/Cheetah.Infrastructure.csproj", "src/Infrastructure/Main/"]
COPY ["src/Infrastructure/Providers/SqlServer/Cheetah.Infrastructure.Providers.SqlServer.csproj", "src/Infrastructure/Providers/SqlServer/"]
COPY ["src/Infrastructure/Providers/Npgsql/Cheetah.Infrastructure.Providers.Npgsql.csproj", "src/Infrastructure/Providers/Npgsql/"]
COPY ["src/Presentation/Services/GraphQL/Cheetah.Presentation.Services.GraphQL.csproj", "src/Presentation/Services/GraphQL/"]
RUN dotnet restore "src/Presentation/Services/GraphQL/Cheetah.Presentation.Services.GraphQL.csproj"
COPY . .
WORKDIR "/src/Presentation/Services/GraphQL"
RUN dotnet build  -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN chown -R 1988:1988 /app
RUN useradd -u 1988 cheetah
USER cheetah
ENTRYPOINT ["dotnet", "Cheetah.Presentation.Services.GraphQL.dll"]