FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Polar.OpenAPI.Tests/Polar.OpenAPI.Tests.csproj", "Polar.OpenAPI.Tests/"]
RUN dotnet restore "Polar.OpenAPI.Tests/Polar.OpenAPI.Tests.csproj"
COPY . .
WORKDIR "/src/Polar.OpenAPI.Tests"
RUN dotnet build "Polar.OpenAPI.Tests.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Polar.OpenAPI.Tests.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Polar.OpenAPI.Tests.dll"]
