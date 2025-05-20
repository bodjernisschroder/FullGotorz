# Build stage using the .NET 8.0 SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file (we're in the build context: AuthAndUserAPI/)
COPY AuthAndUserAPI.csproj .
RUN dotnet restore "./AuthAndUserAPI.csproj"

# Copy the rest of the code and build the project
COPY . .
RUN dotnet build "AuthAndUserAPI.csproj" -c Release -o /app/build
RUN dotnet publish "AuthAndUserAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Runtime stage using the .NET 8.0 ASP.NET Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build /app/publish .

# Copy the SQLite database file to the container
COPY AuthDb.sqlite ./AuthDb.sqlite

# Start the application
ENTRYPOINT ["dotnet", "AuthAndUserAPI.dll"]

# Set environment to Deployment
ENV ASPNETCORE_ENVIRONMENT=Deployment

