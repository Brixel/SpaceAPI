FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["SpaceAPI.API/SpaceAPI.API.csproj", "SpaceAPI.API/"]
RUN dotnet restore "SpaceAPI.API/SpaceAPI.API.csproj"
COPY . .
WORKDIR "/src/SpaceAPI.API"
RUN dotnet build "SpaceAPI.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SpaceAPI.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SpaceAPI.API.dll"]