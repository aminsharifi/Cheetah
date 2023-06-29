#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 1988
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "Cheetah_WebAPI/Cheetah_WebAPI.csproj"
WORKDIR "/src/Cheetah_WebAPI"
RUN dotnet build "Cheetah_WebAPI.csproj" -c Release -o /app/build
RUN dotnet build "Cheetah_WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cheetah_WebAPI.dll"]
