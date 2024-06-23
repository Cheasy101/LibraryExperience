using MSSSQL.Data.Domain;

namespace MSSSQL.Data;

using System.Linq;

public static class DataContextSeed
{
    public static void Seed(ApplicationDbContext context)
    {
        if (!context.Products.Any())
        {
            var product1 = new Product { Name = "Product1" };
            var product2 = new Product { Name = "Product2" };

            var category1 = new Category { Name = "Category1" };
            var category2 = new Category { Name = "Category2" };

            context.Products.AddRange(product1, product2);
            context.Categories.AddRange(category1, category2);

            context.ProductCategories.AddRange(
                new ProductCategory { Product = product1, Category = category1 },
                new ProductCategory { Product = product1, Category = category2 },
                new ProductCategory { Product = product2, Category = category1 }
            );

            context.SaveChanges();
        }
    }
}
