# Expense Tracker in ASP.NET CORE
[Source](https://www.youtube.com/watch?v=zQ5eijfpuu8&ab_channel=CodAffection)

--- ---
## Required Tools

- Entity Framework Core
- Entity Framework Sql Server
- Entity Framework Core Tools

--- ---

## Add Models

- Category
- Transactions
- Transactions

--- ---

## Adding Database Connection to Project

- Add database connection 

```C#
"ConnectionStrings": {
    "DefaultConnection": "Server=[Server-Name];Database=TransactionDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True"
  }
```
```C#
using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext: DbContext
    {
        // Add constructor to db context class  
        public ApplicationDbContext(DbContextOptions options): base(options) {
            
        }    
        
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

```

```C#
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// dependency injection
builder.Services.AddDbContext<Expense_Tracker.Models.ApplicationDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );
var app = builder.Build();
var app = builder.Build();
```

--- ---

## Apply Migration 
### Run following commands

- build the project
- open nuget package manager console

```bash
Add-Migration "migration-name"
Update-Database
```

--- ---

## Add Syncfuciont to thej Application
[Syncfunction](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=youtube&utm_medium=video&utm_campaign=syncfusion_codaffection_yt)

- We are using **_CDN_** for **_Syncfusion_**

--- ---

## Current Task

- Add **_Syncfuncion_** to the app

--- ---

## Additional tools Installed

- Syncfusion EJ2 ASP.NET CORE
- Add following line in **__ViewImports.cshtml_**

```cshtml
@addTagHelper *, Syncfusion.EJ2
```
--- ---