# _Pierre's Bakery 2.0_

#### _Epicodus 2020 C#/React Cohort ASP.NET Core MVC Friday Project._

#### By _**Geoff Goetz | 13 March 2020**_

## Description

This project is a website where Pierre can track the vendors he supplies bakery products too and as well as how much of each product is being supplied in each order.

## Specifications:

| Specification | Example Input | Example Output |
| :-----------: |:-------------:| :-------------:| 
| Application creates instance of ``Vendor`` object when user submits form | user enters vendor name then submits form | new ``Vendor`` object created for that ``Vendor`` name |
| Application creates instance of ``Order`` object inside its associated ``Vendor`` when user submits form | user enters order item quantities, price total, date and description then submits form | new ``Order`` object created for that ``Vendor`` name |
| Application allows users to view all ``Vendor``s | user clicks link to display ``Vendor``s | webpage routes to page showing all ``Vendor``s |
|Application allows users to select a ``Vendor`` to view all ``Order``s of selected ``Vendor`` |  user clicks link to display selected ``Vendor``s ``Order``s | webpage routes to a list of ``Order``s for the selected ``Vendor`` |
| Application allows users to view all ``Order``s associated with the selected ``Vendor`` | user clicks link to display any specific ``Order`` | webpage routes to page showing  |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone https://github.com/Pieharder/PierresBakery2.0``
* ``cd PierresBakery2.0``

_Confirm that you have navigated to the PierresBakery2.0 directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_To view/edit the source code of this application, open the contents of the TravelDiary.Solution directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code, enter the command_ ``code .`` _in Terminal)._

_Run this console application by entering the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd PierresBakery2.0``
* ``dotnet restore``
* ``dotnet run``

## Technologies Used
* _Git_
* _C#_
* _ASP.NET Core MVC_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Geoff Goetz_**