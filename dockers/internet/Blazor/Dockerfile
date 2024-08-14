#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 1988

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src/Blazor/Server
COPY ["sample/src/Presentation/Web/Blazor/Server/Cheetah.Sample.Presentation.Web.Blazor.Server.csproj", "."]
RUN dotnet restore "./Cheetah.Sample.Presentation.Web.Blazor.Server.csproj"
COPY . .
WORKDIR "/src/Blazor/Server/."
RUN dotnet build "./Cheetah.Sample.Presentation.Web.Blazor.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./Cheetah.Sample.Presentation.Web.Blazor.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN chown -R 1988:1988 /app
RUN useradd -u 1988 cheetah
USER cheetah
ENTRYPOINT ["dotnet", "Cheetah.Sample.Presentation.Web.Blazor.Server.dll"]
