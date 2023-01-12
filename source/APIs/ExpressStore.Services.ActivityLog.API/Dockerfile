#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["source/APIs/ExpressStore.Services.ActivityLog.API/ExpressStore.Services.ActivityLog.API.csproj", "source/APIs/ExpressStore.Services.ActivityLog.API/"]
RUN dotnet restore "source/APIs/ExpressStore.Services.ActivityLog.API/ExpressStore.Services.ActivityLog.API.csproj"
COPY . .
WORKDIR "/src/source/APIs/ExpressStore.Services.ActivityLog.API"
RUN dotnet build "ExpressStore.Services.ActivityLog.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExpressStore.Services.ActivityLog.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExpressStore.Services.ActivityLog.API.dll"]