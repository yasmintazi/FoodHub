# FoodHub

A food-ordering web app built with Blazor WebAssembly (hosted) and ASP.NET Core. Users can browse and order sushi, meals, drinks, and custom items.

## Tech Stack

- **.NET 5.0** (ASP.NET Core + Blazor WebAssembly)
- **Entity Framework Core** with **SQL Server**
- **ASP.NET Identity** + **IdentityServer4** for authentication

## Project Structure

```
FoodHub.sln
FoodHub/
├── Client/    # Blazor WebAssembly frontend (pages, layout, auth UI)
├── Server/    # ASP.NET Core Web API + Identity/IdentityServer host
│   ├── Controllers/   # Accounts, Meals, Sushis, Drinks, Ingredients, Customs, Orders
│   ├── Data/          # ApplicationDbContext
│   ├── Migrations/    # EF Core migrations
│   └── Repository/    # Generic repository / unit-of-work pattern
└── Shared/    # Domain models shared by Client and Server (Meal, Sushi, Drink, Order, ...)
```

## Prerequisites

- **.NET 5.0 SDK/runtime** — this project targets `net5.0`, which is end-of-life and no longer bundled with current .NET installers. If you only have newer SDKs (.NET 8/10) installed, get the ASP.NET Core 5.0 runtime without touching your global install:

  ```powershell
  Invoke-WebRequest -Uri "https://dot.net/v1/dotnet-install.ps1" -OutFile "dotnet-install.ps1"
  ./dotnet-install.ps1 -Channel 5.0 -Runtime aspnetcore
  ```

  This installs to `%LocalAppData%\Microsoft\dotnet` (user-local, no admin required).

- **SQL Server** (Express or LocalDB) — required for login, menu data, and orders to work. The default connection string in `FoodHub/Server/appsettings.json` expects a local `SQLEXPRESS` instance:

  ```
  Server=.\SQLEXPRESS;Database=FoodHub_db;Trusted_Connection=True;MultipleActiveResultSets=true
  ```

  Update this if your SQL Server instance is named differently.

## Running the app

1. Restore and build:

   ```bash
   dotnet build FoodHub/Server/FoodHub.Server.csproj
   ```

2. Apply EF Core migrations to create the database:

   ```bash
   dotnet ef database update --project FoodHub/Server
   ```

3. Run the server (also serves the Blazor client):

   ```bash
   dotnet run --project FoodHub/Server
   ```

   If you installed the .NET 5 runtime via the user-local script above (not your machine's global .NET install), point `dotnet` at it first:

   ```powershell
   $env:DOTNET_ROOT="$env:LocalAppData\Microsoft\dotnet"; $env:PATH="$env:DOTNET_ROOT;$env:PATH"
   dotnet run --project FoodHub/Server
   ```

4. Open the app:

   - http://localhost:5000
   - https://localhost:5001 (self-signed dev cert — expect a browser warning)

## Known Issues

- The `net5.0` target framework is unsupported/unpatched upstream; consider retargeting to `net8.0` (LTS) for long-term maintenance.
- Without a reachable SQL Server instance, the app still starts, but login, menu browsing, and ordering will fail since they hit the database.
