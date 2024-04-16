#Use the SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy the project file and restore the dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the remaining files and build the application
COPY . ./
RUN dotnet publish -c Release -o out

# Use the runtime image to run the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .

# Copy the entry point script and make sure it's executable
COPY entrypoint.sh .
RUN chmod +x entrypoint.sh

# Run the entrypoint script when the container starts
ENTRYPOINT ["./entrypoint.sh"]
#ENTRYPOINT ["dotnet", "MyGitHubActionApp.dll"]