#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 1991
EXPOSE 1992

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src/GraphQL
COPY ["sample/src/Presentation/Services/GraphQL/Cheetah.Sample.Presentation.Services.GraphQL.csproj", "GraphQL/"]
RUN dotnet restore "GraphQL/Cheetah.Sample.Presentation.Services.GraphQL.csproj"
COPY . .
WORKDIR "/src/GraphQL"
RUN dotnet build  -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cheetah.Sample.Presentation.Services.GraphQL.dll"]