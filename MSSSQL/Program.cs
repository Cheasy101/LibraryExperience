using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MSSSQL.Data;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

// сиды для тестовых данных
using (var context = new ApplicationDbContext(optionsBuilder.Options))
{
    DataContextSeed.Seed(context);
}

using (var context = new ApplicationDbContext(optionsBuilder.Options))
{
    var query = from p in context.Products
        join pc in context.ProductCategories on p.ProductId equals pc.ProductId into productCategories
        from pc in productCategories.DefaultIfEmpty()
        join c in context.Categories on pc.CategoryId equals c.CategoryId into categories
        from c in categories.DefaultIfEmpty()
        select new
        {
            ProductName = p.Name,
            CategoryName = c != null ? c.Name : "No Category"
        };

    foreach (var item in query)
    {
        Console.WriteLine($"Product: {item.ProductName}, Category: {item.CategoryName}");
    }
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();