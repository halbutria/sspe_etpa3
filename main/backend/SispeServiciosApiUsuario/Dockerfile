FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
RUN ls
COPY ["SispeServiciosApiUsuario/SispeServiciosApiUsuario.csproj", "SispeServiciosApiUsuario/"]


RUN dotnet restore "SispeServiciosApiUsuario/SispeServiciosApiUsuario.csproj"
COPY . .
WORKDIR "/src/SispeServiciosApiUsuario"
RUN dotnet build "SispeServiciosApiUsuario.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "SispeServiciosApiUsuario.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SispeServiciosApiUsuario.dll"]