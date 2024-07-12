# mood-radio-service

# Commands
dotnet build => build project
dotnet run => run project
dotnet restore => nuget
dotnet add package Newtonsoft.Json => adds pacakges with Json as example
docker run --name my-postgres --network bridge -e POSTGRES_PASSWORD=postgres -d -p 5432:5432 postgres
=> Docker DB
docker ps => sees container ID and other info
docker inspect <CONTAINER ID> | grep IPAddress => get IP to run for mac
docker inspect <CONTAINER ID> | findstr IPAddress => get IP to run for windows
docker build -t prism-bucket-service . => builds it
docker run -d -p 8080:80 prism-bucket-service => runs it
docker run -d -p 8080:80 --name prism-bucket-container prism-bucket-service => runs it as container
dotnet add package Microsoft.AspNetCore.Cors => for cors