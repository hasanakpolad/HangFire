dotnet publish HangFireExample.csproj -c Debug -o publish

docker build -t hangfire:latest .

docker tag hangfire:latest hsnakpld/hangfire:latest

docker push hsnakpld/hangfire:latest