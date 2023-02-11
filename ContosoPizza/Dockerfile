FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ContoosoPizza/ContoosoPizza.csproj", "ContoosoPizza/"]
RUN dotnet restore "ContoosoPizza/ContoosoPizza.csproj"
COPY . .
WORKDIR "/src/ContoosoPizza"
RUN dotnet build "ContoosoPizza.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContoosoPizza.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContoosoPizza.dll"]
