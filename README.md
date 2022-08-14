#### By _**Megan McKissack**_

## Description

An MVC app for a factory owner to manage their engineer employees, machines in their inventory, and which engineers are licensed to repair which machine. Data is stored in an SQL database using a many to many model.

## Technologies Used

- _C#_
- _.NET 5_
- _ASP.NET Core MVC_
- _MySQL_
- _Entity Framework Core_
- _HTML_
- _CSS_


## Setup/Installation Requirements

### File and Package installation

- using your terminal, clone or download this repository to your computer
- Open files in your favorite text editor or IDE
- cd into the Factory.Solution/Factory folder and run the command `dotnet restore` to install the necessary packages to run the program

### Database Setup

- to connect the app to the database you'll need to have [MySQL](https://dev.mysql.com/doc/mysql-installation-excerpt/5.7/en/) and [MySQL Workbench](https://www.mysql.com/products/workbench/) installed.

### Connecting the Database to the App

- in your local repository, create a `appsettings.json` in the main project folder `Factory` to store your database login so that app can connect to the database and retrieve/add information
  - then add this code to the file:
    `{ "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME];uid=[YOUR-USER-ID];pwd=[YOUR-PASSWORD-HERE];" } }`
- In your terminal use the command `dotnet ef migrrations add Initial` to create your first datbase migration, initializing the tables and settings for the apps database
- Then use the command `dotnet ef database update` to sent the migration information to MySQL, you can press refesh in the Administration menu in MySQL Workbench to verify the new database and tables.
- also update your `.gitignore` file with `*/appsettings.json` so that you don't accidently make your database login information public if you push your projected to a remote repository


### Interacting with the app

- To view and use the application, navigate to the `Factory` folder and use the command `dotnet run` to start your local server and navigate to [http://localhost:5000](http://localhost:5000) in your web browser and interact with the application

## Known Bugs

_none_

## License

_MIT_

Copyright (c) _July 27, 2022_ _Megan McKissack_
