FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine as sdk

RUN apk update; \
    apk add --no-cache \
    gcompat \
    libc6-compat

WORKDIR /src

COPY . .

RUN dotnet build

ENTRYPOINT dotnet run --no-build --no-restore
