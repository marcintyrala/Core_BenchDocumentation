FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Core_BenchDocumentation/Core_BenchDocumentation.csproj", "Core_BenchDocumentation/"]
RUN dotnet restore "Core_BenchDocumentation/Core_BenchDocumentation.csproj"
COPY . .
WORKDIR "/src/Core_BenchDocumentation"
RUN dotnet build "Core_BenchDocumentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Core_BenchDocumentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Core_BenchDocumentation.dll"]