FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["src/SpaReactSample/SpaReactSample.csproj", "src/SpaReactSample/"]
RUN dotnet restore "src/SpaReactSample/SpaReactSample.csproj"
COPY . .
WORKDIR "/src/src/SpaReactSample"
RUN dotnet build "SpaReactSample.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SpaReactSample.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SpaReactSample.dll"]
