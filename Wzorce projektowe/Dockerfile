FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Wzorce projektowe/Wzorce projektowe.csproj", "Wzorce projektowe/"]
RUN dotnet restore "Wzorce projektowe/Wzorce projektowe.csproj"
COPY . .
WORKDIR "/src/Wzorce projektowe"
RUN dotnet build "Wzorce projektowe.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Wzorce projektowe.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Wzorce projektowe.dll"]
