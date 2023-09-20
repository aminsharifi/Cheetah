#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["cheetah_graphql/cheetah_graphql.csproj", "cheetah_graphql/"]
COPY ["cheetah_data_access_npgsql/cheetah_data_access_npgsql.csproj", "cheetah_data_access_npgsql/"]
COPY ["cheetah_data_access/cheetah_data_access.csproj", "cheetah_data_access/"]
COPY ["cheetah_business/cheetah_business.csproj", "cheetah_business/"]
COPY ["cheetah_data_access_sqlserver/cheetah_data_access_sqlserver.csproj", "cheetah_data_access_sqlserver/"]
RUN dotnet restore "cheetah_graphql/cheetah_graphql.csproj"
COPY . .
WORKDIR "/src/cheetah_graphql"
RUN dotnet build "cheetah_graphql.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cheetah_graphql.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cheetah_graphql.dll"]