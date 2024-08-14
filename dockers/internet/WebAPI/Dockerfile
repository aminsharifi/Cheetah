#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 1991
EXPOSE 1992

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src/WebAPI
COPY ["sample/src/Presentation/Services/WebAPI/Cheetah.Sample.Presentation.Services.WebAPI.csproj", "."]
RUN dotnet restore "./Cheetah.sample.Presentation.Services.WebAPI.csproj"
COPY . .
WORKDIR "/src/WebAPI/."
RUN dotnet build "./Cheetah.sample.Presentation.Services.WebAPI.csproj"  -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./Cheetah.sample.Presentation.Services.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN chown -R 1988:1988 /app
RUN useradd -u 1988 cheetah
USER cheetah
ENTRYPOINT ["dotnet", "Cheetah.Sample.Presentation.Services.WebAPI.dll"]