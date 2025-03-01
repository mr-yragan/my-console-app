# Используем образ .NET SDK для сборки
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Копируем файл проекта и восстанавливаем зависимости
COPY project.csproj .
RUN dotnet restore

# Копируем весь проект и собираем его
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Используем образ .NET Runtime	 для запуска
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Указываем команду для запуска приложения
ENTRYPOINT ["dotnet", "project.dll"]