FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

#Add these two lines
RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

WORKDIR /app
EXPOSE 80
COPY ["SispeServiciosApiCiudadano/Assets/", "Assets/"]
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
RUN ls
COPY ["SispeServiciosApiCiudadano/SispeServiciosApiCiudadano.csproj", "SispeServiciosApiCiudadano/"]
COPY ["SispeServiciosDbContextBase/SispeServiciosDbContextBase.csproj", "SispeServiciosDbContextBase/"]
COPY ["SispeServiciosPaginacion/SispeServiciosPaginacion.csproj", "SispeServiciosPaginacion/"]


RUN dotnet restore "SispeServiciosApiCiudadano/SispeServiciosApiCiudadano.csproj"
COPY . .
WORKDIR "/src/SispeServiciosApiCiudadano"
RUN dotnet build "SispeServiciosApiCiudadano.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "SispeServiciosApiCiudadano.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SispeServiciosApiCiudadano.dll"]