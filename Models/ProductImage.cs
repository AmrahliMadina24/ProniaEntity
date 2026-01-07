using ProniaAdmin.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ProniaAdmin.Models
{
    public class ProductImage : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string ImageUrl { get; set; }
    }
}