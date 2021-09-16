#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["OnlineShop.Ordering/OnlineShop.Ordering.Web/OnlineShop.Ordering.Web.csproj", "OnlineShop.Ordering/OnlineShop.Ordering.Web/"]
RUN dotnet restore "OnlineShop.Ordering/OnlineShop.Ordering.Web/OnlineShop.Ordering.Web.csproj"
COPY . .
WORKDIR "/src/OnlineShop.Ordering/OnlineShop.Ordering.Web"

RUN dotnet dev-certs https -ep aspnetapp.pfx -p crypticpassword

RUN dotnet build "OnlineShop.Ordering.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnlineShop.Ordering.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=build /src/OnlineShop.Ordering/OnlineShop.Ordering.Web/aspnetapp.pfx aspnetapp.pfx
ENTRYPOINT ["dotnet", "OnlineShop.Ordering.Web.dll"]
