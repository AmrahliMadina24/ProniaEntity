using ProniaAdmin.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ProniaAdmin.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}