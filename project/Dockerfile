FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY project.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "project.dll"]
