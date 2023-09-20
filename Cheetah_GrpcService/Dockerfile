#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Cheetah_GrpcService/cheetah_grpc.csproj", "Cheetah_GrpcService/"]
COPY ["Cheetah_DataAccess_Npgsql/cheetah_data_access_npgsql.csproj", "Cheetah_DataAccess_Npgsql/"]
COPY ["Cheetah_DataAccess/cheetah_data_access.csproj", "Cheetah_DataAccess/"]
COPY ["Cheetah_Business/cheetah_business.csproj", "Cheetah_Business/"]
COPY ["Cheetah_DataAccess_SqlServer/cheetah_data_access_sqlserver.csproj", "Cheetah_DataAccess_SqlServer/"]
RUN dotnet restore "Cheetah_GrpcService/cheetah_grpc.csproj"
COPY . .
WORKDIR "/src/Cheetah_GrpcService"
RUN dotnet build "cheetah_grpc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cheetah_grpc.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cheetah_grpc.dll"]