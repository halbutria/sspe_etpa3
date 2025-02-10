FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
RUN ls
COPY ["SispeServiciosApiParametrico/SispeServiciosApiParametrico.csproj", "SispeServiciosApiParametrico/"]
COPY ["SispeServiciosDbContextBase/SispeServiciosDbContextBase.csproj", "SispeServiciosDbContextBase/"]
COPY ["SispeServiciosPaginacion/SispeServiciosPaginacion.csproj", "SispeServiciosPaginacion/"]

RUN dotnet restore "SispeServiciosApiParametrico/SispeServiciosApiParametrico.csproj"
COPY . .
WORKDIR "/src/SispeServiciosApiParametrico"
RUN dotnet build "SispeServiciosApiParametrico.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "SispeServiciosApiParametrico.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SispeServiciosApiParametrico.dll"]