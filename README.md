# _EauClaireSalon.Solution_

#### _MVC web application to manage stylists and clients_

#### By **Laura Hope**

## Technologies Used

* _C#_
* _.NET v6.0_
* _MySQLWorkbench_
* _MS EntityFrameworkCore v6.0.0_
* _Pomelo EntityFrameworkCore MySQL v6.0.0_
* _Git_
* _VSCode_

## Description

_This application showcases using EFCore and MySQL to create and link database schemas to the project models. Application uses HTML helper methods, LINQ commands, and navigation properties to allow the salon owner to add stylists and link clients to each stylist using one-to-many relationships._

## Setup/Installation Requirements

**Installing MySQL Workbench**
1. Launch MySQL Workbench and click "Local Instance 3306" to reach navigator window
2. Select the "Administration" tab and click "Data Import/Restore"
3. Click "import from self-contained file" and select "..." to navigate to the file titled "laura_hope.sql" in the top level of this project
4. Under the drop down "Default Schema to be Imported to" select the button to the right labeled "New..." and enter a **schema name** of your choosing
5. Click "Start Import" in the bottom right of the window

**Project Set-Up**
* _Clone "EauClaireSalon".Solution“ from the repository to your desktop_
* _Navigate to "EauClaireSalon.Solution" directory via your local terminal command line_
* _Create a file ".gitignore" in the "EauClaireSalon.Solution" directory_
```
$ touch .gitignore
```
* _Copy/paste the following in the .gitignore file:_
```
obj
bin
appsettings.json
```
* _Navigate to the production directory "HairSalon"_
* _Create a file within the "HairSalon" folder titled "appsettings.json"_
```
$ touch appsettings.json
```
* _Navigate to the appsettings.json file and copy/paste the following text within the file:_
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[SCHEMA-DB-NAME];uid=[USER-ID];pwd=[USER-PW];"
  }
}
```
* _Remove the square brackets and replace **USER-ID**, **USER-PW**, and **SCHEMA-DB-NAME** with your own ID, password, and schema named use in MySQL Workbench step 4_
* _Navigate to the command line within the "HairSalon" folder and execute command "dotnet build"_
* _Add the EF Core packages by typing the following into the command line:_
```
$ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
```
* _Return to the command line and type "dotnet watch run" - this should automatically open a browser to the LocalHost:5000 or LocalHost:5001_
* _This is where you can interact with the application via entering stylists, clientele, etc._

## Known Bugs

* _No known bugs as of 5/19/23_

## License

MIT License

Copyright (c) [2023] [Laura Hope]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

_If you run into any issues or have questions, ideas or concerns, please reach out to me via email: lauramhope.dpt@gmail.com.  Contributions to the code are highly encouraged._