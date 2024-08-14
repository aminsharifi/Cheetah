#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 1988

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /
COPY ["sample/src/Presentation/Web/Blazor/Server/Cheetah.Sample.Presentation.Web.Blazor.Server.csproj", "WebBlazor/"]
COPY ["sample/src/Infrastructure/Cheetah.Sample.Infrastructure.csproj", "Infrastructure/"]
RUN dotnet restore "WebBlazor/Cheetah.Sample.Presentation.Web.Blazor.Server.csproj"
COPY . .
WORKDIR "/WebBlazor"
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cheetah.Sample.Presentation.Web.Blazor.Server.dll"]
