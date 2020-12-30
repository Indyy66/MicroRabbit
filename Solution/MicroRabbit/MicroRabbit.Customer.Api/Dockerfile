#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["MicroRabbit.Customer.Api/MicroRabbit.Customer.Api.csproj", "MicroRabbit.Customer.Api/"]
RUN dotnet restore "MicroRabbit.Customer.Api/MicroRabbit.Customer.Api.csproj"
COPY . .
WORKDIR "/src/MicroRabbit.Customer.Api"
RUN dotnet build "MicroRabbit.Customer.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroRabbit.Customer.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroRabbit.Customer.Api.dll"]