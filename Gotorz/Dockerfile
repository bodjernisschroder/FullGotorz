# Base runtime stage (used as the foundation for the final stage)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Gotorz/Gotorz.csproj", "Gotorz/"]
COPY ["Gotorz.Client/Gotorz.Client.csproj", "Gotorz.Client/"]
# COPY ["AuthAndUserAPI/AuthAndUserAPI.csproj", "AuthAndUserAPI/"]
# COPY ["TravelBridgeAPI/TravelBridgeAPI.csproj", "TravelBridgeAPI/"]
RUN dotnet restore "./Gotorz/Gotorz.csproj"
COPY . .
WORKDIR "/src/Gotorz"
RUN dotnet build "./Gotorz.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Gotorz.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
EXPOSE 8080

COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gotorz.dll"]
