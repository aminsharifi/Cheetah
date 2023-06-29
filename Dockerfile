#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 1988

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Cheetah/Cheetah.csproj", "Cheetah/"]
COPY ["Cheetah_DataAccess/Cheetah_DataAccess.csproj", "Cheetah_DataAccess/"]
COPY ["Cheetah_Business/Cheetah_Business.csproj", "Cheetah_Business/"]
COPY ["Cheetah_DataAccess_Npgsql/Cheetah_DataAccess_Npgsql.csproj", "Cheetah_DataAccess_Npgsql/"]
COPY ["Cheetah_DataAccess_SqlServer/Cheetah_DataAccess_SqlServer.csproj", "Cheetah_DataAccess_SqlServer/"]
RUN dotnet restore "Cheetah/Cheetah.csproj"
COPY . .
WORKDIR "/src/Cheetah"
RUN dotnet build "Cheetah.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cheetah.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cheetah.dll"]