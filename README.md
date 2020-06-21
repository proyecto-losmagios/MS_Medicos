# Micro servicio de médicos

Levantar servicio

    dotnet run -p API

URL: http://localhost:4300


## Comandos para creación del proyeto

Crear el proyecto

    dotnet new sln -n API
    dotnet new webapi -n API -f netcoreapp3.1 
    dotnet new classlib -n Domain -f netcoreapp3.1
    dotnet new classlib -n Application -f netcoreapp3.1
    dotnet new classlib -n AccessData -f netcoreapp3.1

Agregar proyectos

    dotnet sln add API/API.csproj 
    dotnet sln add Application/Application.csproj 
    dotnet sln add Domain/Domain.csproj 
    dotnet sln add AccessData/AccessData.csproj 

Agregar referencias

    dotnet add API/API.csproj reference Application/Application.csproj
    dotnet add API/API.csproj reference AccessData/AccessData.csproj
    dotnet add Application/Application.csproj reference Domain/Domain.csproj
    dotnet add AccessData/AccessData.csproj reference Domain/Domain.csproj
    dotnet add AccessData/AccessData.csproj reference Application/Application.csproj

Agregar el paquete para PostgreSQL, ORM y otros:

    dotnet add API/API.csproj package Microsoft.EntityFrameworkCore
    dotnet add API/API.csproj package Microsoft.EntityFrameworkCore.Tools
    dotnet add API/API.csproj package Npgsql.EntityFrameworkCore.PostgreSQL
    dotnet add API/API.csproj package Npgsql.EntityFrameworkCore.PostgreSQL

    dotnet add AccessData/AccessData.csproj package Npgsql.EntityFrameworkCore.PostgreSQL
    dotnet add AccessData/AccessData.csproj package Microsoft.EntityFrameworkCore
    dotnet add AccessData/AccessData.csproj package SqlKata
    dotnet add AccessData/AccessData.csproj package SqlKata.Execution
    dotnet add AccessData/AccessData.csproj package Microsoft.EntityFrameworkCore.Design  


Crear base de datos

    dotnet new tool-manifest
    dotnet tool install --local dotnet-ef

Crear Migration y aplicar migration

    cd AccessData
    dotnet ef migrations add EspecialidadesModel -s ../API/
    dotnet ef database update -s ../API/

Comandos de dotnet-ef:

    dotnet ef migrations add
    dotnet ef migrations list
    dotnet ef migrations script
    dotnet ef dbcontext info
    dotnet ef dbcontext scaffold
    dotnet ef database drop
    dotnet ef database update


Levantar Docker de PostgreSQL

    docker-compose up -d

Borrar todos los contenedores

    docker rm $(docker ps -a -q)

Borrar todas las imágenes

    docker rmi $(docker images -q)