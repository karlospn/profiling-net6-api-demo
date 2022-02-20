FROM mcr.microsoft.com/dotnet/sdk:6.0-bullseye-slim AS build-env
WORKDIR /app

# Copy csproj and restore dependencies
COPY Profiling.Api.csproj ./src/
RUN dotnet restore "./src/Profiling.Api.csproj"

# Copy everything, build and publish
COPY . ./src/
RUN dotnet publish src/*.csproj -c Release -o /app/publish

# Build runtime imagedock
FROM mcr.microsoft.com/dotnet/aspnet:6.0-bullseye-slim
WORKDIR /app
COPY --from=build-env /app/publish .
ENTRYPOINT ["dotnet", "Profiling.Api.dll"]