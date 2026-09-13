# .NET Lab

A collection of C# laboratory exercises covering OOP fundamentals through generics, collections, and ASP.NET Core MVC. Each exercise is a standalone project — there is no solution file.

## Prerequisites

- .NET 10.0 SDK
- Any editor (Visual Studio, VS Code, or JetBrains Rider)

## Structure

- `Lab_1/ConsoleApp1..22` — OOP: classes, constructors, inheritance, method overloading, abstract classes, interfaces, partial classes, delegates/lambdas, indexers
- `Lab_2/ConsoleApp1..8` — generics and collections (`List<T>`, `Dictionary<TKey,TValue>`, `Queue<T>`, `Stack<T>`)
- `Lab_3/StudentRegistration` — ASP.NET Core MVC student CRUD app (in-memory store, no database)

## Running the Labs

Console exercises (pick the project directory):

```bash
cd Lab_1/ConsoleApp1
dotnet run
```

```bash
cd Lab_2/ConsoleApp4
dotnet run
```

Build one project:

```bash
cd Lab_1/ConsoleApp1
dotnet build
```

MVC app:

```bash
cd Lab_3/StudentRegistration
dotnet run
```

Then open `http://localhost:5027` (see `Properties/launchSettings.json` for the `http`/`https` profiles).

## Technology Stack

- **Language:** C#
- **Framework:** .NET 10.0 (`ImplicitUsings` + `Nullable` enabled)
- **Project types:** console apps (`Microsoft.NET.Sdk`), one MVC web app (`Microsoft.NET.Sdk.Web`)

## Notes

- Each project is self-contained and runs independently.
- The assignment text for console labs lives in the header comment of each `Program.cs`.
- `bin/` and `obj/` are git-ignored build output — never commit them.
