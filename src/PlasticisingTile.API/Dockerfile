#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0.3 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0.402 AS build
WORKDIR /src
COPY ["PlasticisingTile.API/PlasticisingTile.API.csproj", "PlasticisingTile.API/"]
COPY ["PlasticisingTile.Core/PlasticisingTile.Core.csproj", "PlasticisingTile.Core/"]
COPY ["PlasticisingTile.Infrastructure/PlasticisingTile.Infrastructure.csproj", "PlasticisingTile.Infrastructure/"]
RUN dotnet restore "PlasticisingTile.API/PlasticisingTile.API.csproj"
COPY . .
WORKDIR "/src/PlasticisingTile.API"
RUN dotnet build "PlasticisingTile.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PlasticisingTile.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PlasticisingTile.API.dll"]