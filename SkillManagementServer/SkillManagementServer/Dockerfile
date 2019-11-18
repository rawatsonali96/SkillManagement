FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["SkillManagementServer/SkillManagementServer.csproj", "SkillManagementServer/"]
RUN dotnet restore "SkillManagementServer/SkillManagementServer.csproj"
COPY . .
WORKDIR "/src/SkillManagementServer"
RUN dotnet build "SkillManagementServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SkillManagementServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SkillManagementServer.dll"]