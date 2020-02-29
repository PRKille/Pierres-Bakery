# _Pierre's Bakery_

#### _C# console application project for Epicodus_, _28 Feb. 2020_

#### By _**Patrick Kille**_

## Description

_This console application will allow the user to place an order with Pierre's Bakery and will return a summary and the total cost of that order._

## Specifications:

| Specification | Example Input | Example Output |
|:------------- |:-------------:| -------------------:|
| Should greet user upon startup | dotnet run | "Welcome to Pierre's!"|
| Should prompt user for number of loaves of bread and return cost | "How much bread would you like?" 2 | $10 |
| Should prompt user for number of pastries and return cost | "How many pastries would you like?" 2 | $4 |
| Should display total order with price | "Will that be all?" Y | "Your order is 2 loaves of bread and 2 pastries. That will be $14." |
| Price should reflect 2 for 1 on bread and 3 for $5 pastry pricing | 3 loaves and 3 pastry | Total is 15$ |
| User can pick multiple types of bread | Levain 3, Como 2 | Total $24 |
| User can add on to order | Levain 3, Levain 2 | Levain 5 |
| User can review their order | "View" | Levain 3, Como 1 |
| User can remove items from their order | Has 3, Removes 2 | Levain 1 |
| User cannot remove more items from their order than they have | Has 3, Removes 4 | We don't buy bread! |

## Setup/Installation Requirements

### Prerequisites

1. .NET Framework
* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation
2. Text Editor (Visual Studio Code)

1. Cloning
  * _First, clone this repository to your desktop by opening your terminal and entering the prompt "cd desktop" followed by pressing the enter(return) key. Then type "git clone https://github.com/PRKille/PierresBakery.git" and press enter(return) again._

2. Download
  * _In a web browswer navigate [here](https://github.com/PRKille/PierresBakery.git) to find the GitHub repository._
  * _Click the green "Clone or download" button and selct "Download ZIP"_.

### Running Progam

1. Navigate to the PierresBakery directory in your terminal.

2. Compile and Run code with the "dotnet run" command.


## Technologies Used

_Git, C#, .NET Core, Colorful.Console_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **Patrick Kille**