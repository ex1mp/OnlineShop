#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["OnlineShop.Basket/OnlineShop.Basket.Web/OnlineShop.Basket.Web.csproj", "OnlineShop.Basket/OnlineShop.Basket.Web/"]
RUN dotnet restore "OnlineShop.Basket/OnlineShop.Basket.Web/OnlineShop.Basket.Web.csproj"
COPY . .
WORKDIR "/src/OnlineShop.Basket/OnlineShop.Basket.Web"

RUN dotnet dev-certs https -ep aspnetapp.pfx -p crypticpassword

RUN dotnet build "OnlineShop.Basket.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnlineShop.Basket.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=build /src/OnlineShop.Basket/OnlineShop.Basket.Web/aspnetapp.pfx aspnetapp.pfx
ENTRYPOINT ["dotnet", "OnlineShop.Basket.Web.dll"]
