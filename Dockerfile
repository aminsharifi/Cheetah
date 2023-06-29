#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS publish
WORKDIR /src
COPY . .
RUN dotnet restore "Cheetah_WebAPI/Cheetah_WebAPI.csproj"
WORKDIR "/src/Cheetah_WebAPI"
RUN dotnet publish "Cheetah_WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 1988
ENTRYPOINT ["dotnet", "Cheetah_WebAPI.dll"]
