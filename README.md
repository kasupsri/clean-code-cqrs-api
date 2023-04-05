# Product API Solution

## Description

Product API Solution is a .NET web API that enables users to retrieve product information and add new products. The application is built using .NET 6 with C#.

## Features

- Retrieve all products
- Retrieve a single product by ID
- Add new products

## Getting Started

### Prerequisites

- .NET 6 SDK
- Visual Studio , VS Code or other compatible IDE
- Git

### Installation

1. Clone the repository: `https://github.com/kasupsri/clean-code-cqrs-api.git`
2. Open the solution in Visual Studio or your preferred IDE.
3. Run the solution to start the API.

### Running the Application

Open the solution file (ProductApi.sln) in Visual Studio.

Build the solution using Visual Studio or the following command:

```bash copy
dotnet build
dotnet run --project ProductApi
```

### Usage

The API can be tested using the Swagger UI. To access the Swagger UI, navigate to `/swagger/index.html` on the running server.

### Testing

The solution can be tested using the command line or Test Explorer in Visual Studio.

Command Line
Navigate to the `ProductApi.Tests` directory in the command line and run the following commands:

```bash copy
cd ProductApi.Tests
dotnet test
```

### Dependencies

- MediatR 11.1.0
- Microsoft.EntityFrameworkCore.InMemory 7.0.4
- Swashbuckle.AspNetCore 6.2.3
- FluentAssertions 6.10.0
- Microsoft.NET.Test.Sdk 17.1.0
- Moq 4.18.4
- xunit 2.4.1
- xunit.runner.visualstudio 2.4.3
