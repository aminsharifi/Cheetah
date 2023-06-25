#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 806


FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY . .
COPY ["Cheetah_WebAPI/Cheetah_WebAPI.csproj", "Cheetah_WebAPI/"]
COPY ["Cheetah_DataAccess/Cheetah_DataAccess.csproj", "Cheetah_DataAccess/"]
COPY ["Cheetah_Business/Cheetah_Business.csproj", "Cheetah_Business/"]
RUN dotnet restore "Cheetah_WebAPI/Cheetah_WebAPI.csproj"
WORKDIR "/src/Cheetah_WebAPI"
RUN dotnet build "Cheetah_WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cheetah_WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cheetah_WebAPI.dll"]
