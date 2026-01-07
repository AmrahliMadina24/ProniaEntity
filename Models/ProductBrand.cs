using ProniaAdmin.Models.Common;

namespace ProniaAdmin.Models;

public class ProductBrand : BaseEntity
{
    public int BrandId { get; set; }
    public Brand Brand { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
}