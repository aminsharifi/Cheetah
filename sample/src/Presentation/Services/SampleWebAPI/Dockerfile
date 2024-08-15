# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["sample/src/Presentation/Services/SampleWebAPI/SampleWebAPI.csproj", "sample/src/Presentation/Services/SampleWebAPI/"]
COPY ["sample/src/Infrastructure/Cheetah.Sample.Infrastructure.csproj", "sample/src/Infrastructure/"]
COPY ["src/Infrastructure/Providers/SqlServer/Cheetah.Infrastructure.Providers.SqlServer.csproj", "src/Infrastructure/Providers/SqlServer/"]
COPY ["src/Infrastructure/Main/Cheetah.Infrastructure.csproj", "src/Infrastructure/Main/"]
COPY ["src/UseCases/Cheetah.UseCases.csproj", "src/UseCases/"]
COPY ["src/Core/Cheetah.Core.csproj", "src/Core/"]
RUN dotnet restore "./sample/src/Presentation/Services/SampleWebAPI/SampleWebAPI.csproj"
COPY . .
WORKDIR "/src/sample/src/Presentation/Services/SampleWebAPI"
RUN dotnet build "./SampleWebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SampleWebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SampleWebAPI.dll"]