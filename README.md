# BikeStore application with [Dapper](https://en.wikipedia.org/wiki/Dapper_ORM) and [WindForm](https://en.wikipedia.org/wiki/Windows_Forms)

A ready-made MSSQL database named [Bike Stores Sample Database](https://www.sqlservertutorial.net/sql-server-sample-database/) >> `Download SQL Server Sample Database` is used. <br />

    ?   create database DapperDB or otherName  :  use DapperDB or otherName;
        create object query;   >>   load data query;

MSSQL [DB\Programmability\Stored Procedures]() were written for queries.

### NuGet Gallery
- Some packages can be installed from the "[NuGet Gallery](https://www.nuget.org/packages/Microsoft.AspNet.Identity.Core)" with the help of the `Tools > NuGet Package Manager > Package Manager Console`.

- [System.Configuration.ConfigurationManager 7.0.0](https://www.nuget.org/packages/System.Configuration.ConfigurationManager/7.0.0)
```
    PM>  NuGet\Install-Package System.Configuration.ConfigurationManager -Version 7.0.0
```
- [Dapper 2.0.143](https://www.nuget.org/packages/Dapper/2.0.143) | [github](https://github.com/DapperLib/Dapper)
```
    PM>  NuGet\Install-Package Dapper -Version 2.0.143
```

![](/pictures/dapper.gif)
