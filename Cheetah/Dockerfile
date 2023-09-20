#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 1988

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Cheetah/cheetah_portal.csproj", "cheetah_portal/"]
COPY ["Cheetah_DataAccess_Npgsql/cheetah_data_access_npgsql.csproj", "cheetah_data_access_npgsql/"]
COPY ["Cheetah_DataAccess/cheetah_data_access.csproj", "cheetah_data_access/"]
COPY ["Cheetah_Business/cheetah_business.csproj", "cheetah_business/"]
COPY ["Cheetah_DataAccess_SqlServer/cheetah_data_access_sqlserver.csproj", "cheetah_data_access_sqlserver/"]
RUN dotnet restore "Cheetah/cheetah_portal.csproj"
COPY . .
WORKDIR "/src/Cheetah"
RUN dotnet build "cheetah_portal.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cheetah_portal.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cheetah_portal.dll"]