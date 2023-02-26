FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ASP.NETCore4shlomo/ASP.NETCore4shlomo.csproj", "ASP.NETCore4shlomo/"]
RUN dotnet restore "ASP.NETCore4shlomo/ASP.NETCore4shlomo.csproj"
COPY . .
WORKDIR "/src/ASP.NETCore4shlomo"
RUN dotnet build "ASP.NETCore4shlomo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ASP.NETCore4shlomo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ASP.NETCore4shlomo.dll"]
