#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-nanoserver-1803 AS build
WORKDIR /src
COPY ["Applications/Shop.UI/Shop.UI.csproj", "Applications/Shop.UI/"]
RUN dotnet restore "Applications/Shop.UI/Shop.UI.csproj"
COPY . .
WORKDIR "/src/Applications/Shop.UI"
RUN dotnet build "Shop.UI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Shop.UI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Shop.UI.dll"]