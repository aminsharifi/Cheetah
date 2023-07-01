#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Cheetah_GrpcService/Cheetah_GrpcService.csproj", "Cheetah_GrpcService/"]
RUN dotnet restore "Cheetah_GrpcService/Cheetah_GrpcService.csproj"
COPY . .
WORKDIR "/src/Cheetah_GrpcService"
RUN dotnet build "Cheetah_GrpcService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cheetah_GrpcService.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cheetah_GrpcService.dll"]