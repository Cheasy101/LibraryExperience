using System.ComponentModel.DataAnnotations;

namespace mssql.Data.Domain;

public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    public ICollection<ProductCategory> ProductCategories { get; set; }
}