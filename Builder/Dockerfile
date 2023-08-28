FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Builder/Builder.csproj", "Builder/"]
RUN dotnet restore "Builder/Builder.csproj"
COPY . .
WORKDIR "/src/Builder"
RUN dotnet build "Builder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Builder.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Builder.dll"]
