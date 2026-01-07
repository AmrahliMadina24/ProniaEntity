using ProniaAdmin.Models.Common;

namespace ProniaAdmin.Models;

public class Brand : BaseEntity
{
    public string Name { get; set; }
    public ICollection<ProductBrand> ProductBrands { get; set; } = [];
}