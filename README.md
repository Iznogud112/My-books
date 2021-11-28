# My books Web application

## Introduction
Simple web application where user can add, edit or delete books, publishers and authors using Postman or Swagger<br/>
This project is for learning .Net Core 5 and Unit Test

## Technologies
* .Net Core 5
* My SQL

## Frameworks
* Microsoft.aspnetcore.mvc.versioning
* Microsoft.entityframeworkcore
* Microsoft.entityframeworkcore.sqlserver
* Microsoft.entityframeworkcore.tools
* Swashbuckle.aspnetcore
* Serilog.aspnetcore
* Serilog.sinks.file
* Serilog.sinks.mssqlserver
* Microsoft.entityframeworkcore.inmemory

Install Back-End
1. Import 'my-books' in Visual Studio (Open project or solution -> my-books.sln into Workspace)
2. Database connection string can be updated in appsettings.json file (my-books\appsettings.json)
* After restarting server, database will be again in initial state
3. Test if REST APIs are successfully exposed (using Postman or Swagger)
