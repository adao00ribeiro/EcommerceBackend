FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5113

ENV ASPNETCORE_URLS=http://+:5113;http://+:80;
ENV ASPNETCORE_ENVIRONMENT=Development;
ENV ConnectionStrings__Database=Data Source=/app/Database/Database.db
# Criar diretório para o banco de dados SQLite
RUN mkdir -p /app/Database

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["Ecommerce.Api.csproj", "./"]
RUN dotnet restore "Ecommerce.Api.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Ecommerce.Api.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "Ecommerce.Api.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ecommerce.Api.dll"]
