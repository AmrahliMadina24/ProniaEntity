using ProniaAdmin.Models.Common;

namespace ProniaAdmin.Models
{
    public class BasketItem : BaseEntity
    {
        public string AppUserId { get; set; } = null!;
        public AppUser AppUser { get; set; } = null!;
        public int Count { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
