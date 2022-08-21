# Independent Project #12: Local Business Lookup

#### Contributors: _**Claire Thorington**_

## Technologies Used

* Markdown
* HTML
* CSS
* C#
* .NET
* ASP.NET Core MVC
* MySQL
* Entity Framework Core
* Swagger

## Description

This API lists local businesses in Portland, Oregon. The directory has one endpoint, Businesses, which can be curated by the following properties:
* BusinessType (i.e. Restaurant, Food Cart, Bar, Art Gallery)
* BusinessName
* BusinessWebsite

Swagger documentation has been successfully implemented (I think!)

## Setup & Installation Requirements

* Clone repository to desktop
* Create an _appsettings.json_ file in the __BusinessDirectory__ directory and copy in the following:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=businessdirectory;uid=root;pwd=epicodus;"
  }
}
```

* Navigate to the __BusinessDirectory__ directory in your terminal and enter the following commands, in order:
```console
$ dotnet restore
$ dotnet ef database update
$ dotnet run
```
* To view Swagger documentation, visit <https://localhost:[yourlocalhost]/swagger/v1/swagger.json>

## Known Bugs

* None


## License

[<a href=LICENSE>MIT</a>]

Copyright (c) _2022_ _Claire Thorington_

