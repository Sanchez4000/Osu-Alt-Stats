# Этап сборки
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Копируем файлы проекта и восстанавливаем зависимости
COPY . .
RUN dotnet restore ./RestApi.sln
RUN dotnet publish -c Release -o /app/out

# Этап развертывания
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Указываем команду запуска приложения
ENTRYPOINT ["dotnet", "OsuWebApp.RestApi.Api.dll"]
