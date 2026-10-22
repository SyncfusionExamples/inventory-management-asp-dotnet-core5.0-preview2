# Inventory Management using ASP.NET Core 5.0 Preview 2 and Entity Framework Core 5.0 Preview 2 (.NET 5.0 Preview 2)

## Overview

This sample demonstrates how to build a product inventory web application with ASP.NET Core 5.0 Preview 2, Entity Framework Core 5.0 Preview 2, and SQL Server. The MVC application exposes create, read, update, and delete operations on a product catalog through a `ProductsController` and persists the data using an Entity Framework Core database context. Razor views render a Bootstrap-based listing page plus Create, Edit, Details, and Delete forms, providing a practical pattern for server-rendered CRUD applications backed by a relational database.

## Key Features

- Lists every product in a Bootstrap table on the landing route, with each row pulled from SQL Server through an Entity Framework Core `DbSet` (the table-tracked collection of products).
- Provides full create, read, update, and delete operations for product records through standard MVC actions exposed by `ProductsController`.
- Creates a new product through a server-validated form that posts to the `Create` action and saves the record to the SQL Server database.
- Edits an existing product by reloading it through the Entity Framework Core `FindAsync` lookup method and applying the updated field values one by one.
- Deletes a product through a confirmation page that calls the Entity Framework Core `Remove` method on the products `DbSet` and persists the deletion.
- Shows a read-only details page for a single product selected by its primary key value.
- Routes every request through the default `{controller=Products}/{action=Index}/{id?}` pattern so the inventory listing is the landing view.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework
- SQL Server 2017 or later / SQL Server Express / SQL Server LocalDB

## How to Run the Project

### Visual Studio 2022

1. Clone or download this repository.
2. Open the solution file:

   `inventory-management-asp-dotnet-core5.0-preview2/InventoryManagement.sln`

3. Update the SQL Server connection string under `ConnectionStrings:InventoryDatabase` in `inventory-management-asp-dotnet-core5.0-preview2/appsettings.json` with the server name, database name, and authentication details for a database that you are authorized to access.
4. Restore the NuGet packages by rebuilding the solution.
5. Set the startup project to:

   `InventoryManagement`

6. Build the solution.
7. Run the application using `Ctrl+F5`.
8. Open the application URL displayed by Visual Studio after launch.
9. Verify that the Products inventory listing is displayed as the landing page with the Create New, Edit, Details, and Delete actions available for each row.

### Visual Studio Code

1. Clone or download this repository.
2. Open the repository folder in Visual Studio Code.
3. Open the integrated terminal.
4. Navigate to the project directory:

```bash
cd inventory-management-asp-dotnet-core5.0-preview2
```

5. Update the SQL Server connection string under `ConnectionStrings:InventoryDatabase` in `appsettings.json` with the server name, database name, and authentication details for a database that you are authorized to access.
6. Restore the NuGet packages:

```bash
dotnet restore
```

7. Build the project:

```bash
dotnet build
```

8. Run the project:

```bash
dotnet run
```

9. Open the local URL displayed in the terminal after the application starts.
10. Verify that the Products inventory listing is displayed as the landing page with the Create New, Edit, Details, and Delete actions available for each row.

## Project Structure

- `inventory-management-asp-dotnet-core5.0-preview2/Controllers/ProductsController.cs` — MVC controller that defines the create, read, update, and delete actions for products.
- `inventory-management-asp-dotnet-core5.0-preview2/Controllers/HomeController.cs` — MVC controller that serves the default home and privacy pages.
- `inventory-management-asp-dotnet-core5.0-preview2/Models/Products.cs` — entity class that models a product with name, category, color, unit price, available quantity, and created date fields.
- `inventory-management-asp-dotnet-core5.0-preview2/Models/InventoryContext.cs` — Entity Framework Core database context that exposes the products table and configures its columns.
- `inventory-management-asp-dotnet-core5.0-preview2/Models/ProductsMetaData.cs` — data annotations and metadata that drive server-side and client-side validation on the product forms.
- `inventory-management-asp-dotnet-core5.0-preview2/Views/Products/Index.cshtml` — Razor view that renders the products listing table with create, edit, details, and delete links.
- `inventory-management-asp-dotnet-core5.0-preview2/Views/Products/Create.cshtml` — Razor view with the form used to add a new product.
- `inventory-management-asp-dotnet-core5.0-preview2/Views/Products/Edit.cshtml` — Razor view with the form used to update an existing product.
- `inventory-management-asp-dotnet-core5.0-preview2/Views/Products/Details.cshtml` — Razor view that shows the read-only details of a single product.
- `inventory-management-asp-dotnet-core5.0-preview2/Views/Products/Delete.cshtml` — Razor view that confirms the deletion of a product.

## Support and Feedback

- To report an issue specific to this sample, open a GitHub issue in this repository.
- Official documentation: [ASP.NET Core documentation](https://learn.microsoft.com/aspnet/core/)