using Microsoft.AspNetCore.Identity;

namespace ProniaAdmin.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<BasketItem> BasketItems { get; set; } = [];

    }
}
