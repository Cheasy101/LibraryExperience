using System.ComponentModel.DataAnnotations;

namespace mssql.Data.Domain;

public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    public string Name { get; set; }

    public ICollection<ProductCategory> ProductCategories { get; set; }
}