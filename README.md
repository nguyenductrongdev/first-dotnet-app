# Setup
```
docker pull mcr.microsoft.com/mssql/server:2022-latest
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=RMUp8&?nG,:t~b[FeZwSg6" -p 1433:1433 -d --name sqlserver --hostname sql1 -d mcr.microsoft.com/mssql/server:2022-latest
```

# MSSql CLI
```
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P 'RMUp8&?nG,:t~b[FeZwSg6'
```
```
CREATE DATABASE Student;
GO
USE Student;
GO
CREATE TABLE Student (Id INT PRIMARY KEY, Name NVARCHAR(50));
GO
```

# Starts
```
dotnet run
```
