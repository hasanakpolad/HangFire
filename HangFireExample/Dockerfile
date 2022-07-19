FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
FROM mcr.microsoft.com/dotnet/sdk:6.0

COPY /publish /Hangfire
WORKDIR /Hangfire
EXPOSE 80

ENTRYPOINT [ "dotnet","HangFireExample.dll" ]