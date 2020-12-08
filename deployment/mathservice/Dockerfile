FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
LABEL maintainer = "velumookkaiah@gmail.com"

WORKDIR /opt/mathservice
COPY . .

RUN chmod +x entrypoint.sh \
    && \
    rm -f   /usr/share/doc/pygpgme-0.3/tests/keys/key1.sec \
            /usr/share/doc/pygpgme-0.3/tests/keys/key2.sec \
            /usr/share/doc/pygpgme-0.3/tests/keys/signonly.sec \
    && \
    mv *CA.crt /etc/pki/ca-trust/source/anchors/ && \
    update-ca-trust

ENTRYPOINT ["./entrypoint.sh"]

# EXPOSE 5000
# ENV ASPNETCORE_URLS=http://*:5000

# // FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
# // WORKDIR /src
# // COPY ["mathservice.csproj", "./"]
# // RUN dotnet restore "./mathservice.csproj"
# // COPY . .
# // WORKDIR "/src/."
# // RUN dotnet build "mathservice.csproj" -c Release -o /app/build

# // FROM build AS publish
# // RUN dotnet publish "mathservice.csproj" -c Release -o /app/publish

# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "mathservice.dll"]
