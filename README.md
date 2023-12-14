# API using ASP.NET
This is an example doing a simple API rest using ASP.NET
### Run Commands
`
dotnet run --launch-profile https
`
### SQL Commands Schema
Person entity:

```
CREATE TABLE Persons (
	Id int NOT NULL PRIMARY KEY,
	FirstName varchar(255),
	LastName varchar(255),
	NumberID varchar(255),
	Email varchar(255),
	TypeID varchar(255),
	CreationDate date,
	TypeNumID AS TypeID + '-' + NumberID,
	FullName AS FirstName + ' ' + LastName
);
CREATE PROCEDURE SelectAllPersons AS
	SELECT TypeNumID, FullName FROM Persons
GO;
```

User entity:
```
CREATE TABLE Users(
	Id int NOT NULL PRIMARY KEY,
	Username varchar(255),
	Passwrd varchar(255),
	CreationDate date
);	
```

