FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
RUN ls
COPY ["SispeServiciosApiIntermediacion/SispeServiciosApiIntermediacion.csproj", "SispeServiciosApiIntermediacion/"]
COPY ["SispeServiciosDbContextBase/SispeServiciosDbContextBase.csproj", "SispeServiciosDbContextBase/"]
COPY ["SispeServiciosArchivo/SispeServiciosArchivo.csproj", "SispeServiciosArchivo/"]
COPY ["SispeServiciosPaginacion/SispeServiciosPaginacion.csproj", "SispeServiciosPaginacion/"]

RUN dotnet restore "SispeServiciosApiIntermediacion/SispeServiciosApiIntermediacion.csproj"
COPY . .
WORKDIR "/src/SispeServiciosApiIntermediacion"
RUN dotnet build "SispeServiciosApiIntermediacion.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "SispeServiciosApiIntermediacion.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SispeServiciosApiIntermediacion.dll"]