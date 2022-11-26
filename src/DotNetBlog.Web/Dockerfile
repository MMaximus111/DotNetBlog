FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/DotNetBlog.Web/DotNetBlog.Web.csproj", "src/DotNetBlog.Web/"]
RUN dotnet restore "src/DotNetBlog.Web/DotNetBlog.Web.csproj"
COPY . .
WORKDIR "/src/src/DotNetBlog.Web"
RUN dotnet build "DotNetBlog.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DotNetBlog.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotNetBlog.Web.dll"]
