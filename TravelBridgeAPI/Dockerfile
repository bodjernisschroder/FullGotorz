# Use an Ubuntu-based container with the .NET 8.0 Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 7144



# Build stage - Use .NET SDK to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy config file
COPY appsettings.Deployment.json ./appsettings.Deployment.json


# Copy project file and restore dependencies
COPY *.csproj .
RUN dotnet restore

# Copy the rest of the code and build the application
COPY . .
RUN dotnet build -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

# Final runtime container based on the .NET Runtime
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .



# Expose the port the API will run on
EXPOSE 5168

# Start the application and bind it to the desired port
ENTRYPOINT ["dotnet", "TravelBridgeAPI.dll", "--urls", "http://0.0.0.0:5168"]
# Set environment variable to Deployment
ENV ASPNETCORE_ENVIRONMENT=Deployment
