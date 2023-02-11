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