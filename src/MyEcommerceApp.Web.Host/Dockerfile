FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/MyEcommerceApp.Web.Host/MyEcommerceApp.Web.Host.csproj", "src/MyEcommerceApp.Web.Host/"]
COPY ["src/MyEcommerceApp.Web.Core/MyEcommerceApp.Web.Core.csproj", "src/MyEcommerceApp.Web.Core/"]
COPY ["src/MyEcommerceApp.Application/MyEcommerceApp.Application.csproj", "src/MyEcommerceApp.Application/"]
COPY ["src/MyEcommerceApp.Core/MyEcommerceApp.Core.csproj", "src/MyEcommerceApp.Core/"]
COPY ["src/MyEcommerceApp.EntityFrameworkCore/MyEcommerceApp.EntityFrameworkCore.csproj", "src/MyEcommerceApp.EntityFrameworkCore/"]
WORKDIR "/src/src/MyEcommerceApp.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/MyEcommerceApp.Web.Host", "src/MyEcommerceApp.Web.Host"]
COPY ["src/MyEcommerceApp.Web.Core", "src/MyEcommerceApp.Web.Core"]
COPY ["src/MyEcommerceApp.Application", "src/MyEcommerceApp.Application"]
COPY ["src/MyEcommerceApp.Core", "src/MyEcommerceApp.Core"]
COPY ["src/MyEcommerceApp.EntityFrameworkCore", "src/MyEcommerceApp.EntityFrameworkCore"]
WORKDIR "/src/src/MyEcommerceApp.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "MyEcommerceApp.Web.Host.dll"]
