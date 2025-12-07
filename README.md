# Olbrasoft.Extensions

[![Build & Publish](https://github.com/Olbrasoft/Extensions/actions/workflows/publish-nuget.yml/badge.svg)](https://github.com/Olbrasoft/Extensions/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Olbrasoft.Extensions.svg)](https://www.nuget.org/packages/Olbrasoft.Extensions/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Olbrasoft.Extensions.svg)](https://www.nuget.org/packages/Olbrasoft.Extensions/)
[![License](https://img.shields.io/badge/license-MIT-green)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-8.0%20%7C%209.0%20%7C%2010.0-blue)](https://dotnet.microsoft.com/)

Extension methods for classes from the System namespace.

## Installation

```bash
dotnet add package Olbrasoft.Extensions
```

Or via Package Manager:

```powershell
Install-Package Olbrasoft.Extensions
```

## Features

This package provides extension methods for:

- **Decimal** - Rounding, formatting, and conversion utilities
- **Enum** - Enum parsing and manipulation helpers
- **Type** - Type reflection and analysis extensions
- **Paging** - Pagination extension methods for collections

## Usage Examples

```csharp
using Olbrasoft.Extensions;

// Decimal extensions
decimal value = 123.456789m;
var rounded = value.RoundTo(2); // 123.46

// Enum extensions
var enumValue = "Value".ToEnum<MyEnum>();

// Paging extensions
var pagedResult = items.ToPagedResult(pageNumber, pageSize);
```

## Target Frameworks

- .NET Standard 2.0
- .NET Standard 2.1
- .NET 8.0
- .NET 9.0
- .NET 10.0

## Building from Source

```bash
git clone https://github.com/Olbrasoft/Extensions.git
cd Extensions
dotnet restore
dotnet build
dotnet test
```

## License

This project is licensed under the **MIT License**.

## Author

- **Jiří Tůma**
- **Company**: Olbrasoft
- **Repository**: [https://github.com/Olbrasoft/Extensions](https://github.com/Olbrasoft/Extensions)

---

![Olbrasoft Extensions](./olbrasoft-extensions.png)

**Copyright © 2021-2025 Olbrasoft**
