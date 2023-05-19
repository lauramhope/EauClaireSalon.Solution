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

* _Clone "EauClaireSalon".Solution“ from the repository to your desktop_
* _Navigate to "EauClaireSalon.Solution" directory via your local terminal command line_
* _Navigate to the production directory "HairSalon"_
* _Create a file within the "HairSalon" folder titled "appsettings.json"_
```
$ touch appsettings.json
```
* _Navigate to the appsettings.json file and copy/paste the following text within the file:_
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=laura_hope;uid=[USER-ID];pwd=[USER-PW];"
  }
}
```
* _Replace [USER-ID] and [USER-PW] with your own ID and password (excluding the brackets)_
* _Navigate to the command line within the "HairSalon" folder and execute command "dotnet build"_
* _Return to the command line and type "dotnet watch run" - this should automatically open a browser to the LocalHost:5000 or LocalHost:5001
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