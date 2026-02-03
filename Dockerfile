FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/TalhaoSensorApi/TalhaoSensorApi.csproj", "src/TalhaoSensorApi/"]
RUN dotnet restore "src/TalhaoSensorApi/TalhaoSensorApi.csproj"
COPY . .
WORKDIR "/src/src/TalhaoSensorApi"
RUN dotnet build "TalhaoSensorApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TalhaoSensorApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TalhaoSensorApi.dll"]