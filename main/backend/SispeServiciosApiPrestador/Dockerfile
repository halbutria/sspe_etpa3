FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
RUN ls
COPY ["SispeServiciosApiPrestador/SispeServiciosApiPrestador.csproj", "SispeServiciosApiPrestador/"]
COPY ["SispeServiciosDbContextBase/SispeServiciosDbContextBase.csproj", "SispeServiciosDbContextBase/"]

RUN dotnet restore "SispeServiciosApiPrestador/SispeServiciosApiPrestador.csproj"
COPY . .
WORKDIR "/src/SispeServiciosApiPrestador"
RUN dotnet build "SispeServiciosApiPrestador.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "SispeServiciosApiPrestador.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SispeServiciosApiPrestador.dll"]