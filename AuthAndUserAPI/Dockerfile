# Base image for runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# SDK image for build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy csproj and restore dependencies
COPY ["AuthAndUserAPI.csproj", "."]
RUN dotnet restore "./AuthAndUserAPI.csproj"

# Copy the rest of the app
COPY . .

# Build
RUN dotnet build "AuthAndUserAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish
FROM build AS publish
RUN dotnet publish "AuthAndUserAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final stage
FROM base AS final
WORKDIR /app

# Copy published output
COPY --from=publish /app/publish .

# Copy SQLite database file
COPY AuthDb.sqlite ./AuthDb.sqlite

# Set environment variable to Development (optional)
ENV ASPNETCORE_ENVIRONMENT=Development

ENTRYPOINT ["dotnet", "AuthAndUserAPI.dll"]
