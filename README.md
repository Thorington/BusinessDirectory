# Local Business Lookup
<!-- ![a picture of the page's header](Menu/wwwroot/img/header.jpg) -->

#### Contributors: _**Claire Thorington**_

## Technologies Used

* Markdown
* HTML
* CSS
* C#
* .NET
* ASP.NET Core MVC
* Razor
* MySQL
* Entity Framework Core
* Identity

## Description & Schema

This API lists local businesses in Portland, Oregon. The directory can be curated by BusinessType (i.e. Restaurant, Food Cart, Bar, Art Gallery).


<!-- ![a picture of the program's schema](Menu/wwwroot/img/schema.jpg) -->

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

## Known Bugs

* None


## License

[<a href=LICENSE>MIT</a>]

Copyright (c) _2022_ _Claire Thorington_

