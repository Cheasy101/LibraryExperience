using System.ComponentModel.DataAnnotations.Schema;

namespace MSSSQL.Data.Domain;
/// <summary>
/// таблица связка т.к отношение многие ко многим
/// </summary>
public class ProductCategory
{
    public int ProductId { get; set; }
    [ForeignKey($"{nameof(ProductId)}")]
    public Product Product { get; set; }

    public int CategoryId { get; set; }
    [ForeignKey($"{nameof(CategoryId)}")]
    public Category Category { get; set; }
}