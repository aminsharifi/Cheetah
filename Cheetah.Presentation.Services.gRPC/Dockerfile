#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Cheetah.Presentation.Services.gRPC/Cheetah.Presentation.Services.gRPC.csproj", "Cheetah.Presentation.Services.gRPC/"]
RUN dotnet restore
COPY . .
WORKDIR "/src/Cheetah.Presentation.Services.gRPC"
RUN dotnet build  -c Release -o /app/build --no-restore

FROM build AS publish
RUN dotnet publish  -c Release -o /app/publish --no-restore

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cheetah.Presentation.Services.gRPC.dll"]