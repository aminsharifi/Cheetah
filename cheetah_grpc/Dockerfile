#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["cheetah_grpc/cheetah_grpc.csproj", "cheetah_grpc/"]
COPY ["cheetah_data_access_npgsql/cheetah_data_access_npgsql.csproj", "cheetah_data_access_npgsql/"]
COPY ["cheetah_data_access/cheetah_data_access.csproj", "cheetah_data_access/"]
COPY ["cheetah_business/cheetah_business.csproj", "cheetah_business/"]
COPY ["cheetah_data_access_sqlserver/cheetah_data_access_sqlserver.csproj", "cheetah_data_access_sqlserver/"]
RUN dotnet restore "cheetah_grpc/cheetah_grpc.csproj"
COPY . .
WORKDIR "/src/cheetah_grpc"
RUN dotnet build "cheetah_grpc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cheetah_grpc.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cheetah_grpc.dll"]