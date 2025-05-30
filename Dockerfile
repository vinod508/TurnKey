services:
  - type: web
    name: turnkey-app
    runtime: dotnet-core
    branch: main
    buildCommand: "dotnet publish -c Release -o out"
    startCommand: "dotnet ./out/TurnKey.dll"
    plan: free
# Stage 1: Build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj files and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy all files and publish release
COPY . ./
RUN dotnet publish -c Release -o out

# Stage 2: Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Start the application
ENTRYPOINT ["dotnet", "TurnKey.dll"]
